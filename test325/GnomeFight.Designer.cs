
namespace TalesOfTheMagicSword
{
    partial class GnomeFight
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
            this.gnome2_health = new System.Windows.Forms.ProgressBar();
            this.gnome1_health = new System.Windows.Forms.ProgressBar();
            this.gnome3_health = new System.Windows.Forms.ProgressBar();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.btn_potions = new System.Windows.Forms.Button();
            this.btn_gnome1 = new System.Windows.Forms.Button();
            this.btn_gnome3 = new System.Windows.Forms.Button();
            this.btn_gnome2 = new System.Windows.Forms.Button();
            this.pictureBoxGnome2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxgnome3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxgnome1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGnome2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgnome3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgnome1)).BeginInit();
            this.SuspendLayout();
            // 
            // gnome2_health
            // 
            this.gnome2_health.Location = new System.Drawing.Point(503, 930);
            this.gnome2_health.Maximum = 30;
            this.gnome2_health.Name = "gnome2_health";
            this.gnome2_health.Size = new System.Drawing.Size(184, 29);
            this.gnome2_health.Step = 1;
            this.gnome2_health.TabIndex = 3;
            this.gnome2_health.Value = 30;
            // 
            // gnome1_health
            // 
            this.gnome1_health.Location = new System.Drawing.Point(1284, 930);
            this.gnome1_health.Maximum = 30;
            this.gnome1_health.Name = "gnome1_health";
            this.gnome1_health.Size = new System.Drawing.Size(184, 29);
            this.gnome1_health.Step = 1;
            this.gnome1_health.TabIndex = 4;
            this.gnome1_health.Value = 30;
            // 
            // gnome3_health
            // 
            this.gnome3_health.Location = new System.Drawing.Point(881, 953);
            this.gnome3_health.Maximum = 30;
            this.gnome3_health.Name = "gnome3_health";
            this.gnome3_health.Size = new System.Drawing.Size(184, 29);
            this.gnome3_health.Step = 1;
            this.gnome3_health.TabIndex = 5;
            this.gnome3_health.Value = 30;
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(841, 12);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(237, 29);
            this.playerHealth.Step = 1;
            this.playerHealth.TabIndex = 6;
            this.playerHealth.Value = 100;
            // 
            // btn_potions
            // 
            this.btn_potions.Location = new System.Drawing.Point(841, 70);
            this.btn_potions.Name = "btn_potions";
            this.btn_potions.Size = new System.Drawing.Size(237, 67);
            this.btn_potions.TabIndex = 7;
            this.btn_potions.Text = "Potions: 1";
            this.btn_potions.UseVisualStyleBackColor = true;
            this.btn_potions.Click += new System.EventHandler(this.btn_potions_Click);
            // 
            // btn_gnome1
            // 
            this.btn_gnome1.Location = new System.Drawing.Point(1284, 965);
            this.btn_gnome1.Name = "btn_gnome1";
            this.btn_gnome1.Size = new System.Drawing.Size(184, 35);
            this.btn_gnome1.TabIndex = 0;
            this.btn_gnome1.Text = "Attack";
            this.btn_gnome1.UseVisualStyleBackColor = true;
            this.btn_gnome1.Click += new System.EventHandler(this.btn_gnome1_Click);
            // 
            // btn_gnome3
            // 
            this.btn_gnome3.Location = new System.Drawing.Point(881, 988);
            this.btn_gnome3.Name = "btn_gnome3";
            this.btn_gnome3.Size = new System.Drawing.Size(184, 31);
            this.btn_gnome3.TabIndex = 1;
            this.btn_gnome3.Text = "Attack";
            this.btn_gnome3.UseVisualStyleBackColor = true;
            this.btn_gnome3.Click += new System.EventHandler(this.btn_gnome3_Click);
            // 
            // btn_gnome2
            // 
            this.btn_gnome2.Location = new System.Drawing.Point(503, 965);
            this.btn_gnome2.Name = "btn_gnome2";
            this.btn_gnome2.Size = new System.Drawing.Size(184, 28);
            this.btn_gnome2.TabIndex = 2;
            this.btn_gnome2.Text = "Attack";
            this.btn_gnome2.UseVisualStyleBackColor = true;
            this.btn_gnome2.Click += new System.EventHandler(this.btn_gnome2_Click);
            // 
            // pictureBoxGnome2
            // 
            this.pictureBoxGnome2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGnome2.Image = global::test325.Properties.Resources.FO76_Red_garden_gnome;
            this.pictureBoxGnome2.Location = new System.Drawing.Point(395, 414);
            this.pictureBoxGnome2.Name = "pictureBoxGnome2";
            this.pictureBoxGnome2.Size = new System.Drawing.Size(324, 510);
            this.pictureBoxGnome2.TabIndex = 8;
            this.pictureBoxGnome2.TabStop = false;
            // 
            // pictureBoxgnome3
            // 
            this.pictureBoxgnome3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxgnome3.Image = global::test325.Properties.Resources._2cd43b_2cfcd5860a27444197797cc72f095310_mv2;
            this.pictureBoxgnome3.Location = new System.Drawing.Point(794, 513);
            this.pictureBoxgnome3.Name = "pictureBoxgnome3";
            this.pictureBoxgnome3.Size = new System.Drawing.Size(340, 434);
            this.pictureBoxgnome3.TabIndex = 9;
            this.pictureBoxgnome3.TabStop = false;
            // 
            // pictureBoxgnome1
            // 
            this.pictureBoxgnome1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxgnome1.Image = global::test325.Properties.Resources.output_onlinepngtools;
            this.pictureBoxgnome1.Location = new System.Drawing.Point(1271, 513);
            this.pictureBoxgnome1.Name = "pictureBoxgnome1";
            this.pictureBoxgnome1.Size = new System.Drawing.Size(212, 420);
            this.pictureBoxgnome1.TabIndex = 10;
            this.pictureBoxgnome1.TabStop = false;
            // 
            // GnomeFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.wind_street_08_05_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBoxgnome1);
            this.Controls.Add(this.pictureBoxgnome3);
            this.Controls.Add(this.pictureBoxGnome2);
            this.Controls.Add(this.btn_potions);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.gnome3_health);
            this.Controls.Add(this.gnome1_health);
            this.Controls.Add(this.gnome2_health);
            this.Controls.Add(this.btn_gnome2);
            this.Controls.Add(this.btn_gnome3);
            this.Controls.Add(this.btn_gnome1);
            this.DoubleBuffered = true;
            this.Name = "GnomeFight";
            this.Text = "GnomeFight";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGnome2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgnome3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgnome1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar gnome2_health;
        private System.Windows.Forms.ProgressBar gnome1_health;
        private System.Windows.Forms.ProgressBar gnome3_health;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.Button btn_potions;
        private System.Windows.Forms.Button btn_gnome1;
        private System.Windows.Forms.Button btn_gnome3;
        private System.Windows.Forms.Button btn_gnome2;
        private System.Windows.Forms.PictureBox pictureBoxGnome2;
        private System.Windows.Forms.PictureBox pictureBoxgnome3;
        private System.Windows.Forms.PictureBox pictureBoxgnome1;
    }
}