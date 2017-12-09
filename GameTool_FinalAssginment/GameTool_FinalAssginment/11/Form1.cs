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
using System.IO;



namespace _11
{
    public partial class Form1 : Form
    {

        //-------------------------------------
        TextBox[] txtBox;
        Label[] lbl;
		List<int> data=new List<int>();
		
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

		int MouseTile;


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
				Map[i].BackgroundImage.Tag = "stone";
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
                    Point point = new Point(200 + 32 * col, 50 + 32 * row);
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
									data.Add(0);
									break;
								case "grass":
									data.Add(1);
									break;
								case "grass_2":
									data.Add(2);
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
						if (counter==Column)
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
						DataLoad.Add(Convert.ToInt32(TileNumber));
					}
				}

				//listBox1.DataSource = DataLoad;

				int j = 0;
				for (int i = 0; i < Row * Column; i++)
				{
					
					Map[i] = new PictureBox();
					Map[i].MouseEnter += new EventHandler(ClickTile_over);
					Map[i].MouseDown += new MouseEventHandler(Handle_MouseDown_OnMap);
					var image0 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "stone.png");
					var image1 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass.png");
					var image2 = Image.FromFile(Application.StartupPath + "\\TilesForNow\\" + "grass_2.png");

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
					}
					j++;
				}

				for (int row = 0; row < Row; ++row)
				{
					for (int col = 0; col < Column; col++)
					{
						Point point = new Point(200 + 32 * col, 50 + 32 * row);
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
	}
    

}
