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
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_TransferToAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_SendCoin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_hex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_transactionId = new System.Windows.Forms.TextBox();
            this.Txt_fee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Txt_amount);
            this.groupBox4.Controls.Add(this.Txt_Password);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Txt_TransferToAddress);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Btn_Transfer);
            this.groupBox4.Location = new System.Drawing.Point(12, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 176);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "amount";
            // 
            // Txt_amount
            // 
            this.Txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_amount.Location = new System.Drawing.Point(138, 32);
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.Size = new System.Drawing.Size(314, 27);
            this.Txt_amount.TabIndex = 2;
            this.Txt_amount.Text = "100";
            // 
            // Txt_Password
            // 
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Password.Location = new System.Drawing.Point(138, 99);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(314, 27);
            this.Txt_Password.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // Txt_TransferToAddress
            // 
            this.Txt_TransferToAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TransferToAddress.Location = new System.Drawing.Point(138, 66);
            this.Txt_TransferToAddress.Name = "Txt_TransferToAddress";
            this.Txt_TransferToAddress.Size = new System.Drawing.Size(314, 27);
            this.Txt_TransferToAddress.TabIndex = 2;
            this.Txt_TransferToAddress.Text = "SYsB8dTuvXkgwaAQpTWqdryBANSx6TvLpC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "To Address";
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.Location = new System.Drawing.Point(138, 132);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(94, 29);
            this.Btn_Transfer.TabIndex = 0;
            this.Btn_Transfer.Text = "Transfer";
            this.Btn_Transfer.UseVisualStyleBackColor = true;
            this.Btn_Transfer.Click += new System.EventHandler(this.Btn_Transfer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.Txt_hex);
            this.groupBox5.Controls.Add(this.Txt_fee);
            this.groupBox5.Controls.Add(this.Btn_SendCoin);
            this.groupBox5.Controls.Add(this.Txt_transactionId);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 454);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(473, 198);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send Coin";
            // 
            // Btn_SendCoin
            // 
            this.Btn_SendCoin.Location = new System.Drawing.Point(138, 130);
            this.Btn_SendCoin.Name = "Btn_SendCoin";
            this.Btn_SendCoin.Size = new System.Drawing.Size(94, 29);
            this.Btn_SendCoin.TabIndex = 0;
            this.Btn_SendCoin.Text = "Send Coin";
            this.Btn_SendCoin.UseVisualStyleBackColor = true;
            this.Btn_SendCoin.Click += new System.EventHandler(this.Btn_SendCoin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "hex";
            // 
            // Txt_hex
            // 
            this.Txt_hex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_hex.Location = new System.Drawing.Point(138, 64);
            this.Txt_hex.Name = "Txt_hex";
            this.Txt_hex.Size = new System.Drawing.Size(314, 27);
            this.Txt_hex.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "transactionId";
            // 
            // Txt_transactionId
            // 
            this.Txt_transactionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_transactionId.Location = new System.Drawing.Point(138, 97);
            this.Txt_transactionId.Name = "Txt_transactionId";
            this.Txt_transactionId.Size = new System.Drawing.Size(314, 27);
            this.Txt_transactionId.TabIndex = 2;
            // 
            // Txt_fee
            // 
            this.Txt_fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_fee.Location = new System.Drawing.Point(138, 31);
            this.Txt_fee.Name = "Txt_fee";
            this.Txt_fee.Size = new System.Drawing.Size(314, 27);
            this.Txt_fee.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "fee";
            // 
            // FrmSeniorBlockchain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 693);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private Label label5;
        private TextBox Txt_amount;
        private TextBox Txt_Password;
        private Label label6;
        private GroupBox groupBox5;
        private TextBox Txt_hex;
        private Button Btn_SendCoin;
        private TextBox Txt_transactionId;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Txt_fee;
    }
}