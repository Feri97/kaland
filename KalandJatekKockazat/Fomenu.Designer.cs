namespace KalandJatekKockazat
{
    partial class Fomenu
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
            this.FomenuKep = new System.Windows.Forms.Panel();
            this.StartGame = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FomenuKep
            // 
            this.FomenuKep.BackColor = System.Drawing.Color.Black;
            this.FomenuKep.BackgroundImage = global::KalandJatekKockazat.Properties.Resources.FomenuKepVegleges;
            this.FomenuKep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FomenuKep.Location = new System.Drawing.Point(0, 0);
            this.FomenuKep.MaximumSize = new System.Drawing.Size(650, 560);
            this.FomenuKep.MinimumSize = new System.Drawing.Size(650, 560);
            this.FomenuKep.Name = "FomenuKep";
            this.FomenuKep.Size = new System.Drawing.Size(650, 560);
            this.FomenuKep.TabIndex = 0;
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Firebrick;
            this.StartGame.FlatAppearance.BorderSize = 0;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartGame.Location = new System.Drawing.Point(668, 46);
            this.StartGame.Margin = new System.Windows.Forms.Padding(0);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(95, 30);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Firebrick;
            this.Continue.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Continue.FlatAppearance.BorderSize = 0;
            this.Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Continue.Location = new System.Drawing.Point(668, 98);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(95, 30);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Firebrick;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.Font = new System.Drawing.Font("Papyrus", 12F);
            this.Quit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Quit.Location = new System.Drawing.Point(678, 514);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 35);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Fomenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.FomenuKep);
            this.Font = new System.Drawing.Font("Papyrus", 12F);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalandjáték Kockázat!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FomenuKep;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Quit;
    }
}

