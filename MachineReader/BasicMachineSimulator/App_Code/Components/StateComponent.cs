using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Components
{
    public class StateComponent : template_Component
    {
        public bool IsStartState { get; } = false;

        public StateComponent(bool is_startstate)
        {
            IsStartState = is_startstate;
            if (IsStartState)
                ComponentColor = Color.DodgerBlue;
        }

        public override void DrawShape(Graphics graphics)
        {
            var pen = new Pen(ComponentColor);
            graphics.DrawEllipse(pen, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
            graphics.DrawString(ComponentName, new Font(new FontFamily("Calibri"), 8.0f), Brushes.Black, P1.X + 6, P1.Y + 5);
        }

        public override void UnSelect()
        {
            if(IsStartState)
                ComponentColor = Color.DodgerBlue;
        }
    }
}
