using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineReader
{
    public abstract class BaseComponents
    {
        private string baseName;

        private Point p1, p2;
        private Color baseColor;

        public string BaseName { get { return baseName; } set { baseName = value; } }

        public Point P1 { get { return p1; } set { p1 = value; } }
        public Point P2 { get { return p2; } set { p2 = value; } }
        public Color BaseColor { get { return baseColor; } set { baseColor = value; } }

        protected BaseComponents() { }

        public abstract void DrawShape(Graphics g);
    }
}
