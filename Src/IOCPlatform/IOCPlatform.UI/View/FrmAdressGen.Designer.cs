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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Total_Address = new System.Windows.Forms.NumericUpDown();
            this.Btn_Generat = new System.Windows.Forms.Button();
            this.Token_ERC20 = new System.Windows.Forms.RadioButton();
            this.Token_TRC20 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Usdt_Type = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_LiveLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_total = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_current = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress_gen = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Address)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Generator";
            // 
            // Total_Address
            // 
            this.Total_Address.Location = new System.Drawing.Point(179, 81);
            this.Total_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Address.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Total_Address.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Total_Address.Name = "Total_Address";
            this.Total_Address.Size = new System.Drawing.Size(262, 27);
            this.Total_Address.TabIndex = 2;
            this.Total_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Address.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Btn_Generat
            // 
            this.Btn_Generat.Location = new System.Drawing.Point(179, 120);
            this.Btn_Generat.Name = "Btn_Generat";
            this.Btn_Generat.Size = new System.Drawing.Size(262, 34);
            this.Btn_Generat.TabIndex = 3;
            this.Btn_Generat.Text = "Generat";
            this.Btn_Generat.UseVisualStyleBackColor = true;
            this.Btn_Generat.Click += new System.EventHandler(this.Btn_Generat_Click);
            // 
            // Token_ERC20
            // 
            this.Token_ERC20.AutoSize = true;
            this.Token_ERC20.Location = new System.Drawing.Point(334, 37);
            this.Token_ERC20.Name = "Token_ERC20";
            this.Token_ERC20.Size = new System.Drawing.Size(120, 24);
            this.Token_ERC20.TabIndex = 1;
            this.Token_ERC20.TabStop = true;
            this.Token_ERC20.Text = "USDT_ERC-20";
            this.Token_ERC20.UseVisualStyleBackColor = true;
            // 
            // Token_TRC20
            // 
            this.Token_TRC20.AutoSize = true;
            this.Token_TRC20.Location = new System.Drawing.Point(179, 37);
            this.Token_TRC20.Name = "Token_TRC20";
            this.Token_TRC20.Size = new System.Drawing.Size(118, 24);
            this.Token_TRC20.TabIndex = 1;
            this.Token_TRC20.TabStop = true;
            this.Token_TRC20.Text = "USDT TRC-20";
            this.Token_TRC20.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Address";
            // 
            // label_Usdt_Type
            // 
            this.label_Usdt_Type.AutoSize = true;
            this.label_Usdt_Type.Location = new System.Drawing.Point(18, 39);
            this.label_Usdt_Type.Name = "label_Usdt_Type";
            this.label_Usdt_Type.Size = new System.Drawing.Size(149, 20);
            this.label_Usdt_Type.TabIndex = 0;
            this.label_Usdt_Type.Text = "Select USDT Network";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.Txt_LiveLog);
            this.groupBox2.Location = new System.Drawing.Point(11, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 209);
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
            this.Txt_LiveLog.Size = new System.Drawing.Size(479, 183);
            this.Txt_LiveLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_total,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lbl_current,
            this.toolStripStatusLabel4,
            this.progress_gen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Total :";
            // 
            // lbl_total
            // 
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(17, 20);
            this.lbl_total.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(64, 20);
            this.toolStripStatusLabel3.Text = "Current :";
            // 
            // lbl_current
            // 
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(17, 20);
            this.lbl_current.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // progress_gen
            // 
            this.progress_gen.Name = "progress_gen";
            this.progress_gen.Size = new System.Drawing.Size(150, 18);
            // 
            // FrmAdressGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdressGen";
            this.Text = "Address Generator";
            this.Load += new System.EventHandler(this.FrmAdressGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Address)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbl_total;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lbl_current;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripProgressBar progress_gen;
    }
}