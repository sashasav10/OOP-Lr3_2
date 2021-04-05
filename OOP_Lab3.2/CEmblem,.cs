using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab3._2
{
    class CEmblem
    {
        Color color { get; set; }
        public Color currentColor { get; set; }
        int size { get; set; }
        int x { get; set; }
        int y { get; set; }
        string name { get; set; }
        Pen pen = new Pen(Color.Blue, 1f);
        public CEmblem(int x, int y, int size,string name, Color color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.name = name;
            this.color = color;
            currentColor = color;
        }
        public override string ToString()
        {
            return name;
        }
        public void Draw(PictureBox pictureBox)
        {
            pen.Color = currentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawRectangle(pen, x, y, size, size);
                g.DrawEllipse(pen, x, y, size, size);
                Point[] points = new Point[3];
                points[0].X = x+ size / 2; points[0].Y = y;
                points[1].X = x+size / 15; points[1].Y = y+size / 4 * 3;
                points[2].X = x+size -(size / 15); points[2].Y = y+size / 4 * 3;
               g.DrawPolygon(pen, points);
                pictureBox.Refresh();
            }

        }
        public void MoveRight()
        {
            x++;
        }
        public void MoveLeft()
        {
            x--;
        }
        public void MoveUp()
        {
            y--;
        }
        public void MoveDown()
        {
            y++;
        }
        public void EndUp()
        {
            y = 0;
        }
        public void EndDown()
        {
            y = 455-size; 
        }
        public void EndLeft()
        {
            x = 0;
        }
        public void EndRight()
        {
            x = 623 - size;
        }
        public void Enlarge()
        {
            size++;
        }
        public void Reduce()
        {
            size--;
        }
        public void Hide()
        {
            currentColor = Color.White;
        }
        public void Show()
        {
            currentColor = color;
        }
    }
}
