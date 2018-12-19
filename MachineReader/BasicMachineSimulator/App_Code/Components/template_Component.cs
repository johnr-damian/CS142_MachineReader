using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Components
{
    /// <summary>
    /// template for all component
    /// </summary>
    public abstract class template_Component
    {
        public string ComponentName { get; set; } = "";
        public Point P1 { get; set; } = new Point(0, 0);
        public Point P2 { get; set; } = new Point(0, 0);
        public Color ComponentColor { get; set; } = Color.Black;

        public abstract void DrawShape(Graphics graphics);
        public virtual void Selected()
        {
            ComponentColor = Color.Red;
        }

        public virtual void UnSelect()
        {
            ComponentColor = Color.Black;
        }
    }
}
