
namespace TalesOfTheMagicSword
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            this.btn_restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Black;
            this.btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restart.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_restart.Location = new System.Drawing.Point(671, 709);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(566, 222);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "Replay Game";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_restart);
            this.Name = "Win";
            this.Text = "Win";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_restart;
    }
}