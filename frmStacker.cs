using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace CCC
{
    public partial class frmStacker : Form
    {
        //System Variables------------------------------------------------------------------------
        int TotalSlides;
        Bitmap ImgSlide;

        Bitmap ImgCover;

        Bitmap ImgStacked;

        int CC = 0;
        int Y = 0;
        int X = 0;
        //-----------------------------------------------------------------------------------------
        
        public frmStacker()
        {
            InitializeComponent();
            btnStack.Enabled = false; 
        }
        //-----------------------------------------------------------------------------------------
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Slides";
            openFileDialog1.Multiselect = true; 
            openFileDialog1.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            TotalSlides = openFileDialog1.FileNames.Length-1;
            txtSlides.Text = "" + TotalSlides;

            foreach (string Img in openFileDialog1.FileNames)
            {
                if (!Img.Contains("_"))
                {
                    ImgCover = new Bitmap(Img);
                    break;
                }
            }



            ImgStacked = new Bitmap(ImgCover.Width, ImgCover.Height);
            
            
            pnl.Controls.Clear();

            btnStack.Enabled = true; 
        }
        //-----------------------------------------------------------------------------------------
        private void btnStack_Click(object sender, EventArgs e)
        {
            int SlideNo = 0;
            foreach (string Img in openFileDialog1.FileNames)
            {
                if (!Img.Contains("_"))continue;
                                
                SlideNo++;
                txtSlide.Text = "" + SlideNo;
                lblFile.Text = Path.GetFileName(Img);

                ImgSlide = new Bitmap(Img);
                picImg.Image = ImgSlide;

                Application.DoEvents();

                //initialize progressbar
                pb.Minimum = 0;
                pb.Maximum = ImgSlide.Width * ImgSlide.Height;
                pb.Value = 0;

                for (int x = 0; x < ImgSlide.Width; x++)
                {
                    for (int y = 0; y < ImgSlide.Height; y++)
                    {
                        Color CS = ImgSlide.GetPixel(x, y);
                        Color CV = ImgCover.GetPixel(x, y);

                        Color C =  Color.FromArgb(CS.R ^ CV.R, CS.G ^ CV.G, CS.B ^ CV.B);
                        ImgSlide.SetPixel(x, y, Color.FromArgb(C.R, C.G, C.B)); 

                        Color CI = ImgStacked.GetPixel(x, y);
                        ImgStacked.SetPixel(x, y, Color.FromArgb(C.R | CI.R, C.G | CI.G, C.B | CI.B));
                       

                        pb.Value++;

                    }
                }

                PictureBox PI = new PictureBox();
                PI.Location = new Point(X, Y);
                PI.Height = 300;
                PI.Width = 300;
                PI.SizeMode = PictureBoxSizeMode.StretchImage;
                PI.BackColor = Color.White;
                PI.Image = ImgSlide;

                pnl.Controls.Add(PI);

                CC++;
                if (CC == 1)
                {
                    X = 0; Y += PI.Height + 10;
                    CC = 0;
                }
                else X += PI.Width + 10;

                picStack.Image = ImgStacked;

                
            }
        }
        //-----------------------------------------------------------------------------------------
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            ImgStacked.Save(saveFileDialog1.FileName, ImageFormat.Png);

        }
    }
}
