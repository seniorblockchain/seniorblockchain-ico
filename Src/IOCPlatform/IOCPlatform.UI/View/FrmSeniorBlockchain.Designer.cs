namespace ICOPlatform.UI.View
{
    partial class FrmSeniorBlockchain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Account = new System.Windows.Forms.TextBox();
            this.Txt_MyWallet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Getbalance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_getAddressBalance = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_TransferToAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Account);
            this.groupBox1.Controls.Add(this.Txt_MyWallet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Getbalance);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallet";
            // 
            // Txt_Account
            // 
            this.Txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Account.Location = new System.Drawing.Point(138, 59);
            this.Txt_Account.Name = "Txt_Account";
            this.Txt_Account.Size = new System.Drawing.Size(314, 27);
            this.Txt_Account.TabIndex = 2;
            this.Txt_Account.Text = "account 0";
            // 
            // Txt_MyWallet
            // 
            this.Txt_MyWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_MyWallet.Location = new System.Drawing.Point(138, 24);
            this.Txt_MyWallet.Name = "Txt_MyWallet";
            this.Txt_MyWallet.Size = new System.Drawing.Size(314, 27);
            this.Txt_MyWallet.TabIndex = 2;
            this.Txt_MyWallet.Text = "MyWallet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "WalletName";
            // 
            // Btn_Getbalance
            // 
            this.Btn_Getbalance.Location = new System.Drawing.Point(138, 97);
            this.Btn_Getbalance.Name = "Btn_Getbalance";
            this.Btn_Getbalance.Size = new System.Drawing.Size(94, 29);
            this.Btn_Getbalance.TabIndex = 0;
            this.Btn_Getbalance.Text = "get balance";
            this.Btn_Getbalance.UseVisualStyleBackColor = true;
            this.Btn_Getbalance.Click += new System.EventHandler(this.Btn_Getbalance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_log);
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // txt_log
            // 
            this.txt_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(3, 23);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_log.Size = new System.Drawing.Size(455, 461);
            this.txt_log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_Address);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Btn_getAddressBalance);
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "address balance";
            // 
            // Txt_Address
            // 
            this.Txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Address.Location = new System.Drawing.Point(138, 30);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(314, 27);
            this.Txt_Address.TabIndex = 2;
            this.Txt_Address.Text = "SYsB8dTuvXkgwaAQpTWqdryBANSx6TvLpC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // Btn_getAddressBalance
            // 
            this.Btn_getAddressBalance.Location = new System.Drawing.Point(138, 63);
            this.Btn_getAddressBalance.Name = "Btn_getAddressBalance";
            this.Btn_getAddressBalance.Size = new System.Drawing.Size(94, 29);
            this.Btn_getAddressBalance.TabIndex = 0;
            this.Btn_getAddressBalance.Text = "get balance";
            this.Btn_getAddressBalance.UseVisualStyleBackColor = true;
            this.Btn_getAddressBalance.Click += new System.EventHandler(this.Btn_getAddressBalance_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Txt_TransferToAddress);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Btn_Transfer);
            this.groupBox4.Location = new System.Drawing.Point(12, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 227);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer";
            // 
            // Txt_TransferToAddress
            // 
            this.Txt_TransferToAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TransferToAddress.Location = new System.Drawing.Point(138, 122);
            this.Txt_TransferToAddress.Name = "Txt_TransferToAddress";
            this.Txt_TransferToAddress.Size = new System.Drawing.Size(314, 27);
            this.Txt_TransferToAddress.TabIndex = 2;
            this.Txt_TransferToAddress.Text = "SYsB8dTuvXkgwaAQpTWqdryBANSx6TvLpC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "To Address";
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.Location = new System.Drawing.Point(138, 155);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(94, 29);
            this.Btn_Transfer.TabIndex = 0;
            this.Btn_Transfer.Text = "Transfer";
            this.Btn_Transfer.UseVisualStyleBackColor = true;
            this.Btn_Transfer.Click += new System.EventHandler(this.Btn_getAddressBalance_Click);
            // 
            // FrmSeniorBlockchain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSeniorBlockchain";
            this.Text = "FrmSeniorBlockchain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Txt_Account;
        private TextBox Txt_MyWallet;
        private Label label2;
        private Label label1;
        private Button Btn_Getbalance;
        private GroupBox groupBox2;
        private TextBox txt_log;
        private GroupBox groupBox3;
        private TextBox Txt_Address;
        private Label label3;
        private Button Btn_getAddressBalance;
        private GroupBox groupBox4;
        private TextBox Txt_TransferToAddress;
        private Label label4;
        private Button Btn_Transfer;
    }
}