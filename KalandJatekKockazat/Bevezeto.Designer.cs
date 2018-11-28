namespace KalandJatekKockazat
{
    partial class Bevezeto
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
            this.BevezetoPanel = new System.Windows.Forms.Panel();
            this.BevezetoBox = new System.Windows.Forms.TextBox();
            this.NextBev = new System.Windows.Forms.Button();
            this.MainMenuBev = new System.Windows.Forms.Button();
            this.BevezetoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BevezetoPanel
            // 
            this.BevezetoPanel.Controls.Add(this.BevezetoBox);
            this.BevezetoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BevezetoPanel.Location = new System.Drawing.Point(0, 0);
            this.BevezetoPanel.MaximumSize = new System.Drawing.Size(650, 560);
            this.BevezetoPanel.MinimumSize = new System.Drawing.Size(650, 560);
            this.BevezetoPanel.Name = "BevezetoPanel";
            this.BevezetoPanel.Size = new System.Drawing.Size(650, 560);
            this.BevezetoPanel.TabIndex = 0;
            // 
            // BevezetoBox
            // 
            this.BevezetoBox.BackColor = System.Drawing.Color.Firebrick;
            this.BevezetoBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BevezetoBox.Location = new System.Drawing.Point(25, 28);
            this.BevezetoBox.Multiline = true;
            this.BevezetoBox.Name = "BevezetoBox";
            this.BevezetoBox.ReadOnly = true;
            this.BevezetoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BevezetoBox.Size = new System.Drawing.Size(599, 521);
            this.BevezetoBox.TabIndex = 0;
            // 
            // NextBev
            // 
            this.NextBev.BackColor = System.Drawing.Color.Firebrick;
            this.NextBev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NextBev.Location = new System.Drawing.Point(668, 46);
            this.NextBev.Name = "NextBev";
            this.NextBev.Size = new System.Drawing.Size(95, 30);
            this.NextBev.TabIndex = 1;
            this.NextBev.Text = "Next";
            this.NextBev.UseVisualStyleBackColor = false;
            this.NextBev.Click += new System.EventHandler(this.NextBev_Click);
            // 
            // MainMenuBev
            // 
            this.MainMenuBev.BackColor = System.Drawing.Color.Firebrick;
            this.MainMenuBev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuBev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MainMenuBev.Location = new System.Drawing.Point(668, 519);
            this.MainMenuBev.Name = "MainMenuBev";
            this.MainMenuBev.Size = new System.Drawing.Size(104, 30);
            this.MainMenuBev.TabIndex = 3;
            this.MainMenuBev.Text = "Main Menu";
            this.MainMenuBev.UseVisualStyleBackColor = false;
            this.MainMenuBev.Click += new System.EventHandler(this.MainMenuBev_Click);
            // 
            // Bevezeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainMenuBev);
            this.Controls.Add(this.NextBev);
            this.Controls.Add(this.BevezetoPanel);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Bevezeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalandjáték Kockázat!";
            this.Load += new System.EventHandler(this.Bevezeto_Load);
            this.BevezetoPanel.ResumeLayout(false);
            this.BevezetoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BevezetoPanel;
        private System.Windows.Forms.Button NextBev;
        private System.Windows.Forms.Button MainMenuBev;
        private System.Windows.Forms.TextBox BevezetoBox;
    }
}