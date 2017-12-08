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
<<<<<<< Updated upstream
        }




=======
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
            SelectingTile =7;
            label3.Text = "brick_grail_orange";
        }

        private void Button_brick_grail_white_Click(object sender, EventArgs e)
        {
            SelectingTile = 8;
            label3.Text = "brick_grail_white";
        }
>>>>>>> Stashed changes

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
            Row = Convert.ToInt32(Row_Box.Text);
            Column = Convert.ToInt32(Column_Box.Text);

            int MaxTiles = Row * Column;
            Map = new PictureBox[MaxTiles];

            for (int i = 0; i < MaxTiles; i++)
            {
                Map[i] = new PictureBox();
                var image = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
                Map[i].BackgroundImage = image;
                Map[i].Width = image.Width; ;
                Map[i].Height = image.Height;


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
                    Point point = new Point(400 + 32 * col, 50 + 32 * row);
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
                        break;

                    case 2:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                        break;

                    case 3:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
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
                }



            }


        }

        private void CleanPictureBox()
        {
            //foreach (System.Windows.Forms.Control control in this.Controls)
            //{
            //    if (control is System.Windows.Forms.PictureBox)
            //    {

            //        System.Windows.Forms.PictureBox picturebox = (System.Windows.Forms.PictureBox)control;
            //        this.Controls.Remove(picturebox);
            //    }
            //}

            foreach (Control ctl in this.Controls) 
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                  this.Controls.Remove(ctl);  
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox)//挑选出是按钮类型的
                {
                    this.Controls.Remove(ctl);
                }
            }


            //foreach (Control con in this.Controls)
            //{
            //    if (con.GetType().ToString() == "System.windows.forms.PictureBox")
            //        this.Controls.Remove((con));
            //}
        }


        private void ClickTile_over(object sender, EventArgs e)
        {


            PictureBox Box = (PictureBox)(sender);

<<<<<<< Updated upstream
=======
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

>>>>>>> Stashed changes
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
                        break;

                    case 2:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
                        break;

                    case 3:
                        Box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");
<<<<<<< Updated upstream
                        break;
=======
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
>>>>>>> Stashed changes

                }
        }
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
            //foreach (Control ctl in this.Controls)
            //{
            //    if (ctl is PictureBox)//挑选出是按钮类型的
            //    {
            //        SaveFileDialog saveFile = new SaveFileDialog();
            //        saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //        DialogResult result = saveFile.ShowDialog();

            //        if (result == DialogResult.OK)
            //        {
            //            using (Stream fileStream = saveFile.OpenFile())
            //            {
            //                StreamWriter writer = new StreamWriter(fileStream);

            //                if (true)
            //                {
            //                    ctl.BackgroundImage == Image."stone.png";
            //                }
                            


            //                List<string> data = 
            //                foreach (var line in data)
            //                {
            //                    writer.WriteLine(line);
            //                }
            //                writer.Close();
            //            }
            //        }
            //    }
            //}
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}


>>>>>>> Stashed changes
    }
    
    //    private void ClickTile_hover(object sender, MouseEventArgs e)
    //    {
            


    //}
}
