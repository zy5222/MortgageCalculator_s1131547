namespace 個人房貸試算器
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TotalHousePrice = new System.Windows.Forms.Label();
            this.AnnualInterestRate = new System.Windows.Forms.Label();
            this.LoanTerm = new System.Windows.Forms.Label();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.DownPayment = new System.Windows.Forms.Label();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GracePeriod = new System.Windows.Forms.Label();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.TotalLoanAmount = new System.Windows.Forms.Label();
            this.MonthlyPayment = new System.Windows.Forms.Label();
            this.FirstMonthInterest = new System.Windows.Forms.Label();
            this.FirstMonthPrincipal = new System.Windows.Forms.Label();
            this.TotalInterest = new System.Windows.Forms.Label();
            this.TotalPayment = new System.Windows.Forms.Label();
            this.txtTotalLoanAmount = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.textFirstMonthInterest = new System.Windows.Forms.TextBox();
            this.textFirstMonthPrincipal = new System.Windows.Forms.TextBox();
            this.textTotalInterest = new System.Windows.Forms.TextBox();
            this.textTotalPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalHousePrice
            // 
            this.TotalHousePrice.AutoSize = true;
            this.TotalHousePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalHousePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalHousePrice.Location = new System.Drawing.Point(41, 90);
            this.TotalHousePrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalHousePrice.Name = "TotalHousePrice";
            this.TotalHousePrice.Size = new System.Drawing.Size(276, 25);
            this.TotalHousePrice.TabIndex = 0;
            this.TotalHousePrice.Text = "房屋總價(Total House Price)";
            // 
            // AnnualInterestRate
            // 
            this.AnnualInterestRate.AutoSize = true;
            this.AnnualInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AnnualInterestRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AnnualInterestRate.Location = new System.Drawing.Point(41, 254);
            this.AnnualInterestRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AnnualInterestRate.Name = "AnnualInterestRate";
            this.AnnualInterestRate.Size = new System.Drawing.Size(303, 25);
            this.AnnualInterestRate.TabIndex = 1;
            this.AnnualInterestRate.Text = "貸款利率(Annual Interest Rate)";
            // 
            // LoanTerm
            // 
            this.LoanTerm.AutoSize = true;
            this.LoanTerm.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoanTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoanTerm.Location = new System.Drawing.Point(41, 322);
            this.LoanTerm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoanTerm.Name = "LoanTerm";
            this.LoanTerm.Size = new System.Drawing.Size(208, 25);
            this.LoanTerm.TabIndex = 2;
            this.LoanTerm.Text = "貸款年限(Loan Term)";
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHousePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHousePrice.Location = new System.Drawing.Point(366, 88);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(203, 30);
            this.txtHousePrice.TabIndex = 3;
            this.txtHousePrice.Text = "0";
            this.txtHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDownPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(367, 170);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(203, 30);
            this.txtDownPayment.TabIndex = 4;
            this.txtDownPayment.Text = "0";
            this.txtDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoanTerm.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanTerm.Location = new System.Drawing.Point(367, 316);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(203, 30);
            this.txtLoanTerm.TabIndex = 5;
            this.txtLoanTerm.Text = "0";
            this.txtLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DownPayment
            // 
            this.DownPayment.AutoSize = true;
            this.DownPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DownPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DownPayment.Location = new System.Drawing.Point(41, 150);
            this.DownPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.Size = new System.Drawing.Size(239, 25);
            this.DownPayment.TabIndex = 6;
            this.DownPayment.Text = "自備款(Down Payment) ";
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPercent.Location = new System.Drawing.Point(73, 189);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(67, 27);
            this.rbPercent.TabIndex = 7;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "比例";
            this.rbPercent.UseVisualStyleBackColor = true;
            this.rbPercent.CheckedChanged += new System.EventHandler(this.rbPercent_CheckedChanged);
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAmount.Location = new System.Drawing.Point(176, 189);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(67, 27);
            this.rbAmount.TabIndex = 8;
            this.rbAmount.TabStop = true;
            this.rbAmount.Text = "金額";
            this.rbAmount.UseVisualStyleBackColor = true;
            this.rbAmount.CheckedChanged += new System.EventHandler(this.rbAmount_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(574, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "元 (NT$)";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnit2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUnit2.Location = new System.Drawing.Point(574, 254);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(26, 23);
            this.lblUnit2.TabIndex = 12;
            this.lblUnit2.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(573, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "年";
            // 
            // GracePeriod
            // 
            this.GracePeriod.AutoSize = true;
            this.GracePeriod.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GracePeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GracePeriod.Location = new System.Drawing.Point(41, 388);
            this.GracePeriod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GracePeriod.Name = "GracePeriod";
            this.GracePeriod.Size = new System.Drawing.Size(260, 25);
            this.GracePeriod.TabIndex = 14;
            this.GracePeriod.Text = "寬限期(Grace Period, 選填)";
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGracePeriod.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGracePeriod.Location = new System.Drawing.Point(367, 382);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(203, 30);
            this.txtGracePeriod.TabIndex = 15;
            this.txtGracePeriod.Text = "0";
            this.txtGracePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(573, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "年";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalculate.Location = new System.Drawing.Point(367, 453);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 61);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(473, 453);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 61);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TotalLoanAmount
            // 
            this.TotalLoanAmount.AutoSize = true;
            this.TotalLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalLoanAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalLoanAmount.Location = new System.Drawing.Point(687, 92);
            this.TotalLoanAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalLoanAmount.Name = "TotalLoanAmount";
            this.TotalLoanAmount.Size = new System.Drawing.Size(112, 25);
            this.TotalLoanAmount.TabIndex = 19;
            this.TotalLoanAmount.Text = "貸款總金額";
            // 
            // MonthlyPayment
            // 
            this.MonthlyPayment.AutoSize = true;
            this.MonthlyPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MonthlyPayment.Location = new System.Drawing.Point(687, 154);
            this.MonthlyPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MonthlyPayment.Name = "MonthlyPayment";
            this.MonthlyPayment.Size = new System.Drawing.Size(132, 25);
            this.MonthlyPayment.TabIndex = 20;
            this.MonthlyPayment.Text = "每月應繳金額";
            // 
            // FirstMonthInterest
            // 
            this.FirstMonthInterest.AutoSize = true;
            this.FirstMonthInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstMonthInterest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstMonthInterest.Location = new System.Drawing.Point(687, 212);
            this.FirstMonthInterest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstMonthInterest.Name = "FirstMonthInterest";
            this.FirstMonthInterest.Size = new System.Drawing.Size(92, 25);
            this.FirstMonthInterest.TabIndex = 21;
            this.FirstMonthInterest.Text = "首期利息";
            // 
            // FirstMonthPrincipal
            // 
            this.FirstMonthPrincipal.AutoSize = true;
            this.FirstMonthPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstMonthPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstMonthPrincipal.Location = new System.Drawing.Point(687, 268);
            this.FirstMonthPrincipal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstMonthPrincipal.Name = "FirstMonthPrincipal";
            this.FirstMonthPrincipal.Size = new System.Drawing.Size(92, 25);
            this.FirstMonthPrincipal.TabIndex = 22;
            this.FirstMonthPrincipal.Text = "首期本金";
            // 
            // TotalInterest
            // 
            this.TotalInterest.AutoSize = true;
            this.TotalInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalInterest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalInterest.Location = new System.Drawing.Point(687, 328);
            this.TotalInterest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalInterest.Name = "TotalInterest";
            this.TotalInterest.Size = new System.Drawing.Size(112, 25);
            this.TotalInterest.TabIndex = 23;
            this.TotalInterest.Text = "總利息支出";
            // 
            // TotalPayment
            // 
            this.TotalPayment.AutoSize = true;
            this.TotalPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalPayment.Location = new System.Drawing.Point(687, 385);
            this.TotalPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Size = new System.Drawing.Size(112, 25);
            this.TotalPayment.TabIndex = 24;
            this.TotalPayment.Text = "總還款金額";
            // 
            // txtTotalLoanAmount
            // 
            this.txtTotalLoanAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotalLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalLoanAmount.Location = new System.Drawing.Point(841, 86);
            this.txtTotalLoanAmount.Name = "txtTotalLoanAmount";
            this.txtTotalLoanAmount.ReadOnly = true;
            this.txtTotalLoanAmount.Size = new System.Drawing.Size(203, 30);
            this.txtTotalLoanAmount.TabIndex = 25;
            this.txtTotalLoanAmount.Text = "0";
            this.txtTotalLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMonthlyPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonthlyPayment.Location = new System.Drawing.Point(841, 150);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(203, 30);
            this.txtMonthlyPayment.TabIndex = 26;
            this.txtMonthlyPayment.Text = "0";
            this.txtMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textFirstMonthInterest
            // 
            this.textFirstMonthInterest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textFirstMonthInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFirstMonthInterest.Location = new System.Drawing.Point(841, 207);
            this.textFirstMonthInterest.Name = "textFirstMonthInterest";
            this.textFirstMonthInterest.ReadOnly = true;
            this.textFirstMonthInterest.Size = new System.Drawing.Size(203, 30);
            this.textFirstMonthInterest.TabIndex = 27;
            this.textFirstMonthInterest.Text = "0";
            this.textFirstMonthInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textFirstMonthPrincipal
            // 
            this.textFirstMonthPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textFirstMonthPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFirstMonthPrincipal.Location = new System.Drawing.Point(841, 265);
            this.textFirstMonthPrincipal.Name = "textFirstMonthPrincipal";
            this.textFirstMonthPrincipal.ReadOnly = true;
            this.textFirstMonthPrincipal.Size = new System.Drawing.Size(203, 30);
            this.textFirstMonthPrincipal.TabIndex = 28;
            this.textFirstMonthPrincipal.Text = "0";
            this.textFirstMonthPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTotalInterest
            // 
            this.textTotalInterest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textTotalInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textTotalInterest.Location = new System.Drawing.Point(841, 325);
            this.textTotalInterest.Name = "textTotalInterest";
            this.textTotalInterest.ReadOnly = true;
            this.textTotalInterest.Size = new System.Drawing.Size(203, 30);
            this.textTotalInterest.TabIndex = 29;
            this.textTotalInterest.Text = "0";
            this.textTotalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTotalPayment
            // 
            this.textTotalPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textTotalPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textTotalPayment.Location = new System.Drawing.Point(841, 380);
            this.textTotalPayment.Name = "textTotalPayment";
            this.textTotalPayment.ReadOnly = true;
            this.textTotalPayment.Size = new System.Drawing.Size(203, 30);
            this.textTotalPayment.TabIndex = 30;
            this.textTotalPayment.Text = "0";
            this.textTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(1051, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "元 (NT$)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1051, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "元 (NT$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(1050, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "元 (NT$)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(1050, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "元 (NT$)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(1051, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "元 (NT$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(1050, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "元 (NT$)";
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Input.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Input.Location = new System.Drawing.Point(41, 26);
            this.Input.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(136, 38);
            this.Input.TabIndex = 37;
            this.Input.Text = "輸入資訊:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Output.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Output.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Output.Location = new System.Drawing.Point(688, 26);
            this.Output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(136, 38);
            this.Output.TabIndex = 38;
            this.Output.Text = "結果輸出:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(366, 249);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(203, 30);
            this.txtInterestRate.TabIndex = 39;
            this.txtInterestRate.Text = "0";
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnit1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUnit1.Location = new System.Drawing.Point(575, 175);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(26, 23);
            this.lblUnit1.TabIndex = 40;
            this.lblUnit1.Text = "%";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label.Location = new System.Drawing.Point(692, 468);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(505, 46);
            this.label.TabIndex = 41;
            this.label.Text = "備註：本試算器預設採用「本息平均攤還法」計算。\r\n若填寫寬限期，該期間僅繳納利息，期滿後將剩餘本金平均攤還。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1198, 572);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTotalPayment);
            this.Controls.Add(this.textTotalInterest);
            this.Controls.Add(this.textFirstMonthPrincipal);
            this.Controls.Add(this.textFirstMonthInterest);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtTotalLoanAmount);
            this.Controls.Add(this.TotalPayment);
            this.Controls.Add(this.TotalInterest);
            this.Controls.Add(this.FirstMonthPrincipal);
            this.Controls.Add(this.FirstMonthInterest);
            this.Controls.Add(this.MonthlyPayment);
            this.Controls.Add(this.TotalLoanAmount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.GracePeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAmount);
            this.Controls.Add(this.rbPercent);
            this.Controls.Add(this.DownPayment);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtHousePrice);
            this.Controls.Add(this.LoanTerm);
            this.Controls.Add(this.AnnualInterestRate);
            this.Controls.Add(this.TotalHousePrice);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "個人房貸試算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalHousePrice;
        private System.Windows.Forms.Label AnnualInterestRate;
        private System.Windows.Forms.Label LoanTerm;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.Label DownPayment;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GracePeriod;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label TotalLoanAmount;
        private System.Windows.Forms.Label MonthlyPayment;
        private System.Windows.Forms.Label FirstMonthInterest;
        private System.Windows.Forms.Label FirstMonthPrincipal;
        private System.Windows.Forms.Label TotalInterest;
        private System.Windows.Forms.Label TotalPayment;
        private System.Windows.Forms.TextBox txtTotalLoanAmount;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox textFirstMonthInterest;
        private System.Windows.Forms.TextBox textFirstMonthPrincipal;
        private System.Windows.Forms.TextBox textTotalInterest;
        private System.Windows.Forms.TextBox textTotalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label label;
    }
}

