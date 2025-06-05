using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_graphic_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
         
        }
        //Цвет заливки по умолчанию 
        Color DefaultColor 
        { 
            get { return Color.White; } 
        }
        // Создать пустую область рисования
        // <param name="width">Wupuna области</рагат>
        // <param name="height">Becota области</рагат>
        void CreateBlank(int width, int height)
        {
            //сохраняем старую картинку
            var oldImage = pictureВох1.Ттаве;
            //Создаем новый Bitmap
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим попиксельное закрашивание
            //Битмап - обычный двумерный массив точек, поэтому проходим его за 2 цикла:
            for (int i = @; i < width; i++)
            {
                for (int j = @; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
