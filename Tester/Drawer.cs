using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath GP = new GraphicsPath();

            GP.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            GP.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            GP.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            GP.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            GP.CloseFigure();

            return GP; 

        }


    }
}
