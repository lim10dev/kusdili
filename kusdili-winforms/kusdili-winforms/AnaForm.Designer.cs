namespace kusdili_winforms
{
    partial class AnaForm
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
            çevrilenTextBox = new TextBox();
            çevirButton = new Button();
            sonuçTextBox = new TextBox();
            çeviriModuComboBox = new ComboBox();
            harfComboBox = new ComboBox();
            SuspendLayout();
            // 
            // çevrilenTextBox
            // 
            çevrilenTextBox.Location = new Point(12, 12);
            çevrilenTextBox.Multiline = true;
            çevrilenTextBox.Name = "çevrilenTextBox";
            çevrilenTextBox.PlaceholderText = "Çevrilen...";
            çevrilenTextBox.Size = new Size(776, 115);
            çevrilenTextBox.TabIndex = 0;
            // 
            // çevirButton
            // 
            çevirButton.Location = new Point(12, 133);
            çevirButton.Name = "çevirButton";
            çevirButton.Size = new Size(99, 40);
            çevirButton.TabIndex = 1;
            çevirButton.Text = "Çevir";
            çevirButton.UseVisualStyleBackColor = true;
            çevirButton.Click += çevirButton_Click;
            // 
            // sonuçTextBox
            // 
            sonuçTextBox.Location = new Point(12, 179);
            sonuçTextBox.Multiline = true;
            sonuçTextBox.Name = "sonuçTextBox";
            sonuçTextBox.PlaceholderText = "Sonuç...";
            sonuçTextBox.ReadOnly = true;
            sonuçTextBox.Size = new Size(776, 115);
            sonuçTextBox.TabIndex = 2;
            // 
            // çeviriModuComboBox
            // 
            çeviriModuComboBox.FormattingEnabled = true;
            çeviriModuComboBox.Items.AddRange(new object[] { "Türkçe'den Kuş Diline", "Kuş Dilinden Türkçe'ye" });
            çeviriModuComboBox.Location = new Point(117, 143);
            çeviriModuComboBox.Name = "çeviriModuComboBox";
            çeviriModuComboBox.Size = new Size(176, 23);
            çeviriModuComboBox.TabIndex = 3;
            // 
            // harfComboBox
            // 
            harfComboBox.FormattingEnabled = true;
            harfComboBox.Items.AddRange(new object[] { "g", "c", "b", "lf" });
            harfComboBox.Location = new Point(299, 143);
            harfComboBox.Name = "harfComboBox";
            harfComboBox.Size = new Size(74, 23);
            harfComboBox.TabIndex = 4;
            harfComboBox.Text = "g";
            // 
            // AnaForm
            // 
            AcceptButton = çevirButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(harfComboBox);
            Controls.Add(çeviriModuComboBox);
            Controls.Add(sonuçTextBox);
            Controls.Add(çevirButton);
            Controls.Add(çevrilenTextBox);
            Name = "AnaForm";
            Text = "AnaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox çevrilenTextBox;
        private Button çevirButton;
        private TextBox sonuçTextBox;
        private ComboBox çeviriModuComboBox;
        private ComboBox harfComboBox;
    }
}