
namespace TalesOfTheMagicSword
{
    partial class OutsideBar
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
            this.btn_openchest = new System.Windows.Forms.Button();
            this.btn_swrd = new System.Windows.Forms.Button();
            this.btn_map = new System.Windows.Forms.Button();
            this.pictureBoxSword = new System.Windows.Forms.PictureBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxcoins = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoins)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_openchest
            // 
            this.btn_openchest.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_openchest.Location = new System.Drawing.Point(739, 778);
            this.btn_openchest.Name = "btn_openchest";
            this.btn_openchest.Size = new System.Drawing.Size(432, 182);
            this.btn_openchest.TabIndex = 0;
            this.btn_openchest.Text = "Open Chest";
            this.btn_openchest.UseVisualStyleBackColor = true;
            this.btn_openchest.Click += new System.EventHandler(this.btn_openchest_Click);
            // 
            // btn_swrd
            // 
            this.btn_swrd.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_swrd.Location = new System.Drawing.Point(422, 566);
            this.btn_swrd.Name = "btn_swrd";
            this.btn_swrd.Size = new System.Drawing.Size(210, 56);
            this.btn_swrd.TabIndex = 1;
            this.btn_swrd.Text = "Take Sword";
            this.btn_swrd.UseVisualStyleBackColor = true;
            this.btn_swrd.Visible = false;
            this.btn_swrd.Click += new System.EventHandler(this.btn_swrd_Click);
            // 
            // btn_map
            // 
            this.btn_map.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_map.Location = new System.Drawing.Point(1131, 524);
            this.btn_map.Name = "btn_map";
            this.btn_map.Size = new System.Drawing.Size(186, 76);
            this.btn_map.TabIndex = 2;
            this.btn_map.Text = "Map and coins";
            this.btn_map.UseVisualStyleBackColor = true;
            this.btn_map.Visible = false;
            this.btn_map.Click += new System.EventHandler(this.btn_map_Click);
            // 
            // pictureBoxSword
            // 
            this.pictureBoxSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSword.Image = global::test325.Properties.Resources.output_onlinepngtools__3_2;
            this.pictureBoxSword.Location = new System.Drawing.Point(396, 628);
            this.pictureBoxSword.Name = "pictureBoxSword";
            this.pictureBoxSword.Size = new System.Drawing.Size(271, 204);
            this.pictureBoxSword.TabIndex = 3;
            this.pictureBoxSword.TabStop = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = global::test325.Properties.Resources.output_onlinepngtools__7_4;
            this.pictureBoxMap.Location = new System.Drawing.Point(1038, 628);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(165, 144);
            this.pictureBoxMap.TabIndex = 4;
            this.pictureBoxMap.TabStop = false;
            // 
            // pictureBoxcoins
            // 
            this.pictureBoxcoins.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxcoins.Image = global::test325.Properties.Resources.output_onlinepngtools__9_2;
            this.pictureBoxcoins.Location = new System.Drawing.Point(1209, 617);
            this.pictureBoxcoins.Name = "pictureBoxcoins";
            this.pictureBoxcoins.Size = new System.Drawing.Size(278, 130);
            this.pictureBoxcoins.TabIndex = 5;
            this.pictureBoxcoins.TabStop = false;
            // 
            // OutsideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.Inside_of_a_chest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBoxcoins);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.pictureBoxSword);
            this.Controls.Add(this.btn_map);
            this.Controls.Add(this.btn_swrd);
            this.Controls.Add(this.btn_openchest);
            this.Name = "OutsideBar";
            this.Text = "OutsideBar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_openchest;
        private System.Windows.Forms.Button btn_swrd;
        private System.Windows.Forms.Button btn_map;
        private System.Windows.Forms.PictureBox pictureBoxSword;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxcoins;
    }
}