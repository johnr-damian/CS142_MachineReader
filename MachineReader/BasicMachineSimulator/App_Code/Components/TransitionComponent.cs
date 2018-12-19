using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Components
{
    public class TransitionComponent : template_Component
    {
        public TransitionType TransitionMode { get; } = TransitionType.Short;
        public float Angle1 { get; set; } = 0f;
        public float Angle2 { get; set; } = 0f;

        public TransitionComponent(TransitionType type)
        {
            TransitionMode = type;
        }

        public override void DrawShape(Graphics graphics)
        {
            var pen = new Pen(ComponentColor);
            switch (TransitionMode)
            {
                case TransitionType.Short:
                    graphics.DrawLine(pen, P1.X, P1.Y - 15, P2.X, P1.Y - 15);
                    graphics.DrawString(ComponentName, new Font(new FontFamily("Calibri"), 5.0f), Brushes.Black, P1.X + 3, P1.Y - 7);
                    break;
                case TransitionType.Long:
                    P1 = new Point(((P1.X < P2.X) ? P1.X : P2.X), P1.Y);
                    P2 = new Point(((P1.X > P2.X) ? P1.X : P2.X), P2.Y);
                    graphics.DrawArc(pen, P1.X, P2.Y - 30, Math.Abs(P2.X - P1.X), P2.Y, Angle1, Angle2);
                    graphics.DrawString(ComponentName, new Font(new FontFamily("Calibri"), 5.0f), Brushes.Black, P2.X - 20, P1.Y - 20);
                    break;
                case TransitionType.Loop:
                    graphics.DrawEllipse(pen, P1.X - 5, P1.Y - 5, P2.X - P1.X - 5, P2.Y - P1.Y - 5);
                    graphics.DrawString(ComponentName, new Font(new FontFamily("Calibri"), 5.0f), Brushes.Black, P1.X + 3, P1.Y - 7);
                    break;
            }
        }
    }

    public enum TransitionType
    {
        Short,
        Long,
        Loop
    }
}
