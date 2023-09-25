using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace CCC
{
    public partial class frmSlicer : Form
    {
        //System Variables------------------------------------------------------------------------
        int TotalSlides;

        Bitmap ImgOriginal;

        Bitmap ImgCover;
        
        Bitmap[] Slides;

        int BlockSize;

        int Rows;
        int Cols;
        int Patches;
        int SlidesTotalPatches;

        int[,] PatchXY;

        int[] PatchesIDX;
        int[] PatchesRandomIDX;

        //-----------------------------------------------------------------------------------------
        public frmSlicer()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------
        private void btnGenerateImage_Click(object sender, EventArgs e)
        {
            CVCInit();
            Slice();
            UpdatePanel();
        }
        //-----------------------------------------------------------------------------------------
        private void CVCInit()
        {
            //get User Inputs
            BlockSize = int.Parse(txtPatchSize.Text);
            TotalSlides = int.Parse(txtShares.Text);

            //calculates statistics
            Rows = ImgOriginal.Height / BlockSize;
            txtRows.Text = "" + Rows;
            Cols = ImgOriginal.Width / BlockSize;
            txtCols.Text = "" + Cols;
            Patches = Rows * Cols;
            txtPatches.Text = "" + Patches;
            SlidesTotalPatches = Patches / TotalSlides;
            txtSharePatches.Text = "" + SlidesTotalPatches;

            //generate array of Patches indexes 
            PatchesIDX = new int[Patches];
            for (int idx = 0; idx < Patches; idx++)
            {
                PatchesIDX[idx] = idx; 
            }

            //dynamically create image array to hold all the slides
            Slides = new Bitmap[TotalSlides];
            for (int idx = 0; idx < TotalSlides; idx++)
            {
                Slides[idx] = new Bitmap(Cols * BlockSize, Rows * BlockSize);
                Slides[idx] = (Bitmap)ImgCover.Clone(); 
            }
            

            //Dynamically create Patches of the Original Image & Store its X,Y in PatchXY array 
            PatchXY = new int[Patches, 2];
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    PatchXY[(r * Cols) + c, 0] = c * BlockSize;
                    PatchXY[(r * Cols) + c, 1] = r * BlockSize;
                }
            }
        }
        //-----------------------------------------------------------------------------------------
        private void Slice()
        {
            //initialize progressbar
            pb.Minimum = 0;
            pb.Maximum = Patches-1;

            //randomize the Patches idex array
            Random rnd = new Random();
            PatchesRandomIDX = PatchesIDX.OrderBy(x => rnd.Next()).ToArray();

            //finally distribute the patches of OriginalImage to all the Slides
            int SlideNo = 0;
            for (int idx = 0; idx < Patches; idx++)
            {
                pb.Value = idx;

                for (int x = PatchXY[PatchesRandomIDX[idx], 0]; x < PatchXY[PatchesRandomIDX[idx], 0] + BlockSize; x++)
                {
                    for (int y = PatchXY[PatchesRandomIDX[idx], 1]; y < PatchXY[PatchesRandomIDX[idx], 1] + BlockSize; y++)
                    {
                        Color C = ImgOriginal.GetPixel(x, y);
                        Color CS = ImgCover.GetPixel(x, y);
                        Slides[SlideNo].SetPixel(x, y, Color.FromArgb(C.R ^ CS.R, C.G ^ CS.G, C.B ^ CS.B));
                       
                    }
                }
                SlideNo++;
                if (SlideNo == TotalSlides) SlideNo = 0;
            }
           
        }
        //-----------------------------------------------------------------------------------------
        void UpdatePanel()
        {
            int CC = 0;
            int Y = 0;
            int X = 0;

            pnl.Controls.Clear();

            for (int idx = 0; idx < TotalSlides; idx++)
            {
                PictureBox PI = new PictureBox();
                PI.Location = new Point(X, Y);
                PI.Height = 300;
                PI.Width = 300;
                PI.SizeMode = PictureBoxSizeMode.StretchImage;
                PI.BackColor = Color.White; 
                PI.Image = Slides[idx];

                pnl.Controls.Add(PI);

                CC++;
                if (CC == 3)
                {
                    X = 0;Y += PI.Height +10;
                    CC = 0;
                }
                else X += PI.Width +10;
            }
        }
        //-----------------------------------------------------------------------------------------
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            openFileDialog1.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ImgOriginal = new Bitmap(openFileDialog1.FileName);
            picImg.Image = ImgOriginal;
        }
        //-----------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); 
        }
        //-----------------------------------------------------------------------------------------
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
            string filePath = saveFileDialog1.FileName;
            string savePath = fileName;
            for (int i = 0; i < Slides.Length; i++)
            {
                savePath = filePath.Replace(fileName, fileName + "_" + i);
                Slides[i].Save(savePath, ImageFormat.Png);
            }

            //finally save cover
            ImgCover.Save(saveFileDialog1.FileName);  
        }
        //-----------------------------------------------------------------------------------------
        private void btnCover_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Open Image";
            openFileDialog2.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            ImgCover = new Bitmap(openFileDialog2.FileName);
            picCover.Image = ImgCover;
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPatchSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShares_TextChanged(object sender, EventArgs e)
        {

        }

        private void picCover_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------
    }
}

