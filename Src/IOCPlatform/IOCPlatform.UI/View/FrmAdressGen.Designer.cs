namespace IOCPlatform
{
    partial class FrmAdressGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdressGen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Total_Address = new System.Windows.Forms.NumericUpDown();
            this.Btn_Generat = new System.Windows.Forms.Button();
            this.Token_ERC20 = new System.Windows.Forms.RadioButton();
            this.Token_TRC20 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Usdt_Type = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_LiveLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Address)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Total_Address);
            this.groupBox1.Controls.Add(this.Btn_Generat);
            this.groupBox1.Controls.Add(this.Token_ERC20);
            this.groupBox1.Controls.Add(this.Token_TRC20);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Usdt_Type);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(424, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Generator";
            // 
            // Total_Address
            // 
            this.Total_Address.Location = new System.Drawing.Point(157, 69);
            this.Total_Address.Name = "Total_Address";
            this.Total_Address.Size = new System.Drawing.Size(229, 23);
            this.Total_Address.TabIndex = 2;
            // 
            // Btn_Generat
            // 
            this.Btn_Generat.Location = new System.Drawing.Point(157, 111);
            this.Btn_Generat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Generat.Name = "Btn_Generat";
            this.Btn_Generat.Size = new System.Drawing.Size(229, 32);
            this.Btn_Generat.TabIndex = 3;
            this.Btn_Generat.Text = "Generat";
            this.Btn_Generat.UseVisualStyleBackColor = true;
            this.Btn_Generat.Click += new System.EventHandler(this.Btn_Generat_Click);
            // 
            // Token_ERC20
            // 
            this.Token_ERC20.AutoSize = true;
            this.Token_ERC20.Location = new System.Drawing.Point(292, 28);
            this.Token_ERC20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Token_ERC20.Name = "Token_ERC20";
            this.Token_ERC20.Size = new System.Drawing.Size(95, 19);
            this.Token_ERC20.TabIndex = 1;
            this.Token_ERC20.TabStop = true;
            this.Token_ERC20.Text = "USDT_ERC-20";
            this.Token_ERC20.UseVisualStyleBackColor = true;
            // 
            // Token_TRC20
            // 
            this.Token_TRC20.AutoSize = true;
            this.Token_TRC20.Location = new System.Drawing.Point(157, 28);
            this.Token_TRC20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Token_TRC20.Name = "Token_TRC20";
            this.Token_TRC20.Size = new System.Drawing.Size(93, 19);
            this.Token_TRC20.TabIndex = 1;
            this.Token_TRC20.TabStop = true;
            this.Token_TRC20.Text = "USDT TRC-20";
            this.Token_TRC20.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Address";
            // 
            // label_Usdt_Type
            // 
            this.label_Usdt_Type.AutoSize = true;
            this.label_Usdt_Type.Location = new System.Drawing.Point(16, 29);
            this.label_Usdt_Type.Name = "label_Usdt_Type";
            this.label_Usdt_Type.Size = new System.Drawing.Size(116, 15);
            this.label_Usdt_Type.TabIndex = 0;
            this.label_Usdt_Type.Text = "Select USDT Network";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_LiveLog);
            this.groupBox2.Location = new System.Drawing.Point(10, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(424, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Log";
            // 
            // Txt_LiveLog
            // 
            this.Txt_LiveLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_LiveLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_LiveLog.Location = new System.Drawing.Point(3, 18);
            this.Txt_LiveLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_LiveLog.Multiline = true;
            this.Txt_LiveLog.Name = "Txt_LiveLog";
            this.Txt_LiveLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_LiveLog.Size = new System.Drawing.Size(418, 137);
            this.Txt_LiveLog.TabIndex = 0;
            // 
            // FrmAdressGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdressGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Generator";
            this.Load += new System.EventHandler(this.FrmAdressGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Address)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Txt_LiveLog;
        private Label label_Usdt_Type;
        private RadioButton Token_TRC20;
        private RadioButton Token_ERC20;
        private Label label2;
        private Button Btn_Generat;
        private NumericUpDown Total_Address;
    }
}