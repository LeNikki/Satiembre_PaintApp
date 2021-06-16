
namespace Satiembre_Paint
{
    partial class Satiembre_Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satiembre_Paint));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ColorPick = new System.Windows.Forms.Button();
            this.FillColor = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScale1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.astridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_color = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Erase = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(580, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(103, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Tag = "Brush Size";
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ColorPick
            // 
            this.ColorPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.ColorPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorPick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ColorPick.Location = new System.Drawing.Point(1014, 18);
            this.ColorPick.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPick.Name = "ColorPick";
            this.ColorPick.Size = new System.Drawing.Size(68, 46);
            this.ColorPick.TabIndex = 2;
            this.ColorPick.Text = "Color Pick";
            this.ColorPick.UseVisualStyleBackColor = false;
            this.ColorPick.Click += new System.EventHandler(this.ColorPick_Click);
            // 
            // FillColor
            // 
            this.FillColor.AutoSize = true;
            this.FillColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FillColor.Location = new System.Drawing.Point(719, 49);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(91, 22);
            this.FillColor.TabIndex = 5;
            this.FillColor.Text = "Fill Shape";
            this.FillColor.UseVisualStyleBackColor = true;
            this.FillColor.CheckedChanged += new System.EventHandler(this.FillColor_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.openToolStripMenuItem.Text = "Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.BlueViolet;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScale1ToolStripMenuItem,
            this.invertColorToolStripMenuItem,
            this.antiqueToolStripMenuItem,
            this.roseToolStripMenuItem,
            this.astridToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.editToolStripMenuItem.Text = "Filters";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // grayScale1ToolStripMenuItem
            // 
            this.grayScale1ToolStripMenuItem.Name = "grayScale1ToolStripMenuItem";
            this.grayScale1ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.grayScale1ToolStripMenuItem.Text = "Grayscale";
            this.grayScale1ToolStripMenuItem.Click += new System.EventHandler(this.grayScale1ToolStripMenuItem_Click);
            // 
            // invertColorToolStripMenuItem
            // 
            this.invertColorToolStripMenuItem.Name = "invertColorToolStripMenuItem";
            this.invertColorToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.invertColorToolStripMenuItem.Text = "Invert Color";
            this.invertColorToolStripMenuItem.Click += new System.EventHandler(this.invertColorToolStripMenuItem_Click);
            // 
            // antiqueToolStripMenuItem
            // 
            this.antiqueToolStripMenuItem.Name = "antiqueToolStripMenuItem";
            this.antiqueToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.antiqueToolStripMenuItem.Text = "Antique";
            this.antiqueToolStripMenuItem.Click += new System.EventHandler(this.antiqueToolStripMenuItem_Click_1);
            // 
            // roseToolStripMenuItem
            // 
            this.roseToolStripMenuItem.Name = "roseToolStripMenuItem";
            this.roseToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.roseToolStripMenuItem.Text = "Rose";
            this.roseToolStripMenuItem.Click += new System.EventHandler(this.roseToolStripMenuItem_Click);
            // 
            // astridToolStripMenuItem
            // 
            this.astridToolStripMenuItem.Name = "astridToolStripMenuItem";
            this.astridToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.astridToolStripMenuItem.Text = "Astrid";
            this.astridToolStripMenuItem.Click += new System.EventHandler(this.astridToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.Pic_color);
            this.panel1.Controls.Add(this.Rectangle);
            this.panel1.Controls.Add(this.ColorPick);
            this.panel1.Controls.Add(this.Triangle);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.Circle);
            this.panel1.Controls.Add(this.Pen);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Erase);
            this.panel1.Controls.Add(this.FillColor);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 74);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pic_color
            // 
            this.Pic_color.Location = new System.Drawing.Point(745, 12);
            this.Pic_color.Name = "Pic_color";
            this.Pic_color.Size = new System.Drawing.Size(40, 33);
            this.Pic_color.TabIndex = 12;
            this.Pic_color.UseVisualStyleBackColor = true;
            this.Pic_color.Click += new System.EventHandler(this.Pic_color_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rectangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rectangle.Image = global::Satiembre_Paint.Properties.Resources._191748846_220488589887035_6163318004700879953_n;
            this.Rectangle.Location = new System.Drawing.Point(448, 7);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(0);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(81, 57);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Triangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Triangle.Image = global::Satiembre_Paint.Properties.Resources._189546064_412095906423812_6198873072755434592_n;
            this.Triangle.Location = new System.Drawing.Point(373, 7);
            this.Triangle.Margin = new System.Windows.Forms.Padding(0);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 57);
            this.Triangle.TabIndex = 7;
            this.Triangle.Text = "Triangle";
            this.Triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Line.Image = global::Satiembre_Paint.Properties.Resources._186548113_3743692679069211_4669567928535559626_n;
            this.Line.Location = new System.Drawing.Point(222, 7);
            this.Line.Margin = new System.Windows.Forms.Padding(0);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(77, 57);
            this.Line.TabIndex = 10;
            this.Line.Text = "Line";
            this.Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Circle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Circle.Image = global::Satiembre_Paint.Properties.Resources._188016031_543506233313438_6390659292009122319_n;
            this.Circle.Location = new System.Drawing.Point(299, 7);
            this.Circle.Margin = new System.Windows.Forms.Padding(0);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(74, 57);
            this.Circle.TabIndex = 6;
            this.Circle.Text = "Circle";
            this.Circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Circle.UseVisualStyleBackColor = false;
            this.Circle.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // Pen
            // 
            this.Pen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pen.Image = global::Satiembre_Paint.Properties.Resources._192072082_4200202566692895_6572594018481988789_n;
            this.Pen.Location = new System.Drawing.Point(150, 7);
            this.Pen.Margin = new System.Windows.Forms.Padding(0);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(72, 57);
            this.Pen.TabIndex = 3;
            this.Pen.Text = "Pen";
            this.Pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pen.UseVisualStyleBackColor = false;
            this.Pen.BackColorChanged += new System.EventHandler(this.selectedShape_Click);
            this.Pen.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Satiembre_Paint.Properties.Resources.Palette;
            this.pictureBox1.Location = new System.Drawing.Point(862, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Erase
            // 
            this.Erase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Erase.Image = global::Satiembre_Paint.Properties.Resources._195867770_262270899008775_5609039601681739000_n;
            this.Erase.Location = new System.Drawing.Point(81, 7);
            this.Erase.Margin = new System.Windows.Forms.Padding(0);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(69, 57);
            this.Erase.TabIndex = 11;
            this.Erase.Text = "Erase";
            this.Erase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Erase.UseVisualStyleBackColor = false;
            this.Erase.Click += new System.EventHandler(this.selectedShape_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Image = global::Satiembre_Paint.Properties.Resources._190807460_330606035109558_2827256189491838632_n;
            this.Clear.Location = new System.Drawing.Point(9, 7);
            this.Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(72, 57);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.MainPicbox);
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 377);
            this.panel2.TabIndex = 13;
            // 
            // MainPicbox
            // 
            this.MainPicbox.BackColor = System.Drawing.Color.White;
            this.MainPicbox.Location = new System.Drawing.Point(9, 3);
            this.MainPicbox.Margin = new System.Windows.Forms.Padding(0);
            this.MainPicbox.Name = "MainPicbox";
            this.MainPicbox.Size = new System.Drawing.Size(1103, 374);
            this.MainPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainPicbox.TabIndex = 0;
            this.MainPicbox.TabStop = false;
            this.MainPicbox.Click += new System.EventHandler(this.MainPicbox_Click);
            this.MainPicbox.MouseHover += new System.EventHandler(this.MainPicbox_Click);
            // 
            // Satiembre_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1121, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Satiembre_Paint";
            this.Text = "Satiembre_Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadPicbox_FormClosing);
            this.Load += new System.EventHandler(this.Satiembre_Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPicbox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ColorPick;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.CheckBox FillColor;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColorToolStripMenuItem;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pic_color;
        private System.Windows.Forms.ToolStripMenuItem grayScale1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem astridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
    }
}

