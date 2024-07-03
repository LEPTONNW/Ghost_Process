namespace Ghost_Process
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PRC_btn = new System.Windows.Forms.Button();
            this.prc_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prc_hide_btn = new System.Windows.Forms.Button();
            this.hide_prc_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prc_show_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Hide_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Show_text = new System.Windows.Forms.TextBox();
            this.prc_showall_btn = new System.Windows.Forms.Button();
            this.HotKey_Save_btn = new System.Windows.Forms.Button();
            this.Tray_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PRC_btn
            // 
            this.PRC_btn.Location = new System.Drawing.Point(26, 74);
            this.PRC_btn.Name = "PRC_btn";
            this.PRC_btn.Size = new System.Drawing.Size(742, 49);
            this.PRC_btn.TabIndex = 0;
            this.PRC_btn.Text = "프로세스탐색";
            this.PRC_btn.UseVisualStyleBackColor = true;
            this.PRC_btn.Click += new System.EventHandler(this.PRC_btn_Click);
            // 
            // prc_list
            // 
            this.prc_list.FormattingEnabled = true;
            this.prc_list.ItemHeight = 18;
            this.prc_list.Location = new System.Drawing.Point(26, 129);
            this.prc_list.Name = "prc_list";
            this.prc_list.Size = new System.Drawing.Size(742, 364);
            this.prc_list.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "현재 실행중인 모든 프로세스 수 :";
            // 
            // prc_hide_btn
            // 
            this.prc_hide_btn.Location = new System.Drawing.Point(26, 504);
            this.prc_hide_btn.Name = "prc_hide_btn";
            this.prc_hide_btn.Size = new System.Drawing.Size(742, 70);
            this.prc_hide_btn.TabIndex = 3;
            this.prc_hide_btn.Text = "선택된 프로세스숨김";
            this.prc_hide_btn.UseVisualStyleBackColor = true;
            this.prc_hide_btn.Click += new System.EventHandler(this.prc_hide_btn_Click);
            // 
            // hide_prc_list
            // 
            this.hide_prc_list.FormattingEnabled = true;
            this.hide_prc_list.ItemHeight = 18;
            this.hide_prc_list.Location = new System.Drawing.Point(26, 636);
            this.hide_prc_list.Name = "hide_prc_list";
            this.hide_prc_list.Size = new System.Drawing.Size(742, 364);
            this.hide_prc_list.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "프로세스 목록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "숨김 처리된 프로세스목록";
            // 
            // prc_show_btn
            // 
            this.prc_show_btn.Location = new System.Drawing.Point(26, 1023);
            this.prc_show_btn.Name = "prc_show_btn";
            this.prc_show_btn.Size = new System.Drawing.Size(344, 70);
            this.prc_show_btn.TabIndex = 7;
            this.prc_show_btn.Text = "선택된 프로세스보임";
            this.prc_show_btn.UseVisualStyleBackColor = true;
            this.prc_show_btn.Click += new System.EventHandler(this.prc_show_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "숨김단축키";
            // 
            // Hide_text
            // 
            this.Hide_text.Location = new System.Drawing.Point(804, 95);
            this.Hide_text.Name = "Hide_text";
            this.Hide_text.Size = new System.Drawing.Size(281, 28);
            this.Hide_text.TabIndex = 9;
            this.Hide_text.Enter += new System.EventHandler(this.Hide_text_Enter);
            this.Hide_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hide_text_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "보임단축키";
            // 
            // Show_text
            // 
            this.Show_text.Location = new System.Drawing.Point(804, 169);
            this.Show_text.Name = "Show_text";
            this.Show_text.Size = new System.Drawing.Size(281, 28);
            this.Show_text.TabIndex = 11;
            this.Show_text.Enter += new System.EventHandler(this.Show_text_Enter);
            this.Show_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Show_text_KeyDown);
            // 
            // prc_showall_btn
            // 
            this.prc_showall_btn.Location = new System.Drawing.Point(422, 1023);
            this.prc_showall_btn.Name = "prc_showall_btn";
            this.prc_showall_btn.Size = new System.Drawing.Size(346, 70);
            this.prc_showall_btn.TabIndex = 12;
            this.prc_showall_btn.Text = "숨겨진 프로세스 전체해제";
            this.prc_showall_btn.UseVisualStyleBackColor = true;
            this.prc_showall_btn.Click += new System.EventHandler(this.prc_showall_btn_Click);
            // 
            // HotKey_Save_btn
            // 
            this.HotKey_Save_btn.Location = new System.Drawing.Point(804, 229);
            this.HotKey_Save_btn.Name = "HotKey_Save_btn";
            this.HotKey_Save_btn.Size = new System.Drawing.Size(281, 63);
            this.HotKey_Save_btn.TabIndex = 13;
            this.HotKey_Save_btn.Text = "단축키 저장";
            this.HotKey_Save_btn.UseVisualStyleBackColor = true;
            this.HotKey_Save_btn.Click += new System.EventHandler(this.HotKey_Save_btn_Click);
            // 
            // Tray_btn
            // 
            this.Tray_btn.Location = new System.Drawing.Point(804, 1023);
            this.Tray_btn.Name = "Tray_btn";
            this.Tray_btn.Size = new System.Drawing.Size(281, 70);
            this.Tray_btn.TabIndex = 14;
            this.Tray_btn.Text = "트레이로 최소화";
            this.Tray_btn.UseVisualStyleBackColor = true;
            this.Tray_btn.Click += new System.EventHandler(this.Tray_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(121, 36);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1130, 1120);
            this.Controls.Add(this.Tray_btn);
            this.Controls.Add(this.HotKey_Save_btn);
            this.Controls.Add(this.prc_showall_btn);
            this.Controls.Add(this.Show_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hide_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prc_show_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hide_prc_list);
            this.Controls.Add(this.prc_hide_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prc_list);
            this.Controls.Add(this.PRC_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ghost_Process v1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PRC_btn;
        private System.Windows.Forms.ListBox prc_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prc_hide_btn;
        private System.Windows.Forms.ListBox hide_prc_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prc_show_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Hide_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Show_text;
        private System.Windows.Forms.Button prc_showall_btn;
        private System.Windows.Forms.Button HotKey_Save_btn;
        private System.Windows.Forms.Button Tray_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

