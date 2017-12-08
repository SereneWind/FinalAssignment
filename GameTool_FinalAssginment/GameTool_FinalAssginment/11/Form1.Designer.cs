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
            this.Button_Stone = new System.Windows.Forms.Button();
            this.Button_Grass_Green = new System.Windows.Forms.Button();
            this.Button_Grass_Brown = new System.Windows.Forms.Button();
            this.CreateMap = new System.Windows.Forms.Button();
            this.Column_Box = new System.Windows.Forms.TextBox();
            this.Row_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_brick_grail_white = new System.Windows.Forms.Button();
            this.Button_brick_grail_orange = new System.Windows.Forms.Button();
            this.Button_brick_grail_brown = new System.Windows.Forms.Button();
            this.Button_brick_brown = new System.Windows.Forms.Button();
            this.Button_brick_blue = new System.Windows.Forms.Button();
            this.Button_Grass_Brown = new System.Windows.Forms.Button();
            this.Button_Grass_Green = new System.Windows.Forms.Button();
            this.Button_Stone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateMap
            // 
            this.CreateMap.Location = new System.Drawing.Point(49, 378);
            this.CreateMap.Name = "CreateMap";
            this.CreateMap.Size = new System.Drawing.Size(75, 23);
            this.CreateMap.TabIndex = 9;
            this.CreateMap.Text = "Map";
            this.CreateMap.UseVisualStyleBackColor = true;
            this.CreateMap.Click += new System.EventHandler(this.CreateMap_Click);
            // 
            // Column_Box
            // 
            this.Column_Box.Location = new System.Drawing.Point(88, 286);
            this.Column_Box.Name = "Column_Box";
            this.Column_Box.Size = new System.Drawing.Size(58, 20);
            this.Column_Box.TabIndex = 10;
            this.Column_Box.TextChanged += new System.EventHandler(this.Column_Box_TextChanged);
            // 
            // Row_Box
            // 
            this.Row_Box.Location = new System.Drawing.Point(88, 328);
            this.Row_Box.Name = "Row_Box";
            this.Row_Box.Size = new System.Drawing.Size(58, 20);
            this.Row_Box.TabIndex = 11;
            this.Row_Box.TextChanged += new System.EventHandler(this.Row_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Row";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(49, 418);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 14;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(49, 456);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(75, 23);
            this.Load_Button.TabIndex = 15;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Material";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "CurrentMaterial";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Button_brick_grail_white
            // 
            this.Button_brick_grail_white.BackgroundImage = global::_11.Properties.Resources.brick_grail_white;
            this.Button_brick_grail_white.Location = new System.Drawing.Point(145, 71);
            this.Button_brick_grail_white.Name = "Button_brick_grail_white";
            this.Button_brick_grail_white.Size = new System.Drawing.Size(33, 32);
            this.Button_brick_grail_white.TabIndex = 22;
            this.Button_brick_grail_white.UseVisualStyleBackColor = true;
            this.Button_brick_grail_white.Click += new System.EventHandler(this.Button_brick_grail_white_Click);
            // 
            // Button_brick_grail_orange
            // 
            this.Button_brick_grail_orange.BackgroundImage = global::_11.Properties.Resources.brick_grail_orange;
            this.Button_brick_grail_orange.Location = new System.Drawing.Point(107, 71);
            this.Button_brick_grail_orange.Name = "Button_brick_grail_orange";
            this.Button_brick_grail_orange.Size = new System.Drawing.Size(32, 32);
            this.Button_brick_grail_orange.TabIndex = 21;
            this.Button_brick_grail_orange.UseVisualStyleBackColor = true;
            this.Button_brick_grail_orange.Click += new System.EventHandler(this.Button_brick_grail_orange_Click);
            // 
            // Button_brick_grail_brown
            // 
            this.Button_brick_grail_brown.BackgroundImage = global::_11.Properties.Resources.brick_grail_brown;
            this.Button_brick_grail_brown.Location = new System.Drawing.Point(69, 71);
            this.Button_brick_grail_brown.Name = "Button_brick_grail_brown";
            this.Button_brick_grail_brown.Size = new System.Drawing.Size(32, 32);
            this.Button_brick_grail_brown.TabIndex = 20;
            this.Button_brick_grail_brown.UseVisualStyleBackColor = true;
            this.Button_brick_grail_brown.Click += new System.EventHandler(this.Button_brick_grail_brown_Click);
            // 
            // Button_brick_brown
            // 
            this.Button_brick_brown.BackgroundImage = global::_11.Properties.Resources.brick_brown;
            this.Button_brick_brown.Location = new System.Drawing.Point(31, 71);
            this.Button_brick_brown.Name = "Button_brick_brown";
            this.Button_brick_brown.Size = new System.Drawing.Size(32, 32);
            this.Button_brick_brown.TabIndex = 19;
            this.Button_brick_brown.UseVisualStyleBackColor = true;
            this.Button_brick_brown.Click += new System.EventHandler(this.Button_brick_brown_Click);
            // 
            // Button_brick_blue
            // 
            this.Button_brick_blue.BackgroundImage = global::_11.Properties.Resources.brick_blue;
            this.Button_brick_blue.Location = new System.Drawing.Point(145, 33);
            this.Button_brick_blue.Name = "Button_brick_blue";
            this.Button_brick_blue.Size = new System.Drawing.Size(33, 32);
            this.Button_brick_blue.TabIndex = 18;
            this.Button_brick_blue.UseVisualStyleBackColor = true;
            this.Button_brick_blue.Click += new System.EventHandler(this.Button_brick_blue_Click);
            // 
            // Button_Grass_Brown
            // 
            this.Button_Grass_Brown.BackgroundImage = global::_11.Properties.Resources.grass_2;
            this.Button_Grass_Brown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Grass_Brown.Location = new System.Drawing.Point(107, 33);
            this.Button_Grass_Brown.Name = "Button_Grass_Brown";
            this.Button_Grass_Brown.Size = new System.Drawing.Size(32, 32);
            this.Button_Grass_Brown.TabIndex = 7;
            this.Button_Grass_Brown.UseVisualStyleBackColor = true;
            this.Button_Grass_Brown.Click += new System.EventHandler(this.Button_Grass_Brown_Click);
            // 
            // Button_Grass_Green
            // 
            this.Button_Grass_Green.BackgroundImage = global::_11.Properties.Resources.grass;
            this.Button_Grass_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Grass_Green.Location = new System.Drawing.Point(69, 33);
            this.Button_Grass_Green.Name = "Button_Grass_Green";
            this.Button_Grass_Green.Size = new System.Drawing.Size(32, 32);
            this.Button_Grass_Green.TabIndex = 6;
            this.Button_Grass_Green.UseVisualStyleBackColor = true;
            this.Button_Grass_Green.Click += new System.EventHandler(this.Button_Grass_Green_Click);
            // 
            // Button_Stone
            // 
            this.Button_Stone.BackgroundImage = global::_11.Properties.Resources.stone;
            this.Button_Stone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Stone.Location = new System.Drawing.Point(31, 33);
            this.Button_Stone.Name = "Button_Stone";
            this.Button_Stone.Size = new System.Drawing.Size(32, 32);
            this.Button_Stone.TabIndex = 5;
            this.Button_Stone.UseVisualStyleBackColor = true;
            this.Button_Stone.Click += new System.EventHandler(this.Button_Stone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 513);
            this.Controls.Add(this.Button_brick_grail_white);
            this.Controls.Add(this.Button_brick_grail_orange);
            this.Controls.Add(this.Button_brick_grail_brown);
            this.Controls.Add(this.Button_brick_brown);
            this.Controls.Add(this.Button_brick_blue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Row_Box);
            this.Controls.Add(this.Column_Box);
            this.Controls.Add(this.CreateMap);
            this.Controls.Add(this.Button_Grass_Brown);
            this.Controls.Add(this.Button_Grass_Green);
            this.Controls.Add(this.Button_Stone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Stone;
        private System.Windows.Forms.Button Button_Grass_Green;
        private System.Windows.Forms.Button Button_Grass_Brown;
        private System.Windows.Forms.Button CreateMap;
        private System.Windows.Forms.TextBox Column_Box;
        private System.Windows.Forms.TextBox Row_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Load_Button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_brick_blue;
        private System.Windows.Forms.Button Button_brick_brown;
        private System.Windows.Forms.Button Button_brick_grail_brown;
        private System.Windows.Forms.Button Button_brick_grail_orange;
        private System.Windows.Forms.Button Button_brick_grail_white;
    }
}

