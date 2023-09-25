namespace CCC
{
    partial class frmSlicer
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
            this.btnGenerateSlides = new System.Windows.Forms.Button();
            this.txtPatchSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatches = new System.Windows.Forms.TextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSharePatches = new System.Windows.Forms.TextBox();
            this.btnSaveSlides = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnCover = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateSlides
            // 
            this.btnGenerateSlides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSlides.Location = new System.Drawing.Point(12, 500);
            this.btnGenerateSlides.Name = "btnGenerateSlides";
            this.btnGenerateSlides.Size = new System.Drawing.Size(300, 32);
            this.btnGenerateSlides.TabIndex = 132;
            this.btnGenerateSlides.Text = "Generate Sildes";
            this.btnGenerateSlides.UseVisualStyleBackColor = true;
            this.btnGenerateSlides.Click += new System.EventHandler(this.btnGenerateImage_Click);
            // 
            // txtPatchSize
            // 
            this.txtPatchSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatchSize.Location = new System.Drawing.Point(114, 379);
            this.txtPatchSize.Name = "txtPatchSize";
            this.txtPatchSize.Size = new System.Drawing.Size(59, 26);
            this.txtPatchSize.TabIndex = 134;
            this.txtPatchSize.Text = "1";
            this.txtPatchSize.TextChanged += new System.EventHandler(this.txtPatchSize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "Patch Size:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 578);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(300, 23);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 148;
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(253, 418);
            this.txtRows.Name = "txtRows";
            this.txtRows.ReadOnly = true;
            this.txtRows.Size = new System.Drawing.Size(59, 26);
            this.txtRows.TabIndex = 150;
            this.txtRows.Text = "0";
            // 
            // txtCols
            // 
            this.txtCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCols.Location = new System.Drawing.Point(114, 418);
            this.txtCols.Name = "txtCols";
            this.txtCols.ReadOnly = true;
            this.txtCols.Size = new System.Drawing.Size(59, 26);
            this.txtCols.TabIndex = 149;
            this.txtCols.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Cols:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(184, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 152;
            this.label8.Text = "Rows:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.White;
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Location = new System.Drawing.Point(12, 70);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(300, 300);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 174;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(300, 52);
            this.btnOpen.TabIndex = 176;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 178;
            this.label3.Text = "Total Patches:";
            // 
            // txtPatches
            // 
            this.txtPatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatches.Location = new System.Drawing.Point(12, 470);
            this.txtPatches.Name = "txtPatches";
            this.txtPatches.ReadOnly = true;
            this.txtPatches.Size = new System.Drawing.Size(124, 26);
            this.txtPatches.TabIndex = 177;
            this.txtPatches.Text = "0";
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Location = new System.Drawing.Point(749, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(599, 686);
            this.pnl.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 183;
            this.label1.Text = "Patches/Slide:";
            // 
            // txtSharePatches
            // 
            this.txtSharePatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSharePatches.Location = new System.Drawing.Point(188, 470);
            this.txtSharePatches.Name = "txtSharePatches";
            this.txtSharePatches.ReadOnly = true;
            this.txtSharePatches.Size = new System.Drawing.Size(124, 26);
            this.txtSharePatches.TabIndex = 182;
            this.txtSharePatches.Text = "0";
            // 
            // btnSaveSlides
            // 
            this.btnSaveSlides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSlides.Location = new System.Drawing.Point(12, 538);
            this.btnSaveSlides.Name = "btnSaveSlides";
            this.btnSaveSlides.Size = new System.Drawing.Size(300, 34);
            this.btnSaveSlides.TabIndex = 184;
            this.btnSaveSlides.Text = "Save Slides";
            this.btnSaveSlides.UseVisualStyleBackColor = true;
            this.btnSaveSlides.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG|*.png";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtShares
            // 
            this.txtShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShares.Location = new System.Drawing.Point(253, 379);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(59, 26);
            this.txtShares.TabIndex = 185;
            this.txtShares.Text = "10";
            this.txtShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 186;
            this.label4.Text = "Slides:";
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.White;
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(318, 70);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(300, 300);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 187;
            this.picCover.TabStop = false;
            this.picCover.Click += new System.EventHandler(this.picCover_Click);
            // 
            // btnCover
            // 
            this.btnCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCover.Location = new System.Drawing.Point(318, 12);
            this.btnCover.Name = "btnCover";
            this.btnCover.Size = new System.Drawing.Size(300, 52);
            this.btnCover.TabIndex = 188;
            this.btnCover.Text = "Open Cover";
            this.btnCover.UseVisualStyleBackColor = true;
            this.btnCover.Click += new System.EventHandler(this.btnCover_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // frmSlicer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1348, 686);
            this.Controls.Add(this.btnCover);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.btnSaveSlides);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSharePatches);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatches);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtPatchSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateSlides);
            this.Name = "frmSlicer";
            this.Text = "Slicing";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGenerateSlides;
        private System.Windows.Forms.TextBox txtPatchSize;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.PictureBox picImg;
        internal System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatches;
        private System.Windows.Forms.Panel pnl;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSharePatches;
        internal System.Windows.Forms.Button btnSaveSlides;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtShares;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.PictureBox picCover;
        internal System.Windows.Forms.Button btnCover;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}