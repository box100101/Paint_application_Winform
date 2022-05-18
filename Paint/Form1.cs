using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

           
            bitMap = new Bitmap(pic.Width, pic.Height);
            graphics = Graphics.FromImage(bitMap);
            graphics.Clear(Color.White);
            pic.Image = bitMap;

            //initialize initial color
            picked_color.BackColor = Color.Black;

        }

        // Declear variable
        Bitmap bitMap;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black,1);
        Pen erase = new Pen(Color.White,15);

        bool isModify = false;

        string function;

        List<shape> shapeList = new List<shape>();
        List<shape> shapeRedoList = new List<shape>();



        // Handle Events
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (function != null)
            {
                paint = true;
            }
            //py = e.Location;

            switch (function)
            {
                case "Rectangle":
                    shape rec = new rectangle();
                    rec.isFill = false;
                    rec.pen = new Pen(pen.Color, pen.Width);
                    rec.pen.DashStyle = pen.DashStyle;
                    rec.p1 = e.Location;
                    shapeList.Add(rec);
                    break;
                case "Fill Rectangle":
                    shape fill_rec = new rectangle();
                    fill_rec.isFill = true;
                    fill_rec.pen = new Pen(pen.Color, pen.Width);
                    fill_rec.pen.DashStyle = pen.DashStyle;
                    fill_rec.p1 = e.Location;
                    shapeList.Add(fill_rec);
                    break;
                case "Circle":
                    shape cir = new circle();
                    cir.isFill = false;
                    cir.pen = new Pen(pen.Color, pen.Width);
                    cir.pen.DashStyle = pen.DashStyle;
                    cir.p1 = e.Location;
                    shapeList.Add(cir);
                    break;
                case "Fill Circle":
                    shape fill_cir = new circle();
                    fill_cir.isFill = true;
                    fill_cir.pen = new Pen(pen.Color, pen.Width);
                    fill_cir.pen.DashStyle = pen.DashStyle;
                    fill_cir.p1 = e.Location;
                    shapeList.Add(fill_cir);
                    break;
                case "Ellipse":
                    shape ell = new ellipse();
                    ell.isFill = false;
                    ell.pen = new Pen(pen.Color, pen.Width);
                    ell.pen.DashStyle = pen.DashStyle;
                    ell.p1 = e.Location;
                    shapeList.Add(ell);
                    break;
                case "Fill Ellipse":
                    shape fill_ell = new ellipse();
                    fill_ell.isFill = true;
                    fill_ell.pen = new Pen(pen.Color, pen.Width);
                    fill_ell.pen.DashStyle = pen.DashStyle;
                    fill_ell.p1 = e.Location;
                    shapeList.Add(fill_ell);
                    break;
                case "Square":
                    shape squ = new square();
                    squ.isFill = false;
                    squ.pen = new Pen(pen.Color, pen.Width);
                    squ.pen.DashStyle = pen.DashStyle;
                    squ.p1 = e.Location;
                    shapeList.Add(squ);
                    break;
                case "Fill Square":
                    shape fill_squ = new square();
                    fill_squ.isFill = true;
                    fill_squ.pen = new Pen(pen.Color, pen.Width);
                    fill_squ.pen.DashStyle = pen.DashStyle;
                    fill_squ.p1 = e.Location;
                    shapeList.Add(fill_squ);
                    break;
                case "Line":
                    shape lin = new line();
                    lin.pen = new Pen(pen.Color, pen.Width);
                    lin.pen.DashStyle = pen.DashStyle;
                    lin.p1 = e.Location;
                    shapeList.Add(lin);
                    break;
                case "Polygon":
                    shape pol = new polygon();
                    pol.isFill = false;
                    pol.pen = new Pen(pen.Color, pen.Width);
                    pol.pen.DashStyle = pen.DashStyle;
                    pol.p1 = e.Location;
                    shapeList.Add(pol);
                    break;
                case "Fill Polygon":
                    shape fill_pol = new polygon();
                    fill_pol.isFill = true;
                    fill_pol.pen = new Pen(pen.Color, pen.Width);
                    fill_pol.pen.DashStyle = pen.DashStyle;
                    fill_pol.p1 = e.Location;
                    shapeList.Add(fill_pol);
                    break;
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            int lastIndex = shapeList.Count;

            if (function == "Ellipse")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Fill Ellipse")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Circle")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Fill Circle")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Rectangle")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Fill Rectangle")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Square")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Fill Square")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Line")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Polygon")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
            else if (function == "Fill Polygon")
            {
                shapeList[lastIndex - 1].draw(graphics);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(function == "pencil")
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if(function == "erase")
                {
                    px = e.Location;
                    graphics.DrawLine(erase, px, py);
                    py= px;
                }
                
                shapeList[shapeList.Count-1].p2 = e.Location;
            }
            pic.Refresh();

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int lastIndex = shapeList.Count;
            if (paint)
            {
                if (function == "Ellipse")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Fill Ellipse")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Circle")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Fill Circle")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Rectangle")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);   
                }
                else if(function == "Fill Rectangle")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Square")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Fill Square")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Line")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Polygon")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
                else if (function == "Fill Polygon")
                {
                    isModify = true;
                    shapeList[lastIndex - 1].draw(graphics);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Image(*.png)|*.png|(*.*|*.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = bitMap.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bitMap.PixelFormat);
                bm.Save(saveFile.FileName);

                MessageBox.Show("Save picture successfully!");
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            function = "erase";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            shapeList.Clear();
            shapeRedoList.Clear(); 
        }

        private void btnPencil_Click(object sender, EventArgs e) 
        {
            function = "pencil";
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            function = "Ellipse";
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            function = "Fill Ellipse";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            function = "Rectangle";
        }

        private void btnFillRectangle_Click(object sender, EventArgs e)
        {
            function = "Fill Rectangle";
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            function = "Line";
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            function = "Square";
        }
        private void btnFillSquare_Click(object sender, EventArgs e)
        {
            function = "Fill Square";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            function = "Circle";
        }

        private void btnFillCircle_Click(object sender, EventArgs e)
        {
            function = "Fill Circle";
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            function = "Fill";
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            function = "Polygon";
        }

        private void btnFillPolygon_Click(object sender, EventArgs e)
        {
            function = "Fill Polygon";
        }

        private void comboBoxPixel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pixel;
            pixel = comboBoxPixel.SelectedIndex + 1;
            pen.Width = pixel;
        }

        private void comboBoxLine_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int index = comboBoxLine.SelectedIndex;
            
            switch (index)
            {
                case 0:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                break;
                case 1:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 2:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                default:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            isModify = false;
            if (shapeList.Count <= 0)
                return;
            graphics.Clear(Color.White);
            shapeRedoList.Add(shapeList[shapeList.Count - 1]);
            shapeList.RemoveAt(shapeList.Count - 1);

            for (int i = 0; i < shapeList.Count; i++)
            {
                shapeList[i].draw(graphics);
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {

            if (isModify)
            {
                MessageBox.Show("You can not redo!");
                shapeRedoList.Clear();
                return;
            }
            if(!isModify)
            {
                if (shapeRedoList.Count <= 0)
                    return;
                shapeList.Add(shapeRedoList[shapeRedoList.Count - 1]);
                shapeRedoList.RemoveAt(shapeRedoList.Count - 1);
                graphics.Clear(Color.White);
                for (int i = 0; i < shapeList.Count; i++)
                {
                    shapeList[i].draw(graphics);
                }
            }
        }

        // Handle event pick color
        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                picked_color.BackColor = colorDialog.Color;
            }
        }

        private void btnBlackColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            picked_color.BackColor = Color.Black;
        }
        private void btnBlueColor_Click(object sender, EventArgs e)
        {
            pen.Color= Color.Blue;
            picked_color.BackColor= Color.Blue;
        }

        private void btnGreenColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
            picked_color.BackColor= Color.Green;   
        }

        private void btnOrangeColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Orange;
            picked_color.BackColor= Color.Orange;
        }

        private void btnRedColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            picked_color.BackColor= Color.Red;
        }

        private void btnPurpleColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Purple;
            picked_color.BackColor= Color.Purple;
        }

        private void btnYellowColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            picked_color.BackColor= Color.Yellow;
        }

        private void btnBrownColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Brown;
            picked_color.BackColor= Color.Brown;
        }

        // Handle event fill color
        static Point set_point (PictureBox pictureBox, Point point)
        {
            float x = 1f * pictureBox.Image.Width / pictureBox.Width;
            float y = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * x), (int)(point.Y * y));   
        }

        private void validate(Bitmap bitMap, Stack<Point> stack_point, int x, int y, Color old_color, Color new_color)
        {
            Color color = bitMap.GetPixel(x, y);
            if (color == old_color)
            {
                stack_point.Push(new Point(x, y));
                bitMap.SetPixel(x, y, new_color);
            }
        }
            
        private void fill(Bitmap bitMap, int x, int y, Color new_color)
        {
            Color old_color = bitMap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));    
            bitMap.SetPixel(x, y, new_color);
            if (old_color == new_color) return;

            while(pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bitMap.Width - 1 && point.Y < bitMap.Height - 1)
                {
                    validate(bitMap, pixel, point.X - 1, point.Y, old_color, new_color);
                    validate(bitMap, pixel, point.X, point.Y - 1, old_color, new_color);
                    validate(bitMap, pixel, point.X + 1, point.Y, old_color, new_color);
                    validate(bitMap, pixel, point.X, point.Y + 1, old_color, new_color);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (function == "Fill")
            {
                Point point = set_point(pic, e.Location);
                fill(bitMap, point.X, point.Y, pen.Color);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Z)
            {
                isModify = false;
                if (shapeList.Count <= 0)
                    return;
                graphics.Clear(Color.White);
                shapeRedoList.Add(shapeList[shapeList.Count - 1]);
                shapeList.RemoveAt(shapeList.Count - 1);

                for (int i = 0; i < shapeList.Count; i++)
                {
                    shapeList[i].draw(graphics);
                }
            }
        }

    }
}
