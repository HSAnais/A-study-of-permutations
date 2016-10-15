using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace permimag
{
    public partial class Form1 : Form
    {
        int nr;
        int[] st = new int[100];
        PictureBox[] t = new PictureBox[7];
        
        int valid(int k)
        {
            int i;
            for (i = 1; i <k; i++)
                if (st[k] == st[i])
                    return 0;
            return 1;
        }
        void tipar(int k)
        {
            int i;
            for (i = 1; i <= 3; i++)
            {
               
                switch (st[i])
                {
                    case 1: t[i].Image= pictureBox1.Image; break;
                    case 2: t[i].Image = pictureBox2.Image; break;
                    case 3: t[i].Image = pictureBox3.Image; break;
                }
            }
        }
        void back(int k)
        {
            int i;
            for (i = 1; i <= 3; i++)
            {
                st[k] = i;
                if (valid(k)==1)
                    if (k == 3)
                    {   
                        tipar(k);
                        nr++;
                        MessageBox.Show("Solutia " + nr);
                        
                    }
                    else
                         back(k + 1);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t[1] = new PictureBox();
            t[1].Width=100;
            t[1].Height=100;
            t[1].Top=150;
            t[1].Left=50;
            t[1].SizeMode=PictureBoxSizeMode.StretchImage;
            //t[1].Image=pictureBox1.Image;
            this.Controls.Add(t[1]);
            t[2] = new PictureBox();
            t[2].Width=100;
            t[2].Height=100;
            t[2].Top=150;
            t[2].Left=160;
            t[2].SizeMode=PictureBoxSizeMode.StretchImage;
            //t[2].Image=pictureBox2.Image;
            this.Controls.Add(t[2]);
            t[3] = new PictureBox();
            t[3].Width=100;
            t[3].Height=100;
            t[3].Top=150;
            t[3].Left=270;
            t[3].SizeMode=PictureBoxSizeMode.StretchImage;
            //t[3].Image=pictureBox3.Image;
            this.Controls.Add(t[3]);
            back(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
