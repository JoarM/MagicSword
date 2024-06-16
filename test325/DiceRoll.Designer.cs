
namespace test325
{
    partial class DiceRoll
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
            this.txtB_u = new System.Windows.Forms.TextBox();
            this.btn_fight = new System.Windows.Forms.Button();
            this.txtB_enemy = new System.Windows.Forms.TextBox();
            this.lbl_win = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_u
            // 
            this.txtB_u.Location = new System.Drawing.Point(192, 81);
            this.txtB_u.Multiline = true;
            this.txtB_u.Name = "txtB_u";
            this.txtB_u.Size = new System.Drawing.Size(462, 548);
            this.txtB_u.TabIndex = 0;
            // 
            // btn_fight
            // 
            this.btn_fight.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fight.Location = new System.Drawing.Point(192, 688);
            this.btn_fight.Name = "btn_fight";
            this.btn_fight.Size = new System.Drawing.Size(462, 89);
            this.btn_fight.TabIndex = 1;
            this.btn_fight.Text = "Fight";
            this.btn_fight.UseVisualStyleBackColor = true;
            this.btn_fight.Click += new System.EventHandler(this.btn_fight_Click);
            // 
            // txtB_enemy
            // 
            this.txtB_enemy.Location = new System.Drawing.Point(717, 81);
            this.txtB_enemy.Multiline = true;
            this.txtB_enemy.Name = "txtB_enemy";
            this.txtB_enemy.Size = new System.Drawing.Size(517, 548);
            this.txtB_enemy.TabIndex = 2;
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Location = new System.Drawing.Point(192, 636);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(0, 20);
            this.lbl_win.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_back.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(22, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 82);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(1287, 24);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(54, 20);
            this.lbl_balance.TabIndex = 5;
            this.lbl_balance.Text = "Money";
            // 
            // DiceRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.medievaltableengland;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.txtB_enemy);
            this.Controls.Add(this.btn_fight);
            this.Controls.Add(this.txtB_u);
            this.Name = "DiceRoll";
            this.Text = "DiceRoll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_u;
        private System.Windows.Forms.Button btn_fight;
        private System.Windows.Forms.TextBox txtB_enemy;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_balance;
    }
}