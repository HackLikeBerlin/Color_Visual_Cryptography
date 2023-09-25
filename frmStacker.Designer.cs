namespace CCC
{
    partial class frmStacker
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.picStack = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSlides = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnStack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlide = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStack)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*.png";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(300, 52);
            this.btnOpen.TabIndex = 178;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.White;
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Location = new System.Drawing.Point(12, 69);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(300, 300);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 177;
            this.picImg.TabStop = false;
            // 
            // picStack
            // 
            this.picStack.BackColor = System.Drawing.Color.White;
            this.picStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStack.Location = new System.Drawing.Point(318, 11);
            this.picStack.Name = "picStack";
            this.picStack.Size = new System.Drawing.Size(600, 600);
            this.picStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStack.TabIndex = 180;
            this.picStack.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 182;
            this.label3.Text = "Total Stacked Slides:";
            // 
            // txtSlides
            // 
            this.txtSlides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlides.Location = new System.Drawing.Point(188, 437);
            this.txtSlides.Name = "txtSlides";
            this.txtSlides.ReadOnly = true;
            this.txtSlides.Size = new System.Drawing.Size(124, 26);
            this.txtSlides.TabIndex = 181;
            this.txtSlides.Text = "0";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 588);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(300, 23);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 183;
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Location = new System.Drawing.Point(930, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(295, 622);
            this.pnl.TabIndex = 184;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(12, 529);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(300, 53);
            this.btnSaveImage.TabIndex = 185;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG|*.png";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnStack
            // 
            this.btnStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.Location = new System.Drawing.Point(12, 378);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(300, 53);
            this.btnStack.TabIndex = 186;
            this.btnStack.Text = "Stack Slides";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 188;
            this.label1.Text = "Current Slide:";
            // 
            // txtSlide
            // 
            this.txtSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlide.Location = new System.Drawing.Point(188, 469);
            this.txtSlide.Name = "txtSlide";
            this.txtSlide.ReadOnly = true;
            this.txtSlide.Size = new System.Drawing.Size(124, 26);
            this.txtSlide.TabIndex = 187;
            this.txtSlide.Text = "0";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BackColor = System.Drawing.Color.Transparent;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(8, 506);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(105, 20);
            this.lblFile.TabIndex = 189;
            this.lblFile.Text = "XXXXXXXX";
            // 
            // frmStacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1225, 622);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlide);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSlides);
            this.Controls.Add(this.picStack);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picImg);
            this.Name = "frmStacker";
            this.Text = "Stacking";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.PictureBox picImg;
        internal System.Windows.Forms.PictureBox picStack;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSlides;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Panel pnl;
        internal System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.Button btnStack;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlide;
        internal System.Windows.Forms.Label lblFile;
    }
}