
namespace Projektvecka
{
    partial class Charactercreation2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charactercreation2));
            this.gndrFemale2 = new System.Windows.Forms.PictureBox();
            this.gndrMale2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cnfrmbtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gndrFemale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gndrMale2)).BeginInit();
            this.SuspendLayout();
            // 
            // gndrFemale2
            // 
            this.gndrFemale2.BackColor = System.Drawing.Color.Transparent;
            this.gndrFemale2.Image = ((System.Drawing.Image)(resources.GetObject("gndrFemale2.Image")));
            this.gndrFemale2.Location = new System.Drawing.Point(662, 26);
            this.gndrFemale2.Margin = new System.Windows.Forms.Padding(2);
            this.gndrFemale2.Name = "gndrFemale2";
            this.gndrFemale2.Size = new System.Drawing.Size(326, 876);
            this.gndrFemale2.TabIndex = 0;
            this.gndrFemale2.TabStop = false;
            // 
            // gndrMale2
            // 
            this.gndrMale2.BackColor = System.Drawing.Color.Transparent;
            this.gndrMale2.Image = ((System.Drawing.Image)(resources.GetObject("gndrMale2.Image")));
            this.gndrMale2.Location = new System.Drawing.Point(578, 74);
            this.gndrMale2.Margin = new System.Windows.Forms.Padding(2);
            this.gndrMale2.Name = "gndrMale2";
            this.gndrMale2.Size = new System.Drawing.Size(618, 828);
            this.gndrMale2.TabIndex = 1;
            this.gndrMale2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name our Hero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 27);
            this.textBox1.TabIndex = 3;
            // 
            // cnfrmbtn2
            // 
            this.cnfrmbtn2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnfrmbtn2.Location = new System.Drawing.Point(113, 192);
            this.cnfrmbtn2.Margin = new System.Windows.Forms.Padding(2);
            this.cnfrmbtn2.Name = "cnfrmbtn2";
            this.cnfrmbtn2.Size = new System.Drawing.Size(120, 27);
            this.cnfrmbtn2.TabIndex = 4;
            this.cnfrmbtn2.Text = "Confirm";
            this.cnfrmbtn2.UseVisualStyleBackColor = true;
            this.cnfrmbtn2.Click += new System.EventHandler(this.cnfrmbtn2_Click);
            // 
            // Charactercreation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.gndrMale2);
            this.Controls.Add(this.gndrFemale2);
            this.Controls.Add(this.cnfrmbtn2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Charactercreation2";
            this.Text = "Charactercreation2";
            ((System.ComponentModel.ISupportInitialize)(this.gndrFemale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gndrMale2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gndrFemale2;
        private System.Windows.Forms.PictureBox gndrMale2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cnfrmbtn2;
    }
}