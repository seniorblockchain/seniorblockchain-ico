namespace IOCPlatform
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_AddressGen = new System.Windows.Forms.ToolStripMenuItem();
            this.tRC20ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRC20ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Sync_Time = new System.Windows.Forms.Label();
            this.lbl_Sync_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Sync_Stop = new System.Windows.Forms.Button();
            this.Btn_Sync_Start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel1.Text = "System Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.Btn_AddressGen,
            this.tRC20ManagerToolStripMenuItem,
            this.eRC20ManagerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 6);
            // 
            // Btn_AddressGen
            // 
            this.Btn_AddressGen.Name = "Btn_AddressGen";
            this.Btn_AddressGen.Size = new System.Drawing.Size(223, 26);
            this.Btn_AddressGen.Text = "Address Generateor";
            this.Btn_AddressGen.Click += new System.EventHandler(this.Btn_AddressGen_Click);
            // 
            // tRC20ManagerToolStripMenuItem
            // 
            this.tRC20ManagerToolStripMenuItem.Name = "tRC20ManagerToolStripMenuItem";
            this.tRC20ManagerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.tRC20ManagerToolStripMenuItem.Text = "TRC20 Manager";
            // 
            // eRC20ManagerToolStripMenuItem
            // 
            this.eRC20ManagerToolStripMenuItem.Name = "eRC20ManagerToolStripMenuItem";
            this.eRC20ManagerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.eRC20ManagerToolStripMenuItem.Text = "ERC20 Manager";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
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
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Sync_Time);
            this.groupBox1.Controls.Add(this.lbl_Sync_Status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Sync_Stop);
            this.groupBox1.Controls.Add(this.Btn_Sync_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRC20-ERC20 Sync";
            // 
            // lbl_Sync_Time
            // 
            this.lbl_Sync_Time.AutoSize = true;
            this.lbl_Sync_Time.Location = new System.Drawing.Point(297, 32);
            this.lbl_Sync_Time.Name = "lbl_Sync_Time";
            this.lbl_Sync_Time.Size = new System.Drawing.Size(15, 20);
            this.lbl_Sync_Time.TabIndex = 1;
            this.lbl_Sync_Time.Text = "-";
            // 
            // lbl_Sync_Status
            // 
            this.lbl_Sync_Status.AutoSize = true;
            this.lbl_Sync_Status.Location = new System.Drawing.Point(129, 32);
            this.lbl_Sync_Status.Name = "lbl_Sync_Status";
            this.lbl_Sync_Status.Size = new System.Drawing.Size(54, 20);
            this.lbl_Sync_Status.TabIndex = 1;
            this.lbl_Sync_Status.Text = "Ready!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status :";
            // 
            // Btn_Sync_Stop
            // 
            this.Btn_Sync_Stop.Location = new System.Drawing.Point(254, 73);
            this.Btn_Sync_Stop.Name = "Btn_Sync_Stop";
            this.Btn_Sync_Stop.Size = new System.Drawing.Size(119, 29);
            this.Btn_Sync_Stop.TabIndex = 0;
            this.Btn_Sync_Stop.Text = "Stop";
            this.Btn_Sync_Stop.UseVisualStyleBackColor = true;
            // 
            // Btn_Sync_Start
            // 
            this.Btn_Sync_Start.Location = new System.Drawing.Point(129, 73);
            this.Btn_Sync_Start.Name = "Btn_Sync_Start";
            this.Btn_Sync_Start.Size = new System.Drawing.Size(119, 29);
            this.Btn_Sync_Start.TabIndex = 0;
            this.Btn_Sync_Start.Text = "Start";
            this.Btn_Sync_Start.UseVisualStyleBackColor = true;
            this.Btn_Sync_Start.Click += new System.EventHandler(this.Btn_Sync_Start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Txt_Log);
            this.groupBox2.Location = new System.Drawing.Point(489, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Log";
            // 
            // Txt_Log
            // 
            this.Txt_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Log.Location = new System.Drawing.Point(3, 23);
            this.Txt_Log.Multiline = true;
            this.Txt_Log.Name = "Txt_Log";
            this.Txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_Log.Size = new System.Drawing.Size(381, 207);
            this.Txt_Log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Sync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ready!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem Btn_AddressGen;
        private ToolStripMenuItem tRC20ManagerToolStripMenuItem;
        private ToolStripMenuItem eRC20ManagerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox groupBox1;
        private Label lbl_Sync_Time;
        private Label lbl_Sync_Status;
        private Label label1;
        private Button Btn_Sync_Start;
        private Button Btn_Sync_Stop;
        private GroupBox groupBox2;
        private TextBox Txt_Log;
        private GroupBox groupBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button4;
    }
}