using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPercent.Checked)
            {
                lblUnit1.Text = "%"; // 單位換成 %
                txtDownPayment.Text = "";    
            }
        }

        private void rbAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmount.Checked)
            {
                lblUnit1.Text = "元"; // 單位換成 元
                txtDownPayment.Text = "";    
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. 將輸入區恢復預設值或清空
            txtHousePrice.Text = "0"; // 房屋總價預設值
            txtDownPayment.Text = "0";      // 自備款預設值
            txtInterestRate.Text = "0";   // 利率預設值
            txtLoanTerm.Text = "0";         // 年限預設值
            txtGracePeriod.Text = "0";       // 寬限期預設值

            // 2. 將自備款選項切換回預設的「比例」
            rbPercent.Checked = true;

            // 3. 把右邊的「結果輸出」區塊全部清空 (變成 0)
            txtTotalLoanAmount.Text = "0";
            txtMonthlyPayment.Text = "0";
            textFirstMonthInterest.Text = "0";
            textFirstMonthPrincipal.Text = "0";
            textTotalInterest.Text = "0";
            textTotalPayment.Text = "0";

            // 4. 加分小巧思：把游標自動移回「房屋總價」的格子，方便使用者直接開始打字
            txtHousePrice.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalHousePrice = 0;
            double downPaymentInput = 0;
            double annualInterestRate = 0;
            int loanTermYears = 0;
            int gracePeriodYears = 0; // 寬限期預設為 0

            // 2. 抓取「房屋總價」並防呆 (! 代表如果轉換失敗，或是金額 <= 0)
            if (!double.TryParse(txtHousePrice.Text, out totalHousePrice) || totalHousePrice <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價（需為大於 0 的數字）！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHousePrice.Focus(); // 把游標移回去讓使用者重填
                return; // 🚨 遇到錯誤就直接中斷，不往下執行
            }

            // 3. 抓取「自備款」
            if (!double.TryParse(txtDownPayment.Text, out downPaymentInput) || downPaymentInput < 0)
            {
                MessageBox.Show("請輸入正確的自備款數值！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDownPayment.Focus();
                return;
            }

            // 4. 抓取「貸款利率」
            if (!double.TryParse(txtInterestRate.Text, out annualInterestRate) || annualInterestRate <= 0)
            {
                MessageBox.Show("請輸入正確的貸款利率！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInterestRate.Focus();
                return;
            }

            // 5. 抓取「貸款年限」 (年限必須是整數，所以用 int.TryParse)
            if (!int.TryParse(txtLoanTerm.Text, out loanTermYears) || loanTermYears <= 0)
            {
                MessageBox.Show("請輸入正確的貸款年限（整數）！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoanTerm.Focus();
                return;
            }

            // 6. 抓取「寬限期」(因為是選填，如果有填字才檢查)
            if (!string.IsNullOrWhiteSpace(txtGracePeriod.Text))
            {
                if (!int.TryParse(txtGracePeriod.Text, out gracePeriodYears) || gracePeriodYears < 0)
                {
                    MessageBox.Show("寬限期請輸入正確的整數年數！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGracePeriod.Focus();
                    return;
                }
                if (gracePeriodYears >= loanTermYears)
                {
                    MessageBox.Show("寬限期必須小於貸款總年限！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGracePeriod.Focus();
                    return;
                }
            }
            double downPaymentValue = 0; // 實際自備款金額

            // 判斷是選「比例」還是「金額」
            if (rbPercent.Checked == true)
            {
                // 如果選比例：房屋總價 * (輸入的比例 / 100)
                downPaymentValue = totalHousePrice * (downPaymentInput / 100);
            }
            else
            {
                // 如果選金額：直接使用輸入的數值
                downPaymentValue = downPaymentInput;
            }

            double loanAmount = totalHousePrice - downPaymentValue;
            // 1. 年利率轉月利率，年限轉總月數
            double monthlyRate = (annualInterestRate / 100) / 12;
            int totalMonths = loanTermYears * 12;

            // 取得寬限期月數 (如果您防呆有抓到 gracePeriodYears)
            int graceMonths = gracePeriodYears * 12;
            int remainingMonths = totalMonths - graceMonths; // 扣掉寬限期後，真正要還本金的月數

            // 準備好變數
            double monthlyPayment = 0;
            double firstMonthInterest = loanAmount * monthlyRate; // 首期利息永遠是總金額 * 月利率
            double firstMonthPrincipal = 0;
            double totalRepayment = 0;
            double totalInterest = 0;

            // 判斷：是否有寬限期？
            if (graceMonths == 0)
            {
                // 【情況 A：沒有寬限期】(也就是您原本寫的邏輯)
                double tempPow = Math.Pow(1 + monthlyRate, totalMonths);
                monthlyPayment = loanAmount * (monthlyRate * tempPow) / (tempPow - 1);

                firstMonthPrincipal = monthlyPayment - firstMonthInterest;
                totalRepayment = monthlyPayment * totalMonths;
            }
            else
            {
                // 【情況 B：有寬限期】
                // 首期本金為 0 (因為前幾年只繳利息)，上面變數已經預設為 0 了

                // 寬限期滿後，剩下的本金要在 remainingMonths 內攤還
                double tempPow = Math.Pow(1 + monthlyRate, remainingMonths);
                monthlyPayment = loanAmount * (monthlyRate * tempPow) / (tempPow - 1);

                // 總還款金額 = (寬限期內每個月繳的利息 * 寬限期月數) + (寬限期滿後的每月應繳金額 * 剩餘月數)
                totalRepayment = (firstMonthInterest * graceMonths) + (monthlyPayment * remainingMonths);
            }

            // 總利息支出 = 總還款金額 - 貸款總額
            totalInterest = totalRepayment - loanAmount;

            // ==========================================
            // 區塊三：將結果顯示到畫面上 (含千分位與小數點)
            // ==========================================
            // .ToString("N2") 會自動加上千分位逗號，並精確到小數點後兩位 (完美符合作業要求！)
            txtTotalLoanAmount.Text = loanAmount.ToString("N2");
            txtMonthlyPayment.Text = monthlyPayment.ToString("N2");
            textFirstMonthInterest.Text = firstMonthInterest.ToString("N2");
            textFirstMonthPrincipal.Text = firstMonthPrincipal.ToString("N2");
            textTotalInterest.Text = totalInterest.ToString("N2");
            textTotalPayment.Text = totalRepayment.ToString("N2");
        }
    }
}
