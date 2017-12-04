using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {


        int SelectingTile;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Button List
        //1.Stone
        //2.Grass_Green
        //3.Grass_Brown

        private void Button_Stone_Click(object sender, EventArgs e)
        {
            SelectingTile = 1;
        }

        private void Button_Grass_Green_Click(object sender, EventArgs e)
        {
            SelectingTile = 2;
        }

        private void Button_Grass_Brown_Click(object sender, EventArgs e)
        {
            SelectingTile = 3;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            switch (SelectingTile)
            {
                case 1:
                    this.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    break;

                case 2:
                    this.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                    break;

                case 3:
                    this.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
                    break; 

                    //}
            }
        }


        private void PlaceTile(PictureBox ClickingOne)
        {
            switch (SelectingTile)
            {
                case 1:
                    ClickingOne.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    break;

                case 2:
                    ClickingOne.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    break;

                case 3:
                    ClickingOne.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    break;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
