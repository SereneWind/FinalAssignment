namespace _11
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Button_Stone = new System.Windows.Forms.Button();
            this.Button_Grass_Green = new System.Windows.Forms.Button();
            this.Button_Grass_Brown = new System.Windows.Forms.Button();
            this.TestDarray = new System.Windows.Forms.Button();
            this.CreateMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // Button_Stone
            // 
            this.Button_Stone.BackgroundImage = global::_11.Properties.Resources.stone;
            this.Button_Stone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Stone.Location = new System.Drawing.Point(32, 64);
            this.Button_Stone.Name = "Button_Stone";
            this.Button_Stone.Size = new System.Drawing.Size(32, 32);
            this.Button_Stone.TabIndex = 5;
            this.Button_Stone.UseVisualStyleBackColor = true;
            this.Button_Stone.Click += new System.EventHandler(this.Button_Stone_Click);
            // 
            // Button_Grass_Green
            // 
            this.Button_Grass_Green.BackgroundImage = global::_11.Properties.Resources.grass;
            this.Button_Grass_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Grass_Green.Location = new System.Drawing.Point(71, 64);
            this.Button_Grass_Green.Name = "Button_Grass_Green";
            this.Button_Grass_Green.Size = new System.Drawing.Size(32, 32);
            this.Button_Grass_Green.TabIndex = 6;
            this.Button_Grass_Green.UseVisualStyleBackColor = true;
            this.Button_Grass_Green.Click += new System.EventHandler(this.Button_Grass_Green_Click);
            // 
            // Button_Grass_Brown
            // 
            this.Button_Grass_Brown.BackgroundImage = global::_11.Properties.Resources.grass_2;
            this.Button_Grass_Brown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Grass_Brown.Location = new System.Drawing.Point(110, 64);
            this.Button_Grass_Brown.Name = "Button_Grass_Brown";
            this.Button_Grass_Brown.Size = new System.Drawing.Size(32, 32);
            this.Button_Grass_Brown.TabIndex = 7;
            this.Button_Grass_Brown.UseVisualStyleBackColor = true;
            this.Button_Grass_Brown.Click += new System.EventHandler(this.Button_Grass_Brown_Click);
            // 
            // TestDarray
            // 
            this.TestDarray.Location = new System.Drawing.Point(28, 432);
            this.TestDarray.Name = "TestDarray";
            this.TestDarray.Size = new System.Drawing.Size(75, 23);
            this.TestDarray.TabIndex = 8;
            this.TestDarray.Text = "button1";
            this.TestDarray.UseVisualStyleBackColor = true;
            this.TestDarray.Click += new System.EventHandler(this.TestDarray_Click);
            // 
            // CreateMap
            // 
            this.CreateMap.Location = new System.Drawing.Point(32, 357);
            this.CreateMap.Name = "CreateMap";
            this.CreateMap.Size = new System.Drawing.Size(75, 23);
            this.CreateMap.TabIndex = 9;
            this.CreateMap.Text = "Map";
            this.CreateMap.UseVisualStyleBackColor = true;
            this.CreateMap.Click += new System.EventHandler(this.CreateMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 513);
            this.Controls.Add(this.CreateMap);
            this.Controls.Add(this.TestDarray);
            this.Controls.Add(this.Button_Grass_Brown);
            this.Controls.Add(this.Button_Grass_Green);
            this.Controls.Add(this.Button_Stone);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Button_Stone;
        private System.Windows.Forms.Button Button_Grass_Green;
        private System.Windows.Forms.Button Button_Grass_Brown;
        private System.Windows.Forms.Button TestDarray;
        private System.Windows.Forms.Button CreateMap;
    }
}

