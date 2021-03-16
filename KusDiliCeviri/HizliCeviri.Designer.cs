
namespace KusDiliCeviri
{
    partial class HizliCeviri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizliCeviri));
            this.cevrilen = new System.Windows.Forms.RichTextBox();
            this.YapistirMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.ceviri = new System.Windows.Forms.RichTextBox();
            this.CevirMod_harf = new System.Windows.Forms.ComboBox();
            this.CevirMod = new System.Windows.Forms.ComboBox();
            this.cevir = new System.Windows.Forms.Button();
            this.kopya = new System.Windows.Forms.Button();
            this.YapistirMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cevrilen
            // 
            this.cevrilen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cevrilen.ContextMenuStrip = this.YapistirMenu;
            resources.ApplyResources(this.cevrilen, "cevrilen");
            this.cevrilen.Name = "cevrilen";
            // 
            // YapistirMenu
            // 
            this.YapistirMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yapistir});
            this.YapistirMenu.Name = "YapistirMenu";
            resources.ApplyResources(this.YapistirMenu, "YapistirMenu");
            // 
            // yapistir
            // 
            this.yapistir.Image = global::KusDiliCeviri.Properties.Resources.pastereal;
            this.yapistir.Name = "yapistir";
            resources.ApplyResources(this.yapistir, "yapistir");
            this.yapistir.Click += new System.EventHandler(this.yapistir_Click);
            // 
            // ceviri
            // 
            this.ceviri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ceviri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.ceviri, "ceviri");
            this.ceviri.Name = "ceviri";
            this.ceviri.ReadOnly = true;
            // 
            // CevirMod_harf
            // 
            this.CevirMod_harf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod_harf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CevirMod_harf, "CevirMod_harf");
            this.CevirMod_harf.FormattingEnabled = true;
            this.CevirMod_harf.Items.AddRange(new object[] {
            resources.GetString("CevirMod_harf.Items"),
            resources.GetString("CevirMod_harf.Items1"),
            resources.GetString("CevirMod_harf.Items2"),
            resources.GetString("CevirMod_harf.Items3"),
            resources.GetString("CevirMod_harf.Items4")});
            this.CevirMod_harf.Name = "CevirMod_harf";
            // 
            // CevirMod
            // 
            this.CevirMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CevirMod, "CevirMod");
            this.CevirMod.FormattingEnabled = true;
            this.CevirMod.Items.AddRange(new object[] {
            resources.GetString("CevirMod.Items"),
            resources.GetString("CevirMod.Items1")});
            this.CevirMod.Name = "CevirMod";
            // 
            // cevir
            // 
            this.cevir.BackColor = System.Drawing.Color.PaleGreen;
            this.cevir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cevir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.cevir, "cevir");
            this.cevir.Name = "cevir";
            this.cevir.UseVisualStyleBackColor = false;
            this.cevir.Click += new System.EventHandler(this.cevir_Click);
            // 
            // kopya
            // 
            this.kopya.BackColor = System.Drawing.Color.PaleGreen;
            this.kopya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kopya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.kopya, "kopya");
            this.kopya.Name = "kopya";
            this.kopya.UseVisualStyleBackColor = false;
            this.kopya.Click += new System.EventHandler(this.kopya_Click);
            // 
            // HizliCeviri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.kopya);
            this.Controls.Add(this.cevir);
            this.Controls.Add(this.CevirMod_harf);
            this.Controls.Add(this.CevirMod);
            this.Controls.Add(this.ceviri);
            this.Controls.Add(this.cevrilen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HizliCeviri";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HizliCeviri_Load);
            this.YapistirMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cevrilen;
        private System.Windows.Forms.RichTextBox ceviri;
        private System.Windows.Forms.ComboBox CevirMod_harf;
        private System.Windows.Forms.ComboBox CevirMod;
        private System.Windows.Forms.Button cevir;
        private System.Windows.Forms.Button kopya;
        private System.Windows.Forms.ContextMenuStrip YapistirMenu;
        private System.Windows.Forms.ToolStripMenuItem yapistir;
    }
}