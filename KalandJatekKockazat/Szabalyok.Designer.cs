namespace KalandJatekKockazat
{
    partial class Szabalyok
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
            this.Next = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
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
            this.SzabalyPanel.TabIndex = 0;
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
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Firebrick;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Next.Location = new System.Drawing.Point(668, 46);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(95, 30);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.Firebrick;
            this.BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToMenu.Font = new System.Drawing.Font("Papyrus", 12F);
            this.BackToMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackToMenu.Location = new System.Drawing.Point(668, 94);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(95, 30);
            this.BackToMenu.TabIndex = 2;
            this.BackToMenu.Text = "Previous";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Firebrick;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.Font = new System.Drawing.Font("Papyrus", 12F);
            this.Quit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Quit.Location = new System.Drawing.Point(668, 514);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(104, 30);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Main Menu";
            this.Quit.UseVisualStyleBackColor = false;
            // 
            // Szabalyok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.SzabalyPanel);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Szabalyok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalandjáték Kockázat!";
            this.SzabalyPanel.ResumeLayout(false);
            this.SzabalyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SzabalyPanel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.TextBox SzabalyText;
    }
}