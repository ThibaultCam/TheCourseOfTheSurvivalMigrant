namespace TheCurseOfTheSurvivalMigrant.GUI
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.quitterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(431, 253);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(239, 67);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // quitterButton
            // 
            this.quitterButton.Location = new System.Drawing.Point(431, 398);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(239, 67);
            this.quitterButton.TabIndex = 1;
            this.quitterButton.Text = "Quitter";
            this.quitterButton.UseVisualStyleBackColor = true;
            this.quitterButton.Click += new System.EventHandler(this.quitterButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.startButton);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1080, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button quitterButton;
    }
}
