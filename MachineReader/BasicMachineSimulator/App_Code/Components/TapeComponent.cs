using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Components
{
    public class TapeComponent : template_Component
    {
        public override void DrawShape(Graphics graphics)
        {
            var pen = new Pen(ComponentColor);
            graphics.DrawRectangle(pen, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
            graphics.DrawString(ComponentName, new Font(new FontFamily("Calibri"), 5.0f), Brushes.Black, P1.X + 6, P1.Y + 5);
        }
    }
}
