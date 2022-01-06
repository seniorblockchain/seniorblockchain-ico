namespace IPC
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.adressGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_LiveLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_USDT_Eng_Status = new System.Windows.Forms.Label();
            this.lbl_USDT_Eng_Time = new System.Windows.Forms.Label();
            this.Btn_USDT_Eng_Start = new System.Windows.Forms.Button();
            this.Btn_USDT_Eng_Stop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fleToolStripMenuItem
            // 
            this.fleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.adressGeneratorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fleToolStripMenuItem.Name = "fleToolStripMenuItem";
            this.fleToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.fleToolStripMenuItem.Text = "Fle";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // adressGeneratorToolStripMenuItem
            // 
            this.adressGeneratorToolStripMenuItem.Name = "adressGeneratorToolStripMenuItem";
            this.adressGeneratorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adressGeneratorToolStripMenuItem.Text = "Adress Generator";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About Application";
         
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_USDT_Eng_Stop);
            this.groupBox1.Controls.Add(this.Btn_USDT_Eng_Start);
            this.groupBox1.Controls.Add(this.lbl_USDT_Eng_Status);
            this.groupBox1.Controls.Add(this.lbl_USDT_Eng_Time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USDT Engine";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Txt_LiveLog);
            this.groupBox2.Location = new System.Drawing.Point(526, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 371);
            this.groupBox2.TabIndex = 2;
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
            this.Txt_LiveLog.Size = new System.Drawing.Size(361, 349);
            this.Txt_LiveLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status :";
            // 
            // lbl_USDT_Eng_Status
            // 
            this.lbl_USDT_Eng_Status.AutoSize = true;
            this.lbl_USDT_Eng_Status.Location = new System.Drawing.Point(89, 35);
            this.lbl_USDT_Eng_Status.Name = "lbl_USDT_Eng_Status";
            this.lbl_USDT_Eng_Status.Size = new System.Drawing.Size(12, 16);
            this.lbl_USDT_Eng_Status.TabIndex = 0;
            this.lbl_USDT_Eng_Status.Text = "-";
            // 
            // lbl_USDT_Eng_Time
            // 
            this.lbl_USDT_Eng_Time.AutoSize = true;
            this.lbl_USDT_Eng_Time.Location = new System.Drawing.Point(210, 35);
            this.lbl_USDT_Eng_Time.Name = "lbl_USDT_Eng_Time";
            this.lbl_USDT_Eng_Time.Size = new System.Drawing.Size(40, 16);
            this.lbl_USDT_Eng_Time.TabIndex = 0;
            this.lbl_USDT_Eng_Time.Text = "00:00";
            // 
            // Btn_USDT_Eng_Start
            // 
            this.Btn_USDT_Eng_Start.Location = new System.Drawing.Point(21, 78);
            this.Btn_USDT_Eng_Start.Name = "Btn_USDT_Eng_Start";
            this.Btn_USDT_Eng_Start.Size = new System.Drawing.Size(134, 23);
            this.Btn_USDT_Eng_Start.TabIndex = 1;
            this.Btn_USDT_Eng_Start.Text = "Start";
            this.Btn_USDT_Eng_Start.UseVisualStyleBackColor = true;
            // 
            // Btn_USDT_Eng_Stop
            // 
            this.Btn_USDT_Eng_Stop.Location = new System.Drawing.Point(161, 78);
            this.Btn_USDT_Eng_Stop.Name = "Btn_USDT_Eng_Stop";
            this.Btn_USDT_Eng_Stop.Size = new System.Drawing.Size(134, 23);
            this.Btn_USDT_Eng_Stop.TabIndex = 1;
            this.Btn_USDT_Eng_Stop.Text = "Stop";
            this.Btn_USDT_Eng_Stop.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICO Platform Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adressGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_LiveLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_USDT_Eng_Status;
        private System.Windows.Forms.Label lbl_USDT_Eng_Time;
        private System.Windows.Forms.Button Btn_USDT_Eng_Stop;
        private System.Windows.Forms.Button Btn_USDT_Eng_Start;
    }
}