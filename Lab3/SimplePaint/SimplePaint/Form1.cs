using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank( pictureBox1.Width, pictureBox1.Height );
        }
        //цвет заливки по умолчанию 
        Color DefaultColor
        {
            get { return Color.Aqua; }
        }

        //создаем пустую облость рисования 
        void CreateBlank(int width, int height)
        { 
            //сохраняем старую картинку 
            var oldImage = pictureBox1.Image;
            //созжаем новый битмап
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим пиксельное закрашивание 
            //битмап обычный двухмерный массив точек поэтому проходим его за 2 цикла:
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }

            pictureBox1.Image = bmp;
            if (oldImage != null)
            { 
                oldImage.Dispose();// освобождаем ресурсы занятые старой картинкой
            }

        
        }




     
    }
}
