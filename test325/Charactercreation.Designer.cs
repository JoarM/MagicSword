
namespace Projektvecka
{
    partial class Charactercreation
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
            this.gndrbtn1 = new System.Windows.Forms.Button();
            this.gndrbtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gndrMale = new System.Windows.Forms.PictureBox();
            this.cnfrmbtn = new System.Windows.Forms.Button();
            this.gndrFemale = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gndrMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gndrFemale)).BeginInit();
            this.SuspendLayout();
            // 
            // gndrbtn1
            // 
            this.gndrbtn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gndrbtn1.Image = global::test325.Properties.Resources.output_onlinepngtools__3_;
            this.gndrbtn1.Location = new System.Drawing.Point(127, 154);
            this.gndrbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.gndrbtn1.Name = "gndrbtn1";
            this.gndrbtn1.Size = new System.Drawing.Size(214, 166);
            this.gndrbtn1.TabIndex = 0;
            this.gndrbtn1.UseVisualStyleBackColor = false;
            this.gndrbtn1.Click += new System.EventHandler(this.gndrbtn1_Click);
            // 
            // gndrbtn2
            // 
            this.gndrbtn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gndrbtn2.Image = global::test325.Properties.Resources.output_onlinepngtools__4_;
            this.gndrbtn2.Location = new System.Drawing.Point(513, 154);
            this.gndrbtn2.Margin = new System.Windows.Forms.Padding(2);
            this.gndrbtn2.Name = "gndrbtn2";
            this.gndrbtn2.Size = new System.Drawing.Size(233, 166);
            this.gndrbtn2.TabIndex = 1;
            this.gndrbtn2.UseVisualStyleBackColor = false;
            this.gndrbtn2.Click += new System.EventHandler(this.gndrbtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(348, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose gender";
            // 
            // gndrMale
            // 
            this.gndrMale.BackColor = System.Drawing.Color.Transparent;
            this.gndrMale.Image = global::test325.Properties.Resources.output_onlinepngtools__8_1;
            this.gndrMale.Location = new System.Drawing.Point(1037, 104);
            this.gndrMale.Margin = new System.Windows.Forms.Padding(2);
            this.gndrMale.Name = "gndrMale";
            this.gndrMale.Size = new System.Drawing.Size(446, 820);
            this.gndrMale.TabIndex = 3;
            this.gndrMale.TabStop = false;
            // 
            // cnfrmbtn
            // 
            this.cnfrmbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cnfrmbtn.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnfrmbtn.Location = new System.Drawing.Point(1156, 928);
            this.cnfrmbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cnfrmbtn.Name = "cnfrmbtn";
            this.cnfrmbtn.Size = new System.Drawing.Size(186, 40);
            this.cnfrmbtn.TabIndex = 4;
            this.cnfrmbtn.Text = "Confirm";
            this.cnfrmbtn.UseVisualStyleBackColor = false;
            this.cnfrmbtn.Click += new System.EventHandler(this.cnfrmbtn_Click);
            // 
            // gndrFemale
            // 
            this.gndrFemale.BackColor = System.Drawing.Color.Transparent;
            this.gndrFemale.Image = global::test325.Properties.Resources.output_onlinepngtools__7_1;
            this.gndrFemale.Location = new System.Drawing.Point(1126, 65);
            this.gndrFemale.Margin = new System.Windows.Forms.Padding(2);
            this.gndrFemale.Name = "gndrFemale";
            this.gndrFemale.Size = new System.Drawing.Size(339, 832);
            this.gndrFemale.TabIndex = 5;
            this.gndrFemale.TabStop = false;
            // 
            // Charactercreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test325.Properties.Resources.maxresdefault__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.cnfrmbtn);
            this.Controls.Add(this.gndrMale);
            this.Controls.Add(this.gndrFemale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gndrbtn2);
            this.Controls.Add(this.gndrbtn1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Charactercreation";
            this.Text = "Charactercreation";
            this.Load += new System.EventHandler(this.Charactercreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gndrMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gndrFemale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gndrbtn1;
        private System.Windows.Forms.Button gndrbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gndrMale;
        private System.Windows.Forms.Button cnfrmbtn;
        private System.Windows.Forms.PictureBox gndrFemale;
    }
}