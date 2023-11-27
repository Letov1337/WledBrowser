namespace brows_esp
{
    partial class WledBrowser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WledBrowser));
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.switch_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorun_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorunOn_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorunOff_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBrowser
            // 
            this.panelBrowser.Location = new System.Drawing.Point(0, 0);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(703, 559);
            this.panelBrowser.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "wled";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switch_ToolStripMenuItem,
            this.autorun_ToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.закрытьПриложениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 92);
            // 
            // switch_ToolStripMenuItem
            // 
            this.switch_ToolStripMenuItem.Name = "switch_ToolStripMenuItem";
            this.switch_ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.switch_ToolStripMenuItem.Text = "Вкл/выкл подсветку";
            this.switch_ToolStripMenuItem.Click += new System.EventHandler(this.BacklightOnOff_ToolStripMenuItem_Click);
            // 
            // autorun_ToolStripMenuItem
            // 
            this.autorun_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorunOn_ToolStripMenuItem,
            this.autorunOff_ToolStripMenuItem});
            this.autorun_ToolStripMenuItem.Name = "autorun_ToolStripMenuItem";
            this.autorun_ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.autorun_ToolStripMenuItem.Text = "Автозагрузка";
            // 
            // autorunOn_ToolStripMenuItem
            // 
            this.autorunOn_ToolStripMenuItem.Name = "autorunOn_ToolStripMenuItem";
            this.autorunOn_ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.autorunOn_ToolStripMenuItem.Text = "Включить";
            this.autorunOn_ToolStripMenuItem.Click += new System.EventHandler(this.AutorunOn_ToolStripMenuItem_Click);
            // 
            // autorunOff_ToolStripMenuItem
            // 
            this.autorunOff_ToolStripMenuItem.Name = "autorunOff_ToolStripMenuItem";
            this.autorunOff_ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.autorunOff_ToolStripMenuItem.Text = "Выключить";
            this.autorunOff_ToolStripMenuItem.Click += new System.EventHandler(this.AutorunOff_ToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "10%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Brightness10_toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem3.Text = "50%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Brightness50_toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Brightness100_toolStripMenuItem4_Click);
            // 
            // закрытьПриложениеToolStripMenuItem
            // 
            this.закрытьПриложениеToolStripMenuItem.Name = "закрытьПриложениеToolStripMenuItem";
            this.закрытьПриложениеToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.закрытьПриложениеToolStripMenuItem.Text = "Закрыть приложение";
            this.закрытьПриложениеToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication_ToolStripMenuItem_Click);
            // 
            // WledBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 557);
            this.Controls.Add(this.panelBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WledBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wled Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WledBrowser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WledBrowser_FormClosed);
            this.Load += new System.EventHandler(this.WledBrowser_Load);
            this.Resize += new System.EventHandler(this.WledBrowser_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBrowser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem switch_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПриложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorun_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorunOn_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorunOff_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

