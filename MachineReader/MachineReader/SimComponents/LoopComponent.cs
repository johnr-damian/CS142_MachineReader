﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineReader
{
    public class LoopComponent : BaseComponents
    {
        private LoopComponent() { }
        public LoopComponent(string base_name, Point p1, Point p2, Color base_color)
        {
            BaseName = base_name;
            P1 = p1;
            P2 = p2;
            BaseColor = base_color;
        }

        public override void DrawShape(Graphics g)
        {
            Pen pen = new Pen(BaseColor);
            g.DrawEllipse(pen, P1.X - 5, P1.Y - 5, P2.X - P1.X - 5, P2.Y - P1.Y - 5);
            g.DrawString(BaseName, new Font(new FontFamily("Times New Roman"), 10.0f), Brushes.Black, P1.X + 3, P1.Y - 7);
        }
    }
}
