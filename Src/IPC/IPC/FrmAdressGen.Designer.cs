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
            this.Btn_Generat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Token_TRC20 = new System.Windows.Forms.RadioButton();
            this.Token_ERC20 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_LiveLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Generat
            // 
            this.Btn_Generat.Location = new System.Drawing.Point(130, 145);
            this.Btn_Generat.Name = "Btn_Generat";
            this.Btn_Generat.Size = new System.Drawing.Size(108, 23);
            this.Btn_Generat.TabIndex = 0;
            this.Btn_Generat.Text = "Generat";
            this.Btn_Generat.UseVisualStyleBackColor = true;
            this.Btn_Generat.Click += new System.EventHandler(this.Btn_Generat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Btn_Generat);
            this.groupBox1.Controls.Add(this.Token_ERC20);
            this.groupBox1.Controls.Add(this.Token_TRC20);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token";
            // 
            // Token_TRC20
            // 
            this.Token_TRC20.AutoSize = true;
            this.Token_TRC20.Location = new System.Drawing.Point(130, 39);
            this.Token_TRC20.Name = "Token_TRC20";
            this.Token_TRC20.Size = new System.Drawing.Size(108, 20);
            this.Token_TRC20.TabIndex = 1;
            this.Token_TRC20.TabStop = true;
            this.Token_TRC20.Text = "Token_TRC20";
            this.Token_TRC20.UseVisualStyleBackColor = true;
            // 
            // Token_ERC20
            // 
            this.Token_ERC20.AutoSize = true;
            this.Token_ERC20.Location = new System.Drawing.Point(130, 65);
            this.Token_ERC20.Name = "Token_ERC20";
            this.Token_ERC20.Size = new System.Drawing.Size(107, 20);
            this.Token_ERC20.TabIndex = 1;
            this.Token_ERC20.TabStop = true;
            this.Token_ERC20.Text = "Token_ERC20";
            this.Token_ERC20.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(130, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Txt_LiveLog);
            this.groupBox2.Location = new System.Drawing.Point(276, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Log";
            // 
            // Txt_LiveLog
            // 
            this.Txt_LiveLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_LiveLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_LiveLog.Location = new System.Drawing.Point(3, 19);
            this.Txt_LiveLog.Multiline = true;
            this.Txt_LiveLog.Name = "Txt_LiveLog";
            this.Txt_LiveLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_LiveLog.Size = new System.Drawing.Size(365, 181);
            this.Txt_LiveLog.TabIndex = 0;
            // 
            // FrmAdressGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdressGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Generat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Token_ERC20;
        private System.Windows.Forms.RadioButton Token_TRC20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_LiveLog;
    }
}