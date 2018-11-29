namespace KalandJatekKockazat
{
    partial class Fight
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
            this.InventoryExit = new System.Windows.Forms.Button();
            this.FightPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.FightHS = new System.Windows.Forms.TextBox();
            this.FightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryExit
            // 
            this.InventoryExit.BackColor = System.Drawing.Color.Firebrick;
            this.InventoryExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InventoryExit.Location = new System.Drawing.Point(678, 508);
            this.InventoryExit.Name = "InventoryExit";
            this.InventoryExit.Size = new System.Drawing.Size(78, 41);
            this.InventoryExit.TabIndex = 4;
            this.InventoryExit.Text = "Exit";
            this.InventoryExit.UseVisualStyleBackColor = false;
            // 
            // FightPanel
            // 
            this.FightPanel.Controls.Add(this.FightHS);
            this.FightPanel.Location = new System.Drawing.Point(0, 0);
            this.FightPanel.MaximumSize = new System.Drawing.Size(650, 560);
            this.FightPanel.MinimumSize = new System.Drawing.Size(650, 560);
            this.FightPanel.Name = "FightPanel";
            this.FightPanel.Size = new System.Drawing.Size(650, 560);
            this.FightPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FightHS
            // 
            this.FightHS.BackColor = System.Drawing.Color.Firebrick;
            this.FightHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FightHS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FightHS.Location = new System.Drawing.Point(18, 19);
            this.FightHS.Name = "FightHS";
            this.FightHS.Size = new System.Drawing.Size(145, 26);
            this.FightHS.TabIndex = 0;
            this.FightHS.Text = "Health:";
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FightPanel);
            this.Controls.Add(this.InventoryExit);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harcolj!";
            this.FightPanel.ResumeLayout(false);
            this.FightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InventoryExit;
        private System.Windows.Forms.Panel FightPanel;
        private System.Windows.Forms.TextBox FightHS;
        private System.Windows.Forms.Button button1;
    }
}