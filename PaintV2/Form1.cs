using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintV2
{
    public partial class Form1 : Form
    {
        Color colorGlobal = Color.Black;
        Color targetGlobal;
        int sizeGlobal = 5;
        ColorDialog colorDialog;
        Bitmap bmpGlobal, bmpCopy;
        Graphics graphicsGlobal, graphicsCopy;
        bool paintGlobal = false;
        Point px, py, locationXY, auxLocationXY, finalLocationXY;
        Pen penGlobal, eraserGlobal;
        String tool;
        int x, y, sX, sY, cX, cY,counter;
        Font fontGlobal;
        SolidBrush brushGlobal;
        FontDialog fontDialog1;
        Image imgCopy;


        public Form1()
        {
            InitializeComponent();
            penGlobal = new Pen(colorGlobal, sizeGlobal);
            eraserGlobal = new Pen(Color.White, sizeGlobal*3);
            tool = "pencil";
            colorDialog = new ColorDialog();
            this.Width = 1200;
            this.Height = 800;

            fontGlobal = SystemFonts.DefaultFont;
            fontDialog1 = new FontDialog();
            brushGlobal = new SolidBrush(colorGlobal);

            bmpGlobal = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphicsGlobal = Graphics.FromImage(bmpGlobal);
            graphicsGlobal.Clear(Color.White);
            pictureBox1.Image = bmpGlobal;

            penGlobal.StartCap = penGlobal.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserGlobal.StartCap = penGlobal.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            graphicsGlobal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void pictureBox_color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorGlobal = colorDialog.Color;
            //colorGlobal.ToArgb();
            pictureBox_color.BackColor = colorDialog.Color;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpS = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gS = Graphics.FromImage(bmpS);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            rect.Size = pictureBox1.Size;
            gS.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            gS.Dispose();
            SaveFileDialog save = new SaveFileDialog();
            save.CheckFileExists = false;
            save.CheckPathExists = true;
            save.Filter = "Png files|*.png";
            //save.InitialDirectory = @"C:\Users\";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = save.ShowDialog();
            if (result == DialogResult.OK)
            {
                bmpS.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paintGlobal = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;


            switch (tool)
            {
                case "polygon":
                    drawPolygon(sender, e);
                    break;
                case "fill":
                    targetGlobal = bmpGlobal.GetPixel(cX,cY);
                    colorGlobal.ToArgb();
                    FloodFill(bmpGlobal, py, targetGlobal, colorGlobal);
                    break;
                case "text":
                    brushGlobal = new SolidBrush(colorGlobal);
                    graphicsGlobal.DrawString(textBox_texto.Text, fontGlobal, brushGlobal, py);
                    break;
                case "paste":
                    imgCopy = bmpCopy;
                    graphicsGlobal.DrawImage(imgCopy, py);
                    break;
                default:

                    break;
            }

            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paintGlobal = false;

            sX = x - cX;
            sY = y - cY;

            switch (tool)
            {
                case "circle":
                    graphicsGlobal.DrawEllipse(penGlobal, cX, cY, sX, sX);
                    break;
                case "rectangle":
                    graphicsGlobal.DrawRectangle(penGlobal, cX, cY, sX, sY);
                    break;
                case "line":
                    graphicsGlobal.DrawLine(penGlobal, cX, cY, x, y);
                    break;
                case "triangle":
                    graphicsGlobal.DrawLine(penGlobal, cX, cY, x, y);
                    int difX = x - cX;
                    graphicsGlobal.DrawLine(penGlobal, cX, cY, cX - difX, y);
                    graphicsGlobal.DrawLine(penGlobal, cX - difX, y, x, y);
                    break;
                case "copy":
                    Rectangle rectCopy = new Rectangle(cX, cY, sX, sY);
                    System.Drawing.Imaging.PixelFormat format = bmpGlobal.PixelFormat;
                    bmpCopy = bmpGlobal.Clone(rectCopy, format);
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paintGlobal)
            {
                eraserGlobal = new Pen(Color.White, sizeGlobal*3);
                penGlobal = new Pen(colorGlobal, sizeGlobal);
                eraserGlobal.StartCap = penGlobal.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                penGlobal.StartCap = penGlobal.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                switch (tool)
                {
                    case "pencil":
                        px = e.Location;
                        graphicsGlobal.DrawLine(penGlobal, px, py);
                        py = px;
                        break;
                    case "eraser":
                        px = e.Location;
                        graphicsGlobal.DrawLine(eraserGlobal, px, py);
                        py = px;
                        break;
                    default:
                        break;
                }
            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void button_pencil_Click(object sender, EventArgs e)
        {
            tool = "pencil";
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            tool = "circle";
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            tool = "rectangle";
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            tool = "line";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics preview = e.Graphics;
            preview.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (paintGlobal)
            {
                switch (tool)
                {
                    case "circle":
                        preview.DrawEllipse(penGlobal, cX, cY, sX, sX);
                        break;
                    case "rectangle":
                        preview.DrawRectangle(penGlobal, cX, cY, sX, sY);
                        break;
                    case "line":
                        preview.DrawLine(penGlobal, cX, cY, x, y);
                        break;
                    case "triangle":
                        preview.DrawLine(penGlobal, cX, cY, x, y);
                        int difX = x - cX;
                        preview.DrawLine(penGlobal, cX, cY, cX - difX, y);
                        preview.DrawLine(penGlobal, cX - difX, y, x, y);
                        break;
                    case "copy":
                        Pen p = p = new Pen(Color.LightBlue, 1);
                        preview.DrawRectangle(p, cX, cY, sX, sY);
                        break;
                    default:
                        break;
                }
            }

            

        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            tool = "fill";
        }

        private void button_text_Click(object sender, EventArgs e)
        {
            tool = "text";
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            tool = "copy";
        }

        private void button_textDialog_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;            

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                fontGlobal = fontDialog1.Font;
                colorGlobal = fontDialog1.Color;
                pictureBox_color.BackColor = fontDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_texto.Text = "";
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            tool = "paste";
        }

        private void button_triangle_Click(object sender, EventArgs e)
        {
            tool = "triangle";
        }

        private void button_polygon_Click(object sender, EventArgs e)
        {
            tool = "polygon";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            graphicsGlobal.Clear(Color.White);
            pictureBox1.Image = bmpGlobal;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            sizeGlobal = sizeGlobal - 1;
            label_size_number.Text = sizeGlobal.ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            sizeGlobal = sizeGlobal + 1;
            label_size_number.Text = sizeGlobal.ToString();
        }

        private void button_eraser_Click(object sender, EventArgs e)
        {
            tool = "eraser";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Png files|*.png";
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image image1 = Image.FromFile(open.FileName);
                graphicsGlobal.DrawImage(image1, 0, 0);
                

            }
            pictureBox1.Refresh();
        }

        private void drawPolygon(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;
            if (e2.Button == MouseButtons.Right)
            {
                counter++;
            }
            switch (counter)
            {
                case 0:
                    locationXY = e2.Location;
                    counter++;
                    break;
                case 1:
                    auxLocationXY = e2.Location;
                    finalLocationXY = auxLocationXY;
                    graphicsGlobal.DrawLine(penGlobal, locationXY, auxLocationXY);
                    counter++;
                    break;
                case 2:
                    finalLocationXY = auxLocationXY;
                    auxLocationXY = e2.Location;
                    graphicsGlobal.DrawLine(penGlobal, auxLocationXY, finalLocationXY);
                    break;
                default:
                    graphicsGlobal.DrawLine(penGlobal, auxLocationXY, locationXY);
                    counter = 0;
                    break;
            }
            bmpGlobal = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {            
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pictureBox1.Refresh();
            return;
        }
    }
}
