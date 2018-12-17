using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineReader
{
    class LongTransitionComponent : BaseComponents
    {
        private float f1 = 0f;
        private float f2 = 0f;

        private LongTransitionComponent() { }
        public LongTransitionComponent(string base_name, Point p1, Point p2, Color base_color, float angle1, float angle2)
        {
            BaseName = base_name;
            P1 = new Point(((p1.X < p2.X)? p1.X : p2.X), p1.Y);
            P2 = new Point(((p1.X > p2.X) ? p1.X : p2.X), p2.Y);
            f1 = angle1;
            f2 = angle2;
            BaseColor = base_color;
        }

        public override void DrawShape(Graphics g)
        {
            Pen pen = new Pen(BaseColor);
            g.DrawArc(pen, P1.X, P2.Y-30, Math.Abs(P2.X - P1.X), P2.Y, f1, f2);
            g.DrawString(BaseName, new Font(new FontFamily("Times New Roman"), 10.0f), Brushes.Black, P2.X-20, P1.Y - 20);
        }
    }
}
