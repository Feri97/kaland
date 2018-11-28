namespace KalandJatekKockazat
{
    partial class GameRulesToBut
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
            this.SzabalyPanel = new System.Windows.Forms.Panel();
            this.SzabalyText = new System.Windows.Forms.TextBox();
            this.Quit = new System.Windows.Forms.Button();
            this.SzabalyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SzabalyPanel
            // 
            this.SzabalyPanel.Controls.Add(this.SzabalyText);
            this.SzabalyPanel.Location = new System.Drawing.Point(0, 0);
            this.SzabalyPanel.MaximumSize = new System.Drawing.Size(650, 560);
            this.SzabalyPanel.MinimumSize = new System.Drawing.Size(650, 560);
            this.SzabalyPanel.Name = "SzabalyPanel";
            this.SzabalyPanel.Size = new System.Drawing.Size(650, 560);
            this.SzabalyPanel.TabIndex = 1;
            // 
            // SzabalyText
            // 
            this.SzabalyText.BackColor = System.Drawing.Color.Firebrick;
            this.SzabalyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SzabalyText.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SzabalyText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SzabalyText.Location = new System.Drawing.Point(12, 12);
            this.SzabalyText.Multiline = true;
            this.SzabalyText.Name = "SzabalyText";
            this.SzabalyText.ReadOnly = true;
            this.SzabalyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SzabalyText.Size = new System.Drawing.Size(623, 537);
            this.SzabalyText.TabIndex = 0;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Firebrick;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.Font = new System.Drawing.Font("Papyrus", 12F);
            this.Quit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Quit.Location = new System.Drawing.Point(668, 519);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(104, 30);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GameRulesToBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.SzabalyPanel);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GameRulesToBut";
            this.Text = "Rules";
            this.SzabalyPanel.ResumeLayout(false);
            this.SzabalyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SzabalyPanel;
        private System.Windows.Forms.TextBox SzabalyText;
        private System.Windows.Forms.Button Quit;
    }
}