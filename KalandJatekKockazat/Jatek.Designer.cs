namespace KalandJatekKockazat
{
    partial class Jatek
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
            this.JatekPanel = new System.Windows.Forms.Panel();
            this.JatekText = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HealthGameBox = new System.Windows.Forms.TextBox();
            this.JatekPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JatekPanel
            // 
            this.JatekPanel.Controls.Add(this.JatekText);
            this.JatekPanel.Location = new System.Drawing.Point(0, 0);
            this.JatekPanel.MaximumSize = new System.Drawing.Size(650, 560);
            this.JatekPanel.MinimumSize = new System.Drawing.Size(650, 560);
            this.JatekPanel.Name = "JatekPanel";
            this.JatekPanel.Size = new System.Drawing.Size(650, 560);
            this.JatekPanel.TabIndex = 0;
            // 
            // JatekText
            // 
            this.JatekText.BackColor = System.Drawing.Color.Firebrick;
            this.JatekText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JatekText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.JatekText.Location = new System.Drawing.Point(12, 13);
            this.JatekText.Multiline = true;
            this.JatekText.Name = "JatekText";
            this.JatekText.Size = new System.Drawing.Size(625, 395);
            this.JatekText.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Firebrick;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenu.Location = new System.Drawing.Point(668, 519);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(104, 30);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(668, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inventory";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(668, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rules";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Firebrick;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(656, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Health:";
            // 
            // HealthGameBox
            // 
            this.HealthGameBox.BackColor = System.Drawing.Color.Firebrick;
            this.HealthGameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HealthGameBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HealthGameBox.Location = new System.Drawing.Point(735, 63);
            this.HealthGameBox.Name = "HealthGameBox";
            this.HealthGameBox.Size = new System.Drawing.Size(37, 26);
            this.HealthGameBox.TabIndex = 5;
            this.HealthGameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.HealthGameBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.JatekPanel);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Jatek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalandjáték Kockázat!";
            this.JatekPanel.ResumeLayout(false);
            this.JatekPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel JatekPanel;
        private System.Windows.Forms.TextBox JatekText;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox HealthGameBox;
    }
}