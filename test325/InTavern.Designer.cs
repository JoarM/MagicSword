
namespace TalesOfTheMagicSword
{
    partial class InTavern
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
            this.btn_dice = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.btn_rope = new System.Windows.Forms.Button();
            this.btn_chair = new System.Windows.Forms.Button();
            this.btn_bar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dice
            // 
            this.btn_dice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_dice.Location = new System.Drawing.Point(32, 455);
            this.btn_dice.Name = "btn_dice";
            this.btn_dice.Size = new System.Drawing.Size(243, 111);
            this.btn_dice.TabIndex = 0;
            this.btn_dice.Text = "Throw dice";
            this.btn_dice.UseVisualStyleBackColor = false;
            this.btn_dice.Click += new System.EventHandler(this.btn_dice_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ext.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ext.Location = new System.Drawing.Point(593, 949);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(169, 63);
            this.btn_ext.TabIndex = 1;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = false;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // btn_rope
            // 
            this.btn_rope.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_rope.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rope.Location = new System.Drawing.Point(1358, 984);
            this.btn_rope.Name = "btn_rope";
            this.btn_rope.Size = new System.Drawing.Size(94, 28);
            this.btn_rope.TabIndex = 2;
            this.btn_rope.Text = "Rope";
            this.btn_rope.UseVisualStyleBackColor = false;
            this.btn_rope.Click += new System.EventHandler(this.btn_rope_Click);
            // 
            // btn_chair
            // 
            this.btn_chair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_chair.Font = new System.Drawing.Font("Sitka Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chair.Location = new System.Drawing.Point(1397, 621);
            this.btn_chair.Name = "btn_chair";
            this.btn_chair.Size = new System.Drawing.Size(168, 32);
            this.btn_chair.TabIndex = 3;
            this.btn_chair.Text = "Chair";
            this.btn_chair.UseVisualStyleBackColor = false;
            this.btn_chair.Click += new System.EventHandler(this.btn_chair_Click);
            // 
            // btn_bar
            // 
            this.btn_bar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_bar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bar.Location = new System.Drawing.Point(723, 402);
            this.btn_bar.Name = "btn_bar";
            this.btn_bar.Size = new System.Drawing.Size(313, 122);
            this.btn_bar.TabIndex = 4;
            this.btn_bar.Text = "Go to bar";
            this.btn_bar.UseVisualStyleBackColor = false;
            this.btn_bar.Click += new System.EventHandler(this.btn_bar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::test325.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1325, 842);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::test325.Properties.Resources.output_onlinepngtools__2_;
            this.pictureBox2.Location = new System.Drawing.Point(32, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 255);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // InTavern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources._2a2b6dd7efe2a8874699abf24a7d6dac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bar);
            this.Controls.Add(this.btn_chair);
            this.Controls.Add(this.btn_rope);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_dice);
            this.Name = "InTavern";
            this.Text = "InTavern";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dice;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Button btn_rope;
        private System.Windows.Forms.Button btn_chair;
        private System.Windows.Forms.Button btn_bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}