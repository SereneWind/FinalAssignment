﻿using System;
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
using System.IO;



namespace _11
{
    public partial class Form1 : Form
    {

        //-------------------------------------
        TextBox[] txtBox;
        Label[] lbl;
        List<char> data = new List<char>();

        List<string> loadData = new List<string>();

        int n = 4;
        int space = 20;
        //-------------------------------------

        //-------------------------------------
        PictureBox[] Map;
        //-------------------------------------





        public Form1()
        {
            InitializeComponent();
            MouseDown += new MouseEventHandler(Handle_MouseDown);
        }

        private void Handle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Control control = (Control)sender;
                if (control.Capture)
                {
                    control.Capture = false;
                }
            }
        }

        int SelectingTile;

        //int MouseTile;


        private void GetMouseTile()
        {

        }


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
            label3.Text = "Stone";
        }

        private void Button_Grass_Green_Click(object sender, EventArgs e)
        {
            SelectingTile = 2;
            label3.Text = "Grass";
        }

        private void Button_Grass_Brown_Click(object sender, EventArgs e)
        {
            SelectingTile = 3;
            label3.Text = "Grass_02";
        }
        private void Button_brick_blue_Click(object sender, EventArgs e)
        {
            SelectingTile = 4;
            label3.Text = "brick_blue";
        }

        private void Button_brick_brown_Click(object sender, EventArgs e)
        {
            SelectingTile = 5;
            label3.Text = "brick_brown";
        }

        private void Button_brick_grail_brown_Click(object sender, EventArgs e)
        {
            SelectingTile = 6;
            label3.Text = "brick_grail_brown";
        }

        private void Button_brick_grail_orange_Click(object sender, EventArgs e)
        {
            SelectingTile = 7;
            label3.Text = "brick_grail_orange";
        }

        private void Button_brick_grail_white_Click(object sender, EventArgs e)
        {
            SelectingTile = 8;
            label3.Text = "brick_grail_white";
        }

        private void Button_brick_grail_yellow_Click(object sender, EventArgs e)
        {
            SelectingTile = 9;
            label3.Text = "brick_grail_yellow";
        }

        private void Button_stairs_brown1_Click(object sender, EventArgs e)
        {
            SelectingTile = 10;
            label3.Text = "stairs_brown1";
        }

        private void Button_stairs_brown2_Click(object sender, EventArgs e)
        {
            SelectingTile = 11;
            label3.Text = "stairs_brown2";
        }

        private void Button_stairs_brown3_Click(object sender, EventArgs e)
        {
            SelectingTile = 12;
            label3.Text = "stairs_brown3";
        }

        private void Button_fence_Click(object sender, EventArgs e)
        {
            SelectingTile = 13;
            label3.Text = "fence";
        }

        private void Button_flower_Click(object sender, EventArgs e)
        {
            SelectingTile = 14;
            label3.Text = "flower";
        }

        private void Button_flower1_Click(object sender, EventArgs e)
        {
            SelectingTile = 15;
            label3.Text = "flower1";
        }

        private void Button_flower2_Click(object sender, EventArgs e)
        {
            SelectingTile = 16;
            label3.Text = "flower2";
        }

        private void Button_flower3_Click(object sender, EventArgs e)
        {
            SelectingTile = 17;
            label3.Text = "flower3";

        }

        private void Button_flower4_Click(object sender, EventArgs e)
        {
            SelectingTile = 18;
            label3.Text = "flower4";
        }

        private void Button_grass3_Click(object sender, EventArgs e)
        {
            SelectingTile = 19;
            label3.Text = "grass3";
        }

        private void Button_grass4_Click(object sender, EventArgs e)
        {
            SelectingTile = 20;
            label3.Text = "grass4";
        }

        private void Button_grass5_Click(object sender, EventArgs e)
        {
            SelectingTile = 21;
            label3.Text = "grass5";
        }

        private void Button_grass6_Click(object sender, EventArgs e)
        {
            SelectingTile = 22;
            label3.Text = "grass6";
        }

        private void Button_grass7_Click(object sender, EventArgs e)
        {
            SelectingTile = 23;
            label3.Text = "grass7";
        }

        private void Button_stone1_1_Click(object sender, EventArgs e)
        {
            SelectingTile = 24;
            label3.Text = "stone1_1";
        }

        private void Button_stone1_2_Click(object sender, EventArgs e)
        {
            SelectingTile = 25;
            label3.Text = "stone1_2";
        }

        private void Button_stone1_3_Click(object sender, EventArgs e)
        {
            SelectingTile = 26;
            label3.Text = "stone1_3";
        }

        private void Button_stone1_4_Click(object sender, EventArgs e)
        {
            SelectingTile = 27;
            label3.Text = "stone1_4";
        }



        //private void TestDarray_Click(object sender, EventArgs e)
        //{
        //    txtBox = new TextBox[n];
        //    lbl = new Label[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        txtBox[i] = new TextBox();
        //        txtBox[i].Name = "n" + i;
        //        txtBox[i].Text = "n" + i;

        //        lbl[i] = new Label();
        //        lbl[i].Name = "n" + i;
        //        lbl[i].Text = "n" + i;
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        txtBox[i].Visible = true;
        //        lbl[i].Visible = true;
        //        txtBox[i].Location = new Point(40, 50 + space);
        //        lbl[i].Location = new Point(10, 50 + space);
        //        this.Controls.Add(txtBox[i]);
        //        this.Controls.Add(lbl[i]);
        //        space += 50;
        //    }
        //}

        int Row;
        int Column;

        int GetIndex(int Row, int Col)
        {
            return Row * Column + Col;
        }

        //int MaxTiles = Row * Column;

        bool isDown = false;

        private void CreateMap_Click(object sender, EventArgs e)
        {
            CleanPictureBox();
            try
            {
                Row = Convert.ToInt32(Row_Box.Text);
                Column = Convert.ToInt32(Column_Box.Text);
            }
            catch (Exception)
            {

                //throw;
                return;
            }

            int MaxTiles = Row * Column;
            Map = new PictureBox[MaxTiles];

            for (int i = 0; i < MaxTiles; i++)
            {
                Map[i] = new PictureBox();
                var image = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                Map[i].BackgroundImage = image;
                Map[i].BackgroundImage.Tag = "stone";
                Map[i].Width = image.Width; ;
                Map[i].Height = image.Height;
                Map[i].Cursor = Cursors.NoMove2D;

                //Map[i].MouseUp += new MouseEventHandler(ClickTile_unclick);
                //Map[i].MouseDown += new MouseEventHandler(ClickTile_click);
                Map[i].MouseEnter += new EventHandler(ClickTile_over);
                // Map[i].MouseMove += new MouseEventHandler(ClickTile_over);
                Map[i].MouseDown += new MouseEventHandler(Handle_MouseDown_OnMap);
                // Map[i].CursorChanged += new EventHandler(ClickTile_over);
                // Map[i].DragOver += new DragEventHandler(ClickTile_over);
                //Map[i].
                // Map[i].Mouse += new MouseEventHandler(ClickTile_hover);

            }

            for (int row = 0; row < Row; ++row)
            {
                for (int col = 0; col < Column; col++)
                {
                    Point point = new Point(250 + 32 * col, 50 + 32 * row);
                    Map[GetIndex(row, col)].Location = point;
                    this.Controls.Add(Map[GetIndex(row, col)]);
                }
            }




        }

        PictureBox ClickTile = new PictureBox();
        // ClickTile += new EventHandler();



        //private void ClickTile_click(object sender, MouseEventArgs e)
        //{
        //    isDown = true;
        //}

        private void Handle_MouseDown_OnMap(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Control control = (Control)sender;
                if (control.Capture)
                {
                    control.Capture = false;
                }

                PictureBox Box = (PictureBox)(sender);
                switch (SelectingTile)
                {
                    case 1:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                        Box.BackgroundImage.Tag = "stone";

                        break;

                    case 2:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                        Box.BackgroundImage.Tag = "grass";

                        break;

                    case 3:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
                        Box.BackgroundImage.Tag = "grass_2";

                        break;
                    case 4:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_blue.png");
                        Box.BackgroundImage.Tag = "brick_blue";

                        break;

                    case 5:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_brown.png");
                        Box.BackgroundImage.Tag = "brick_brown";

                        break;

                    case 6:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_brown.png");
                        Box.BackgroundImage.Tag = "brick_grail_brown";

                        break;

                    case 7:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_orange.png");
                        Box.BackgroundImage.Tag = "brick_grail_orange";

                        break;

                    case 8:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_white.png");
                        Box.BackgroundImage.Tag = "brick_grail_white";

                        break;

                    case 9:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_yellow.png");
                        Box.BackgroundImage.Tag = "brick_grail_yellow";

                        break;

                    case 10:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown1.png");
                        Box.BackgroundImage.Tag = "stairs_brown1";

                        break;

                    case 11:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown2.png");
                        Box.BackgroundImage.Tag = "stairs_brown2";

                        break;

                    case 12:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown3.png");
                        Box.BackgroundImage.Tag = "stairs_brown3";

                        break;
                    case 13:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "fence.png");
                        Box.BackgroundImage.Tag = "fence";

                        break;
                    case 14:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower.png");
                        Box.BackgroundImage.Tag = "flower";

                        break;
                    case 15:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower1.png");
                        Box.BackgroundImage.Tag = "flower1";

                        break;
                    case 16:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower2.png");
                        Box.BackgroundImage.Tag = "flower2";

                        break;
                    case 17:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower3.png");
                        Box.BackgroundImage.Tag = "flower3";

                        break;
                    case 18:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower4.png");
                        Box.BackgroundImage.Tag = "flower4";

                        break;
                    case 19:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass3.png");
                        Box.BackgroundImage.Tag = "grass3";
                        break;

                    case 20:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass4.png");
                        Box.BackgroundImage.Tag = "grass4";
                        break;

                    case 21:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass5.png");
                        Box.BackgroundImage.Tag = "grass5";
                        break;

                    case 22:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass6.png");
                        Box.BackgroundImage.Tag = "grass6";

                        break;


                    case 23:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass7.png");
                        Box.BackgroundImage.Tag = "grass7";
                        break;
                    case 24:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_1.png");
                        Box.BackgroundImage.Tag = "stone1_1";
                        break;
                    case 25:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_2.png");
                        Box.BackgroundImage.Tag = "stone1_2";
                        break;

                    case 26:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_3.png");
                        Box.BackgroundImage.Tag = "stone1_3";
                        break;

                    case 27:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_4.png");
                        Box.BackgroundImage.Tag = "stone1_4";
                        break;


                }



            }


        }

        private void CleanPictureBox()
        {
            if (Map != null)
            {
                foreach (var tile in Map)
                {
                    this.Controls.Remove(tile);
                }
            }


        }

        private void ClickTile_over(object sender, EventArgs e)
        {
            PictureBox Box = (PictureBox)(sender);

            if (Box.BackgroundImage.Tag == "stone")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "grass")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "grass_2")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "brick_blue")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "brick_brown")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "brick_grail_brown")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }


            if (Box.BackgroundImage.Tag == "brick_grail_orange")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "brick_grail_white")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "brick_grail_yellow")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stairs_brown1")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stairs_brown2")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stairs_brown3")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

//----------------------------------------------------------
            if (Box.BackgroundImage.Tag == "fence")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "flower1")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "flower2")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "flower3")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "flower4")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "grass3")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "grass4")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "grass5")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "grass6")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "grass7")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stone1_1")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }

            if (Box.BackgroundImage.Tag == "stone1_2")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stone1_3")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }
            if (Box.BackgroundImage.Tag == "stone1_4")
            {
                label4.Text = Box.BackgroundImage.Tag.ToString();
            }


            var buttons = MouseButtons;
            if (PictureBox.MouseButtons == MouseButtons.Left)
            {
                isDown = true;
            }
            else { isDown = false; }



            if (isDown)
            {
                switch (SelectingTile)
                {
                    case 1:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                        Box.BackgroundImage.Tag = "stone";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 2:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                        Box.BackgroundImage.Tag = "grass";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 3:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
                        Box.BackgroundImage.Tag = "grass_2";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 4:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_blue.png");
                        Box.BackgroundImage.Tag = "brick_blue";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 5:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_brown.png");
                        Box.BackgroundImage.Tag = "brick_brown";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 6:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_brown.png");
                        Box.BackgroundImage.Tag = "brick_grail_brown";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 7:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_orange.png");
                        Box.BackgroundImage.Tag = "brick_grail_orange";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 8:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_white.png");
                        Box.BackgroundImage.Tag = "brick_grail_white";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 9:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_yellow.png");
                        Box.BackgroundImage.Tag = "brick_grail_yellow";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 10:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown1.png");
                        Box.BackgroundImage.Tag = "stairs_brown1";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 11:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown2.png");
                        Box.BackgroundImage.Tag = "stairs_brown2";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 12:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown3.png");
                        Box.BackgroundImage.Tag = "stairs_brown3";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 13:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "fence.png");
                        Box.BackgroundImage.Tag = "fence";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 14:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower.png");
                        Box.BackgroundImage.Tag = "flower";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 15:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower1.png");
                        Box.BackgroundImage.Tag = "flower1";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 16:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower2.png");
                        Box.BackgroundImage.Tag = "flower2";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 17:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower3.png");
                        Box.BackgroundImage.Tag = "flower3";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 18:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower4.png");
                        Box.BackgroundImage.Tag = "flower4";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 19:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass3.png");
                        Box.BackgroundImage.Tag = "grass3";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 20:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass4.png");
                        Box.BackgroundImage.Tag = "grass4";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 21:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass5.png");
                        Box.BackgroundImage.Tag = "grass5";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 22:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass6.png");
                        Box.BackgroundImage.Tag = "grass6";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;


                    case 23:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass7.png");
                        Box.BackgroundImage.Tag = "grass7";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 24:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_1.png");
                        Box.BackgroundImage.Tag = "stone1_1";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;
                    case 25:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_2.png");
                        Box.BackgroundImage.Tag = "stone1_2";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 26:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_3.png");
                        Box.BackgroundImage.Tag = "stone1_3";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;

                    case 27:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_4.png");
                        Box.BackgroundImage.Tag = "stone1_4";
                        label4.Text = Box.BackgroundImage.Tag.ToString();
                        break;




                }
            }





            //switch (SelectingTile)
            //{
            //	case 1:
            //		Box.BackgroundImage.Tag = "stone";
            //		label4.Text = Box.BackgroundImage.Tag.ToString();
            //		break;

            //	case 2:				
            //		Box.BackgroundImage.Tag = "g";
            //		label4.Text = Box.BackgroundImage.Tag.ToString();
            //		break;

            //	case 3:
            //		Box.BackgroundImage.Tag = "g2";
            //		label4.Text = Box.BackgroundImage.Tag.ToString();
            //		break;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Column_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Row_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            int Row = Convert.ToInt32(Row_Box.Text);
            int Column = Convert.ToInt32(Column_Box.Text);
            int counter = 0;
            data.Clear();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (Stream fileStream = saveFile.OpenFile())
                {
                    StreamWriter writer = new StreamWriter(fileStream);

                    foreach (Control ctl in this.Controls)
                    {

                        if (ctl is PictureBox)//挑选出是按钮类型的
                        {
                            string tiletype = ctl.BackgroundImage.Tag.ToString();
                            switch (tiletype)
                            {
                                case "stone":
                                    data.Add('0');
                                    break;
                                case "grass":
                                    data.Add('1');
                                    break;
                                case "grass_2":
                                    data.Add('2');
                                    break;
                                case "brick_blue":
                                    data.Add('3');
                                    break;
                                case "brick_brown":
                                    data.Add('4');
                                    break;
                                case "brick_grail_brown":
                                    data.Add('5');
                                    break;
                                case "brick_grail_orange":
                                    data.Add('6');
                                    break;
                                case "brick_grail_white":
                                    data.Add('7');
                                    break;
                                case "brick_grail_yellow":
                                    data.Add('8');
                                    break;
                                case "stairs_brown1":
                                    data.Add('9');
                                    break;
                                case "stairs_brown2":
                                    data.Add('A');
                                    break;
                                case "stairs_brown3":
                                    data.Add('B');
                                    break;


                                case "fence":
                                    data.Add('C');
                                    break;
                                case "flower":
                                    data.Add('D');
                                    break;
                                case "flower1":
                                    data.Add('E');
                                    break;
                                case "flower2":
                                    data.Add('F');
                                    break;
                                case "flower3":
                                    data.Add('G');
                                    break;
                                case "flower4":
                                    data.Add('H');
                                    break;
                                case "grass3":
                                    data.Add('I');
                                    break;
                                case "grass4":
                                    data.Add('J');
                                    break;
                                case "grass5":
                                    data.Add('K');
                                    break;
                                case "grass6":
                                    data.Add('L');
                                    break;
                                case "grass7":
                                    data.Add('M');
                                    break;
                                case "stone1_1":
                                    data.Add('N');
                                    break;
                                case "stone1_2":
                                    data.Add('O');
                                    break;
                                case "stone1_3":
                                    data.Add('P');
                                    break;
                                case "stone1_4":
                                    data.Add('Q');
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    writer.WriteLine("Row :");
                    writer.WriteLine(Row);
                    writer.WriteLine("Column :");
                    writer.WriteLine(Column);
                    writer.WriteLine();
                    for (int i = 0; i < data.Count(); i++)
                    {
                        writer.Write(data[i]);
                        counter++;
                        if (counter == Column)
                        {
                            writer.WriteLine();
                            counter = 0;
                        }

                    }
                    writer.Close();
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 0;

            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                CleanPictureBox();
                string line;
                using (Stream fileStream = openFile.OpenFile())
                {
                    StreamReader reader = new StreamReader(fileStream);


                    while ((line = reader.ReadLine()) != null)
                    {
                        loadData.Add(line);

                    }
                    reader.Close();
                }



                Row = Convert.ToInt32(loadData[1]);
                Column = Convert.ToInt32(loadData[3]);



                Map = new PictureBox[Row * Column];
                List<int> DataLoad = new List<int>();

                for (int i = 5; i < loadData.Count(); i++)
                {
                    foreach (char TileNumber in loadData[i])
                    {
                        DataLoad.Add(TileNumber);
                    }
                }

                //listBox1.DataSource = DataLoad;

                int j = 0;
                for (int i = 0; i < Row * Column; i++)
                {

                    Map[i] = new PictureBox();
                    Map[i].MouseEnter += new EventHandler(ClickTile_over);

                    Map[i].MouseDown += new MouseEventHandler(Handle_MouseDown_OnMap);
                    Map[i].Cursor = Cursors.NoMove2D;
                    //-----------------------------------------------------------------------------------------
                    var image0 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                    var image1 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                    var image2 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
                    var image3 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_blue.png");
                    var image4 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_brown.png");
                    var image5 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_brown.png");
                    var image6 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_orange.png");
                    var image7 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_white.png");
                    var image8 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "brick_grail_yellow.png");
                    var image9 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown1.png");
                    var image10 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown2.png");
                    var image11 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stairs_brown3.png");

                    var image12= Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "fence.png");
                    var image13 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower.png");
                    var image14 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower1.png");
                    var image15 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower2.png");
                    var image16 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower3.png");
                    var image17 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "flower4.png");
                    var image18 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass3.png");
                    var image19 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass4.png");
                    var image20 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass5.png");
                    var image21 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass6.png");
                    var image22 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass7.png");
                    var image23 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_1.png");
                    var image24 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_2.png");
                    var image25 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_3.png");
                    var image26 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone1_4.png");





                    //-----------------------------------------------------------------------------------------

                    switch (DataLoad[j])
                    {
                        case '0':
                            Map[i].BackgroundImage = image0;
                            Map[i].Width = image0.Width; ;
                            Map[i].Height = image0.Height;
                            Map[i].BackgroundImage.Tag = "stone";
                            break;

                        case '1':
                            Map[i].BackgroundImage = image1;
                            Map[i].Width = image1.Width; ;
                            Map[i].Height = image1.Height;
                            Map[i].BackgroundImage.Tag = "grass";
                            break;

                        case '2':
                            Map[i].BackgroundImage = image2;
                            Map[i].Width = image2.Width; ;
                            Map[i].Height = image2.Height;
                            Map[i].BackgroundImage.Tag = "grass_2";
                            break;
                        case '3':
                            Map[i].BackgroundImage = image3;
                            Map[i].Width = image3.Width; ;
                            Map[i].Height = image3.Height;
                            Map[i].BackgroundImage.Tag = "brick_blue";
                            break;
                        case '4':
                            Map[i].BackgroundImage = image4;
                            Map[i].Width = image4.Width; ;
                            Map[i].Height = image4.Height;
                            Map[i].BackgroundImage.Tag = "brick_brown";
                            break;
                        case '5':
                            Map[i].BackgroundImage = image5;
                            Map[i].Width = image5.Width; ;
                            Map[i].Height = image5.Height;
                            Map[i].BackgroundImage.Tag = "brick_grail_brown";
                            break;
                        case '6':
                            Map[i].BackgroundImage = image6;
                            Map[i].Width = image6.Width; ;
                            Map[i].Height = image6.Height;
                            Map[i].BackgroundImage.Tag = "brick_grail_orange";
                            break;
                        case '7':
                            Map[i].BackgroundImage = image7;
                            Map[i].Width = image7.Width; ;
                            Map[i].Height = image7.Height;
                            Map[i].BackgroundImage.Tag = "brick_grail_white";
                            break;
                        case '8':
                            Map[i].BackgroundImage = image8;
                            Map[i].Width = image8.Width; ;
                            Map[i].Height = image8.Height;
                            Map[i].BackgroundImage.Tag = "brick_grail_yellow";
                            break;
                        case '9':
                            Map[i].BackgroundImage = image9;
                            Map[i].Width = image9.Width; ;
                            Map[i].Height = image9.Height;
                            Map[i].BackgroundImage.Tag = "stairs_brown1";
                            break;

                        case 'A':
                            Map[i].BackgroundImage = image10;
                            Map[i].Width = image10.Width; ;
                            Map[i].Height = image10.Height;
                            Map[i].BackgroundImage.Tag = "stairs_brown2";
                            break;
                        case 'B':
                            Map[i].BackgroundImage = image11;
                            Map[i].Width = image11.Width; ;
                            Map[i].Height = image11.Height;
                            Map[i].BackgroundImage.Tag = "stairs_brown3";
                            break;




                        case 'C':
                            Map[i].BackgroundImage = image12;
                            Map[i].Width = image12.Width; ;
                            Map[i].Height = image12.Height;
                            Map[i].BackgroundImage.Tag = "fence";
                            break;
                        case 'D':
                            Map[i].BackgroundImage = image13;
                            Map[i].Width = image13.Width; ;
                            Map[i].Height = image13.Height;
                            Map[i].BackgroundImage.Tag = "flower";
                            break;
                        case 'E':
                            Map[i].BackgroundImage = image14;
                            Map[i].Width = image14.Width; ;
                            Map[i].Height = image14.Height;
                            Map[i].BackgroundImage.Tag = "flower1";
                            break;
                        case 'F':
                            Map[i].BackgroundImage = image15;
                            Map[i].Width = image15.Width; ;
                            Map[i].Height = image15.Height;
                            Map[i].BackgroundImage.Tag = "flower2";
                            break;
                        case 'G':
                            Map[i].BackgroundImage = image16;
                            Map[i].Width = image16.Width; ;
                            Map[i].Height = image16.Height;
                            Map[i].BackgroundImage.Tag = "flower3";
                            break;
                        case 'H':
                            Map[i].BackgroundImage = image17;
                            Map[i].Width = image17.Width; ;
                            Map[i].Height = image17.Height;
                            Map[i].BackgroundImage.Tag = "flower4";
                            break;
                        case 'I':
                            Map[i].BackgroundImage = image18;
                            Map[i].Width = image18.Width; ;
                            Map[i].Height = image18.Height;
                            Map[i].BackgroundImage.Tag = "grass3";
                            break;
                        case 'J':
                            Map[i].BackgroundImage = image19;
                            Map[i].Width = image19.Width; ;
                            Map[i].Height = image19.Height;
                            Map[i].BackgroundImage.Tag = "grass4";
                            break;
                        case 'K':
                            Map[i].BackgroundImage = image20;
                            Map[i].Width = image20.Width; ;
                            Map[i].Height = image20.Height;
                            Map[i].BackgroundImage.Tag = "grass5";
                            break;
                        case 'L':
                            Map[i].BackgroundImage = image21;
                            Map[i].Width = image21.Width; ;
                            Map[i].Height = image21.Height;
                            Map[i].BackgroundImage.Tag = "grass6";
                            break;
                        case 'M':
                            Map[i].BackgroundImage = image22;
                            Map[i].Width = image22.Width; ;
                            Map[i].Height = image22.Height;
                            Map[i].BackgroundImage.Tag = "grass7";
                            break;
                        case 'N':
                            Map[i].BackgroundImage = image23;
                            Map[i].Width = image23.Width; ;
                            Map[i].Height = image23.Height;
                            Map[i].BackgroundImage.Tag = "stone1_1";
                            break;
                        case 'O':
                            Map[i].BackgroundImage = image24;
                            Map[i].Width = image24.Width; ;
                            Map[i].Height = image24.Height;
                            Map[i].BackgroundImage.Tag = "stone1_2";
                            break;
                        case 'P':
                            Map[i].BackgroundImage = image25;
                            Map[i].Width = image25.Width; ;
                            Map[i].Height = image25.Height;
                            Map[i].BackgroundImage.Tag = "stone1_3";
                            break;
                        case 'Q':
                            Map[i].BackgroundImage = image26;
                            Map[i].Width = image26.Width; ;
                            Map[i].Height = image26.Height;
                            Map[i].BackgroundImage.Tag = "stone1_4";
                            break;






                    }
                    j++;
                }

                for (int row = 0; row < Row; ++row)
                {
                    for (int col = 0; col < Column; col++)
                    {
                        Point point = new Point(250 + 32 * col, 50 + 32 * row);
                        Map[GetIndex(row, col)].Location = point;
                        this.Controls.Add(Map[GetIndex(row, col)]);
                    }
                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

    }
    
	//:D
}
