
namespace TalesOfTheMagicSword
{
    partial class DragonFight
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtB_out = new System.Windows.Forms.TextBox();
            this.btn_Fight = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.prgrs_playerHealth = new System.Windows.Forms.ProgressBar();
            this.prgs_Dragon = new System.Windows.Forms.ProgressBar();
            this.lbl_drgnhp = new System.Windows.Forms.Label();
            this.lbl_playerhp = new System.Windows.Forms.Label();
            this.btn_potion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(1771, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 112);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtB_out
            // 
            this.txtB_out.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB_out.Location = new System.Drawing.Point(492, 738);
            this.txtB_out.Multiline = true;
            this.txtB_out.Name = "txtB_out";
            this.txtB_out.ReadOnly = true;
            this.txtB_out.Size = new System.Drawing.Size(867, 129);
            this.txtB_out.TabIndex = 12;
            this.txtB_out.Text = "U choose to fight the mighty fire dragon. The Dragon breathes towards u ur slow o" +
    "n youre feat and get hit by the fire.";
            // 
            // btn_Fight
            // 
            this.btn_Fight.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Fight.Location = new System.Drawing.Point(492, 873);
            this.btn_Fight.Name = "btn_Fight";
            this.btn_Fight.Size = new System.Drawing.Size(427, 148);
            this.btn_Fight.TabIndex = 13;
            this.btn_Fight.Text = "Strike back and fight";
            this.btn_Fight.UseVisualStyleBackColor = true;
            this.btn_Fight.Click += new System.EventHandler(this.btn_Fight_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Run.Location = new System.Drawing.Point(939, 873);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(420, 148);
            this.btn_Run.TabIndex = 14;
            this.btn_Run.Text = "Give up and run back to safety";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // prgrs_playerHealth
            // 
            this.prgrs_playerHealth.Location = new System.Drawing.Point(492, 691);
            this.prgrs_playerHealth.Name = "prgrs_playerHealth";
            this.prgrs_playerHealth.Size = new System.Drawing.Size(867, 41);
            this.prgrs_playerHealth.Step = 1;
            this.prgrs_playerHealth.TabIndex = 15;
            this.prgrs_playerHealth.Value = 100;
            // 
            // prgs_Dragon
            // 
            this.prgs_Dragon.Location = new System.Drawing.Point(526, 248);
            this.prgs_Dragon.Maximum = 250;
            this.prgs_Dragon.Name = "prgs_Dragon";
            this.prgs_Dragon.Size = new System.Drawing.Size(867, 41);
            this.prgs_Dragon.Step = 1;
            this.prgs_Dragon.TabIndex = 16;
            this.prgs_Dragon.Value = 250;
            // 
            // lbl_drgnhp
            // 
            this.lbl_drgnhp.AutoSize = true;
            this.lbl_drgnhp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_drgnhp.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_drgnhp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_drgnhp.Location = new System.Drawing.Point(851, 292);
            this.lbl_drgnhp.Name = "lbl_drgnhp";
            this.lbl_drgnhp.Size = new System.Drawing.Size(198, 39);
            this.lbl_drgnhp.TabIndex = 17;
            this.lbl_drgnhp.Text = "Dragon HP";
            // 
            // lbl_playerhp
            // 
            this.lbl_playerhp.AutoSize = true;
            this.lbl_playerhp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerhp.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerhp.ForeColor = System.Drawing.Color.White;
            this.lbl_playerhp.Location = new System.Drawing.Point(851, 648);
            this.lbl_playerhp.Name = "lbl_playerhp";
            this.lbl_playerhp.Size = new System.Drawing.Size(63, 39);
            this.lbl_playerhp.TabIndex = 18;
            this.lbl_playerhp.Text = "HP";
            // 
            // btn_potion
            // 
            this.btn_potion.Location = new System.Drawing.Point(851, 560);
            this.btn_potion.Name = "btn_potion";
            this.btn_potion.Size = new System.Drawing.Size(159, 85);
            this.btn_potion.TabIndex = 19;
            this.btn_potion.Text = "Potions: 1";
            this.btn_potion.UseVisualStyleBackColor = true;
            this.btn_potion.Click += new System.EventHandler(this.btn_potion_Click);
            // 
            // DragonFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::test325.Properties.Resources.Dragen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_potion);
            this.Controls.Add(this.lbl_playerhp);
            this.Controls.Add(this.lbl_drgnhp);
            this.Controls.Add(this.prgs_Dragon);
            this.Controls.Add(this.prgrs_playerHealth);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Fight);
            this.Controls.Add(this.txtB_out);
            this.Controls.Add(this.btn_exit);
            this.Name = "DragonFight";
            this.Text = "DragonFight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtB_out;
        private System.Windows.Forms.Button btn_Fight;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.ProgressBar prgrs_playerHealth;
        private System.Windows.Forms.ProgressBar prgs_Dragon;
        private System.Windows.Forms.Label lbl_drgnhp;
        private System.Windows.Forms.Label lbl_playerhp;
        private System.Windows.Forms.Button btn_potion;
    }
}