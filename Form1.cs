 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;  //for graphics path
using System.Drawing.Imaging;

namespace Satiembre_Paint
{
    public partial class Satiembre_Paint : Form
    {
        Bitmap paintImage;  //the layer where our paint goes
        Graphics paintGraphics;  //pen graphics
        Bitmap workingImage;    //the canvas layer
        Graphics workingGraphics;  //canvas graphics
        Point lastpoint, currentpoint;
        bool mousedown = false;
        Button selectedShape; // to know which shape is currently drawing 
        ColorDialog colorPick = new ColorDialog();  //pick colors
        string shape = ""; //will hold what shape is clicked
        Image i; //image layer
        Bitmap b; //image layer
        Color new_color;
        bool file; //if file is opened
        Graphics g;
        
        public Satiembre_Paint()
        {
            InitializeComponent();
            LoadPicbox();
            shape = "Pen"; // sets pen by default
            g = this.CreateGraphics();
        }
        private void LoadPicbox()
        {
            int width = MainPicbox.Width;
            int height = MainPicbox.Height;

            paintImage = new Bitmap(width, height);
            paintGraphics = Graphics.FromImage(paintImage);

            MainPicbox.Image = paintImage;
            MainPicbox.MouseDown += new MouseEventHandler(MainPicbox_MouseDown);
            MainPicbox.MouseMove += new MouseEventHandler(MainPicbox_MouseMove);
            MainPicbox.MouseUp += new MouseEventHandler(MainPicbox_MouseUp);
        }
        private void LoadPicbox_FormClosing(object sender, FormClosingEventArgs e) //Exit Button Warning 
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //application closes 
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void selectedShape_Click(object sender, EventArgs e)
        //event for each shape and pen 
        {
            Button bt = (Button)sender;
            shape = bt.Text;
        }
        void MainPicbox_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = e.Location;
            mousedown = true;
        }
        void MainPicbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                if (shape == "Pen")//for pen
                {
                    DrawLine(e.Location);
                }
                else if (shape == "Erase")
                {
                    Pen erase = new Pen(Color.White, trackBar1.Value);
                    currentpoint = e.Location;
                    paintGraphics.DrawLine(erase, currentpoint, lastpoint);
                    lastpoint = currentpoint;
                    MainPicbox.Refresh();
                }
                else  //for shape
                {
                    DrawShape(e.Location);
                }
            }
        }
        void MainPicbox_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
            if (shape != "Pen")
            {
                DrawShape(e.Location);
                paintImage = new Bitmap(workingImage);

                //Reinitialize graphics object as the bitmap is new
                paintGraphics = Graphics.FromImage(paintImage);
                MainPicbox.Image = paintImage;
            }
        }
        private void ColorPick_Click(object sender, EventArgs e) //color pick button
        {
            colorPick.ShowDialog(); //shows color options
        }
        private void Clear_Click(object sender, EventArgs e)
        //clears the whole canvas
        {
            Graphics g = Graphics.FromImage(paintImage);
            g.Clear(Color.White);
            MainPicbox.Refresh();  //need refresh fo clear screen
        }
        private void DrawLine(Point currentpoint)
        {
            this.currentpoint = currentpoint;
            //for the color picker and size of the pen
            Pen pen = new Pen(colorPick.Color, trackBar1.Value);
            
            
            paintGraphics.DrawLine(pen, lastpoint, currentpoint);
            lastpoint = currentpoint;
            MainPicbox.Refresh();
        }

        private void DrawShape(Point currentpoint)
        {
            this.currentpoint = currentpoint;
            //for the color picker and size of the pen
            Pen pen = new Pen(colorPick.Color, trackBar1.Value);
   
            workingImage = new Bitmap(paintImage);
            workingGraphics = Graphics.FromImage(workingImage);

            int startpointX = lastpoint.X < currentpoint.X ? lastpoint.X : currentpoint.X;
            int startpointY = lastpoint.Y < currentpoint.Y ? lastpoint.Y : currentpoint.Y;

            int shapewidth = (lastpoint.X > currentpoint.X ? lastpoint.X : currentpoint.X) - startpointX;
            int shapeheight = (lastpoint.Y > currentpoint.Y ? lastpoint.Y : currentpoint.Y) - startpointY;

            switch (shape)
            {
                case "Rectangle":
                    //Check if it is to draw or fill shape 
                    if (!FillColor.Checked)
                    {
                        //draw rectangle 
                        workingGraphics.DrawRectangle(pen, startpointX, startpointY, shapewidth, shapeheight);
                    }
                    else
                    {
                        //Fill rectangle 
                        workingGraphics.FillRectangle(pen.Brush, startpointX, startpointY, shapewidth, shapeheight);
                    } break;
                case "Circle":
                    //Check if it is to draw or fill shape 
                    if (!FillColor.Checked)
                    {
                        //draw circle
                        workingGraphics.DrawEllipse(pen, startpointX, startpointY, shapewidth, shapeheight);
                    }
                    else
                    {
                        //Fill circle
                        workingGraphics.FillEllipse(pen.Brush, startpointX, startpointY, shapewidth, shapeheight);
                    }
                    break;
                case "Triangle":
                    Point point1 = new Point() { X = startpointX, Y = startpointY + shapeheight };
                    Point point2 = new Point() { X = startpointX + (shapewidth / 2), Y = startpointY };
                    Point point3 = new Point() { X = startpointX + shapewidth, Y = startpointY + shapeheight };
                    if (!FillColor.Checked)
                    {
                        workingGraphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    }
                    else
                    {
                        workingGraphics.FillPolygon(pen.Brush, new Point[] { point1, point2, point3 });
                    }
                    break;
                case "Line":

                    workingGraphics.DrawLine(pen, lastpoint, currentpoint);
                    break;
            }
            //The outline should be shown only if it is not a line and the drawing is on. 
            if (mousedown && shape != "Line")
            {
                //Draw outline while drawing shapes 
                Pen outlinePen = new Pen(Color.Black);
                outlinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                workingGraphics.DrawRectangle(outlinePen, startpointX, startpointY, shapewidth, shapeheight);
            }
            MainPicbox.Image = workingImage;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)//trackbar for size of pen and eraser and opacity
        {
        }
        static Point set_point(PictureBox picbox, Point p)   //for color pick
        {
            float pX = 1f * picbox.Image.Width / picbox.Width;
            float pY = 1f * picbox.Image.Height / picbox.Height;
            return new Point((int)(p.X * pX), (int)(p.Y * pY));
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) //Color Picker circle palette
        {
            Pen pen = new Pen(Pic_color.BackColor, trackBar1.Value);//back color of pic
            Point point = set_point(pictureBox1, e.Location);
            Pic_color.BackColor = ((Bitmap)pictureBox1.Image).GetPixel(point.X, point.Y); //gets the color
            new_color = Pic_color.BackColor;
            colorPick.Color = new_color; // sets the pen color to whatever is chosen on the circle palette

        }
        private void Pen_Click(object sender, EventArgs e)  //For pen button
        {
            selectedShape.BackColor = SystemColors.Control;
            Button clickedbttn = sender as Button;  //checks what button is clicked
            selectedShape = clickedbttn;  //holds what button is clicked
        }
        private void FillColor_CheckedChanged(object sender, EventArgs e)
        {
            //Shape fill 
        }

        //Opening png files
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Open Image | *.png";
                ofd.Filter = "PNG Image |*.png|BIK | *.bik|Jpeg|*jpg|Bitmap|*bmp";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    i = Image.FromFile(ofd.FileName);
                    b = (Bitmap)i;
                    MainPicbox.Size = i.Size;
                    MainPicbox.Image = b;
                    workingImage = (Bitmap)MainPicbox.Image;
                    MainPicbox.Refresh();
                    file = true; //file opened
                }
                else
                {
                    MessageBox.Show("File not found.");
                    file = false; //no file opened
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK); }
            catch (OutOfMemoryException ex) { MessageBox.Show(ex.Message); }
            finally { }
        }

        //For saving drawings
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Save Image | *.png";
                sfd.Filter = "PNG IMAGE | *.png";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.MainPicbox.Image.Save(sfd.FileName);
                }
            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }  

        //-------------FILTERS --------
        private void antiqueToolStripMenuItem_Click_1(object sender, EventArgs e)  //antique filter
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {1,0,0,0,0},
                    new float []{0,0.8f,0,0,0},
                    new float [] {0,0,0.5f,0,0},
                    new float [] {0,0,0,0.5f, 0},
                    new float [] {0,0,0,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; //which is the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }
                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception (" Please Open a file to edit");
                }
                
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }

        }
        private void roseToolStripMenuItem_Click(object sender, EventArgs e)  //rose filter
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {1,0,0,0,0},
                    new float []{0,1,0,0,0},
                    new float [] {0.50f,0,1,0,0},
                    new float [] {0,0,0,1, 0},
                    new float [] {0,0,0,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; // the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }
                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception (" Please Open a file to edit");
                }

            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }

        }

        private void grayScale1ToolStripMenuItem_Click(object sender, EventArgs e)  //Grayscale Filter
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {.3f, .3f, .3f, 0,0},
                    new float []{.59f, .59f, .59f, 0, 0},
                    new float [] {.11f, .11f, .11f, 0, 0},
                    new float [] { 0,0,0,1,0},
                    new float [] {0,0,0,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; //which is the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }
                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception (" Please Open a file to edit");
                }

            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }


        }
        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)  //invert color filter
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {-1, 0, 0, 0, 0},
                    new float []{0, -1, 0, 0, 0},
                    new float [] {0,0,-1,0,0},
                    new float [] { 0,0,0,1,0},
                    new float [] {1,1,1,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; //which is the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }

                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception (" Please Open a file to edit");
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }
        }
       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //About the app
        {
            MessageBox.Show("Basic Paint App by Nicole P. Satiembre using Visual Studio. All icons owned by me.");
        }

        private void astridToolStripMenuItem_Click(object sender, EventArgs e) //astrid filter 
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {1, 0, 0, 0, 0},
                    new float []{0, 1, 0, 0, 0},
                    new float [] {0,0,1,0,0},
                    new float [] { 0,0,0,1,0},
                    new float [] {.90f,.0f,.0f,.0f,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; // the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }

                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception (" Please Open a file to edit");
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)  //brightness filter 
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {1, 0, 0, 0, 0},
                    new float []{0, 1, 0, 0, 0},
                    new float [] {0,0,1,0,0},
                    new float [] { 0,0,0,1,0},
                    new float [] {.5f,.5f,.5f,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; //which is the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }

                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning");
                    //throw new Exception (" Please Open a file to edit");
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)  //brightness filter
        {
            try
            {
                if (file == true)
                {
                    b = (Bitmap)MainPicbox.Image;

                    Bitmap tempbm = (Bitmap)b.Clone();
                    Graphics g = Graphics.FromImage(tempbm);
                    ColorMatrix colormatrix = new ColorMatrix(new float[][] {
                    new float [] {2, 0, 0, 0, 0},
                    new float []{0, 1, 0, 0, 0},
                    new float [] {0,0,1,0,0},
                    new float [] { 0,0,0,1,0},
                    new float [] {0,0,0,0,1}});
                    ImageAttributes at = new ImageAttributes();
                    at.SetColorMatrix(colormatrix);
                    g.DrawImage(tempbm, new Rectangle(0, 0, tempbm.Width, tempbm.Height),
                                                     0, 0, tempbm.Width, tempbm.Height, GraphicsUnit.Pixel, at);
                    MainPicbox.Image = tempbm;
                    DialogResult result = MessageBox.Show("Apply filter?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainPicbox.Image = tempbm; //which is the clone
                    }
                    else
                    {
                        MainPicbox.Image = b;
                    }
                }

                else
                {
                    MessageBox.Show(" Please Open a file to edit", "Warning");
                    //throw new Exception (" Please Open a file to edit");
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message); }
            finally { }
        }

        private void Satiembre_Paint_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//the color palette circle
        {

        }
        private void Fill_clr_MouseClick(object sender, MouseEventArgs e)//Fill color mouseclick
        {

        }
        private void MainPicbox_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void MainPicbox_Click(object sender, EventArgs e)//Main Picture Box
        {


        }
        private void Pic_color_Click(object sender, EventArgs e)    //the box the shows what color is chosen
        {

        }
        public void Fill_clr_Click(object sender, EventArgs e) //click bucket
        {


        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)//File 
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)//holds the ribbons
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)  //Tools menu
        {

        }

    }
    
} 










