using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;




namespace _11
{
    public partial class Form1 : Form
    {

        //-------------------------------------
        TextBox[] txtBox;
        Label[] lbl;

        int n = 4;
        int space = 20;
        //-------------------------------------

        //-------------------------------------
        PictureBox[] Map;
        //-------------------------------------





        public Form1()
        {
            InitializeComponent();
        }

       


        int SelectingTile;


        //public Form1()
        //{
        //    InitializeComponent();
        //}

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





        private void TestDarray_Click(object sender, EventArgs e)
        {
                txtBox = new TextBox[n];
                lbl = new Label[n];

                for (int i = 0; i < n; i++)
                {
                    txtBox[i] = new TextBox();
                    txtBox[i].Name = "n" + i;
                    txtBox[i].Text = "n" + i;

                    lbl[i] = new Label();
                    lbl[i].Name = "n" + i;
                    lbl[i].Text = "n" + i;
                }

                for (int i = 0; i < n; i++)
                {
                    txtBox[i].Visible = true;
                    lbl[i].Visible = true;
                    txtBox[i].Location = new Point(40, 50 + space);
                    lbl[i].Location = new Point(10, 50 + space);
                    this.Controls.Add(txtBox[i]);
                    this.Controls.Add(lbl[i]);
                    space += 50;
                }
        }

        static int Row = 10;
        static int Column = 10;

        int GetIndex(int Row, int Col)
        {
            return Row * Column + Col;
        }

        int MaxTiles = Row * Column;
       

        private void CreateMap_Click(object sender, EventArgs e)
        {

            Map = new PictureBox[MaxTiles];

           

            for (int i = 0; i < MaxTiles; i++)
            {
                Map[i] = new PictureBox();
                var image = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                Map[i].BackgroundImage = image;
                Map[i].Width = image.Width; ;
                Map[i].Height = image.Height;

                Map[i].Click += new EventHandler(ClickTile_click);
            }

            for(int row = 0; row < Row; ++row)
            {
                for (int col = 0; col < Column; col++)
                {
                    Point point = new Point(400 + 32 * col, 50 + 32 * row);
                    Map[GetIndex(row, col)].Location = point;
                    this.Controls.Add(Map[GetIndex(row, col)]);
                }
            }
        }

        PictureBox ClickTile = new PictureBox();
       // ClickTile += new EventHandler();

        private void ClickTile_click(object sender, EventArgs e)
        {
            PictureBox Box = (PictureBox)(sender);

            switch (SelectingTile)
            {
                case 1:
                    Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    break;

                case 2:
                    Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                    break;

                case 3:
                    Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
                    break;

            }
        }



    }
}
