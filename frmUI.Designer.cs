namespace AutoScreenshot
{
    partial class frmUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUI));
            this.ntfSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.sagTikMenusu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekranGoruntusuAl = new System.Windows.Forms.ToolStripMenuItem();
            this.Cik = new System.Windows.Forms.ToolStripMenuItem();
            this.sagTikMenusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfSystemTray
            // 
            this.ntfSystemTray.ContextMenuStrip = this.sagTikMenusu;
            this.ntfSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfSystemTray.Icon")));
            this.ntfSystemTray.Text = "Print Screen Saver";
            this.ntfSystemTray.Visible = true;
            // 
            // sagTikMenusu
            // 
            this.sagTikMenusu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranGoruntusuAl,
            this.Cik});
            this.sagTikMenusu.Name = "contextMenuStrip1";
            this.sagTikMenusu.Size = new System.Drawing.Size(177, 48);
            this.sagTikMenusu.Text = "Ekran Görüntüsü";
            // 
            // ekranGoruntusuAl
            // 
            this.ekranGoruntusuAl.Name = "ekranGoruntusuAl";
            this.ekranGoruntusuAl.Size = new System.Drawing.Size(176, 22);
            this.ekranGoruntusuAl.Text = "Ekran Görüntüsü Al";
            // 
            // Cik
            // 
            this.Cik.Name = "Cik";
            this.Cik.Size = new System.Drawing.Size(176, 22);
            this.Cik.Text = "Çık";
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(11, 10);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUI";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "time";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.sagTikMenusu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfSystemTray;
        private System.Windows.Forms.ContextMenuStrip sagTikMenusu;
        private System.Windows.Forms.ToolStripMenuItem ekranGoruntusuAl;
        private System.Windows.Forms.ToolStripMenuItem Cik;

    }
}

