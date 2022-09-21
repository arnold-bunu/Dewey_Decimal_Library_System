namespace PROG7312_TASK1_POE
{
    partial class LandingPage
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
            this.btnCallNum = new System.Windows.Forms.PictureBox();
            this.btnIdentify = new System.Windows.Forms.PictureBox();
            this.btnReplace = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCallNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIdentify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCallNum
            // 
            this.btnCallNum.Image = global::PROG7312_TASK1_POE.Properties.Resources.find_call_;
            this.btnCallNum.Location = new System.Drawing.Point(579, 162);
            this.btnCallNum.Name = "btnCallNum";
            this.btnCallNum.Size = new System.Drawing.Size(190, 169);
            this.btnCallNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCallNum.TabIndex = 0;
            this.btnCallNum.TabStop = false;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Image = global::PROG7312_TASK1_POE.Properties.Resources.IDENTIFY_ICON;
            this.btnIdentify.Location = new System.Drawing.Point(322, 162);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(190, 169);
            this.btnIdentify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIdentify.TabIndex = 0;
            this.btnIdentify.TabStop = false;
            // 
            // btnReplace
            // 
            this.btnReplace.Image = global::PROG7312_TASK1_POE.Properties.Resources.replace_icon;
            this.btnReplace.Location = new System.Drawing.Point(51, 162);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(190, 169);
            this.btnReplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReplace.TabIndex = 0;
            this.btnReplace.TabStop = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome (User) Please select what you would like to do";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCallNum);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnReplace);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCallNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIdentify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnReplace;
        private System.Windows.Forms.PictureBox btnIdentify;
        private System.Windows.Forms.PictureBox btnCallNum;
        private System.Windows.Forms.Label label1;
    }
}