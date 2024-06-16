
namespace TalesOfTheMagicSword
{
    partial class Store
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
            this.btn_Swordask = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Swordask
            // 
            this.btn_Swordask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Swordask.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Swordask.Location = new System.Drawing.Point(523, 739);
            this.btn_Swordask.Name = "btn_Swordask";
            this.btn_Swordask.Size = new System.Drawing.Size(419, 158);
            this.btn_Swordask.TabIndex = 0;
            this.btn_Swordask.Text = "Ask for sword";
            this.btn_Swordask.UseVisualStyleBackColor = false;
            this.btn_Swordask.Click += new System.EventHandler(this.btn_Swordask_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_exit.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(993, 825);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(419, 158);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Leave";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.chris_galloway_810b9966923871_5b27e4098f1c3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Swordask);
            this.Name = "Store";
            this.Text = "Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Swordask;
        private System.Windows.Forms.Button btn_exit;
    }
}