namespace IPC
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
            this.Btn_Generat = new System.Windows.Forms.Button();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Token_ERC20 = new System.Windows.Forms.RadioButton();
            this.Token_TRC20 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_LiveLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Generat);
            this.groupBox1.Controls.Add(this.Txt_Total);
            this.groupBox1.Controls.Add(this.Token_ERC20);
            this.groupBox1.Controls.Add(this.Token_TRC20);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Generator";
            // 
            // Btn_Generat
            // 
            this.Btn_Generat.Location = new System.Drawing.Point(131, 140);
            this.Btn_Generat.Name = "Btn_Generat";
            this.Btn_Generat.Size = new System.Drawing.Size(172, 29);
            this.Btn_Generat.TabIndex = 3;
            this.Btn_Generat.Text = "Generat";
            this.Btn_Generat.UseVisualStyleBackColor = true;
            this.Btn_Generat.Click += new System.EventHandler(this.Btn_Generat_Click);
            // 
            // Txt_Total
            // 
            this.Txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Total.Location = new System.Drawing.Point(131, 98);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(172, 27);
            this.Txt_Total.TabIndex = 2;
            this.Txt_Total.Text = "1000";
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Token_ERC20
            // 
            this.Token_ERC20.AutoSize = true;
            this.Token_ERC20.Location = new System.Drawing.Point(140, 68);
            this.Token_ERC20.Name = "Token_ERC20";
            this.Token_ERC20.Size = new System.Drawing.Size(117, 24);
            this.Token_ERC20.TabIndex = 1;
            this.Token_ERC20.TabStop = true;
            this.Token_ERC20.Text = "Token_ERC20";
            this.Token_ERC20.UseVisualStyleBackColor = true;
            // 
            // Token_TRC20
            // 
            this.Token_TRC20.AutoSize = true;
            this.Token_TRC20.Location = new System.Drawing.Point(140, 38);
            this.Token_TRC20.Name = "Token_TRC20";
            this.Token_TRC20.Size = new System.Drawing.Size(117, 24);
            this.Token_TRC20.TabIndex = 1;
            this.Token_TRC20.TabStop = true;
            this.Token_TRC20.Text = "Token_TRC20";
            this.Token_TRC20.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_LiveLog);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Log";
            // 
            // Txt_LiveLog
            // 
            this.Txt_LiveLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_LiveLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_LiveLog.Location = new System.Drawing.Point(3, 23);
            this.Txt_LiveLog.Multiline = true;
            this.Txt_LiveLog.Name = "Txt_LiveLog";
            this.Txt_LiveLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_LiveLog.Size = new System.Drawing.Size(320, 157);
            this.Txt_LiveLog.TabIndex = 0;
            // 
            // FrmAdressGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 203);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdressGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Generator";
            this.Load += new System.EventHandler(this.FrmAdressGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Txt_LiveLog;
        private Label label1;
        private RadioButton Token_TRC20;
        private RadioButton Token_ERC20;
        private TextBox Txt_Total;
        private Label label2;
        private Button Btn_Generat;
    }
}