namespace PROG7312_TASK1_POE
{
    partial class ReplaceBooks
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
            this.lbxRanGenCallNum = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.lbxCorrect = new System.Windows.Forms.ListBox();
            this.lblshowScore = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.pbDownbtn = new System.Windows.Forms.PictureBox();
            this.pbUpbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.starCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxRanGenCallNum
            // 
            this.lbxRanGenCallNum.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRanGenCallNum.FormattingEnabled = true;
            this.lbxRanGenCallNum.ItemHeight = 15;
            this.lbxRanGenCallNum.Location = new System.Drawing.Point(160, 90);
            this.lbxRanGenCallNum.Name = "lbxRanGenCallNum";
            this.lbxRanGenCallNum.Size = new System.Drawing.Size(159, 229);
            this.lbxRanGenCallNum.TabIndex = 0;
            this.lbxRanGenCallNum.SelectedIndexChanged += new System.EventHandler(this.lbxRanGenCallNum_SelectedIndexChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDone.Location = new System.Drawing.Point(315, 347);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(159, 53);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "DONE ";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerate.Location = new System.Drawing.Point(342, 167);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 28);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTryAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTryAgain.Location = new System.Drawing.Point(342, 214);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(110, 28);
            this.btnTryAgain.TabIndex = 4;
            this.btnTryAgain.Text = "New List";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // lbxCorrect
            // 
            this.lbxCorrect.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCorrect.FormattingEnabled = true;
            this.lbxCorrect.ItemHeight = 15;
            this.lbxCorrect.Location = new System.Drawing.Point(475, 90);
            this.lbxCorrect.Name = "lbxCorrect";
            this.lbxCorrect.Size = new System.Drawing.Size(159, 229);
            this.lbxCorrect.TabIndex = 0;
            this.lbxCorrect.SelectedIndexChanged += new System.EventHandler(this.lbxRanGenCallNum_SelectedIndexChanged);
            // 
            // lblshowScore
            // 
            this.lblshowScore.AutoSize = true;
            this.lblshowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowScore.Location = new System.Drawing.Point(476, 322);
            this.lblshowScore.Name = "lblshowScore";
            this.lblshowScore.Size = new System.Drawing.Size(57, 20);
            this.lblshowScore.TabIndex = 5;
            this.lblshowScore.Text = "label1";
            // 
            // star5
            // 
            this.star5.Image = global::PROG7312_TASK1_POE.Properties.Resources.stars;
            this.star5.Location = new System.Drawing.Point(592, 386);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(26, 33);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 6;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Image = global::PROG7312_TASK1_POE.Properties.Resources.stars;
            this.star4.Location = new System.Drawing.Point(564, 386);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(26, 33);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 6;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Image = global::PROG7312_TASK1_POE.Properties.Resources.stars;
            this.star3.Location = new System.Drawing.Point(536, 386);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(26, 33);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 6;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Image = global::PROG7312_TASK1_POE.Properties.Resources.stars;
            this.star2.Location = new System.Drawing.Point(508, 386);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(26, 33);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 6;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Image = global::PROG7312_TASK1_POE.Properties.Resources.stars;
            this.star1.Location = new System.Drawing.Point(480, 386);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(26, 33);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 6;
            this.star1.TabStop = false;
            // 
            // pbDownbtn
            // 
            this.pbDownbtn.Image = global::PROG7312_TASK1_POE.Properties.Resources.down_icon;
            this.pbDownbtn.Location = new System.Drawing.Point(342, 248);
            this.pbDownbtn.Name = "pbDownbtn";
            this.pbDownbtn.Size = new System.Drawing.Size(110, 71);
            this.pbDownbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDownbtn.TabIndex = 2;
            this.pbDownbtn.TabStop = false;
            this.pbDownbtn.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pbUpbtn
            // 
            this.pbUpbtn.Image = global::PROG7312_TASK1_POE.Properties.Resources.up_icon;
            this.pbUpbtn.Location = new System.Drawing.Point(342, 90);
            this.pbUpbtn.Name = "pbUpbtn";
            this.pbUpbtn.Size = new System.Drawing.Size(110, 71);
            this.pbUpbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpbtn.TabIndex = 2;
            this.pbUpbtn.TabStop = false;
            this.pbUpbtn.Click += new System.EventHandler(this.pbUpbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PROG7312_TASK1_POE.Properties.Resources.find_call_;
            this.pictureBox3.Location = new System.Drawing.Point(531, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROG7312_TASK1_POE.Properties.Resources.IDENTIFY_ICON;
            this.pictureBox2.Location = new System.Drawing.Point(315, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROG7312_TASK1_POE.Properties.Resources.home_icon;
            this.pictureBox1.Location = new System.Drawing.Point(112, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // starCount
            // 
            this.starCount.AutoSize = true;
            this.starCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starCount.Location = new System.Drawing.Point(476, 349);
            this.starCount.Name = "starCount";
            this.starCount.Size = new System.Drawing.Size(52, 18);
            this.starCount.TabIndex = 5;
            this.starCount.Text = "label1";
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.starCount);
            this.Controls.Add(this.lblshowScore);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pbDownbtn);
            this.Controls.Add(this.pbUpbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbxCorrect);
            this.Controls.Add(this.lbxRanGenCallNum);
            this.Name = "ReplaceBooks";
            this.Text = "ReplaceBooks";
            this.Load += new System.EventHandler(this.ReplaceBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRanGenCallNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbUpbtn;
        private System.Windows.Forms.PictureBox pbDownbtn;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.ListBox lbxCorrect;
        private System.Windows.Forms.Label lblshowScore;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.Label starCount;
    }
}