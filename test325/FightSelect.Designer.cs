
namespace TalesOfTheMagicSword
{
    partial class FightSelect
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
            this.btn_dragon = new System.Windows.Forms.Button();
            this.btn_Gnomes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dragon
            // 
            this.btn_dragon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_dragon.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dragon.Location = new System.Drawing.Point(348, 565);
            this.btn_dragon.Name = "btn_dragon";
            this.btn_dragon.Size = new System.Drawing.Size(333, 164);
            this.btn_dragon.TabIndex = 0;
            this.btn_dragon.Text = "Fight Dragon";
            this.btn_dragon.UseVisualStyleBackColor = false;
            this.btn_dragon.Click += new System.EventHandler(this.btn_dragon_Click);
            // 
            // btn_Gnomes
            // 
            this.btn_Gnomes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Gnomes.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gnomes.Location = new System.Drawing.Point(1326, 656);
            this.btn_Gnomes.Name = "btn_Gnomes";
            this.btn_Gnomes.Size = new System.Drawing.Size(165, 104);
            this.btn_Gnomes.TabIndex = 1;
            this.btn_Gnomes.Text = "Fight More Gnomes";
            this.btn_Gnomes.UseVisualStyleBackColor = false;
            this.btn_Gnomes.Click += new System.EventHandler(this.btn_Gnomes_Click);
            // 
            // FightSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.Screen_Shot_2014_10_13_at_12_11_02_700x466;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_Gnomes);
            this.Controls.Add(this.btn_dragon);
            this.Name = "FightSelect";
            this.Text = "FightSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dragon;
        private System.Windows.Forms.Button btn_Gnomes;
    }
}