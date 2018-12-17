using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineReader
{
    public class TapeComponent : BaseComponents
    {
        private TapeComponent() { }
        public TapeComponent(string base_name, Point p1, Point p2, Color base_color)
        {
            BaseName = base_name;
            P1 = p1;
            P2 = p2;
            BaseColor = base_color;
        }

        public override void DrawShape(Graphics g)
        {
            Pen pen = new Pen(BaseColor);
            g.DrawRectangle(pen, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
            g.DrawString(BaseName, new Font(new FontFamily("Times New Roman"), 10.0f), Brushes.Black, P1.X + 6, P1.Y + 5);
        }
    }
}
