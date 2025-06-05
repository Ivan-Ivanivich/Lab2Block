using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    internal class QuadBrush : Brush
    {
        public QuadBrush(Color brusColor, int size)
            : base(brusColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            try
            {
                int diameter = Size * 2;
                int startX = x - Size;
                int startY = y - Size;

                // Простая проверка выхода за границы
                if (startX < 0 || startY < 0 ||
                    startX + diameter > image.Width ||
                    startY + diameter > image.Height)
                {
                    return; // Просто не рисуем, если вышли за границы
                }

                using (var g = Graphics.FromImage(image))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillRectangle(new SolidBrush(BrushColor), startX, startY, diameter, diameter);
                }
            }
            catch
            {
                // Игнорируем ошибки
            }
        }
    }
}
