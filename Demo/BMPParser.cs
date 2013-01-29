using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Demo
{
    public enum LeftOrRight
    {
        Left,
        Right
    }

    public class BMPParser
    {
        private Bitmap _basicBMP;

        public Bitmap BasicBMP
        {
            get { return _basicBMP; }
            set { _basicBMP = value; }
        }

        public BMPParser(Bitmap basicBMP)
        {
            _basicBMP = basicBMP;
        }

        public Bitmap LRFlipImage(Bitmap bitmap)
        {
            Bitmap rtBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Color c = new Color();
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    rtBitmap.SetPixel(bitmap.Width - 1 - i, j, c);
                }
            }
            return rtBitmap;
        }

        public Bitmap ComparseBMP(Bitmap targetBMP)
        {
            Bitmap resultBMP = (Bitmap)targetBMP.Clone();
            SetWorkSize(SettingClass.WorkSize);
            List<Rectangle> compareResult = ImageComparer.Compare(_basicBMP, targetBMP);
            using (Graphics g = Graphics.FromImage(resultBMP))
            {   
                if (compareResult.Count > 0)
                {
                    g.DrawRectangles(new Pen(Brushes.Blue, 1f), compareResult.ToArray());
                }
                g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.listRectangle["Left"]);
                g.DrawRectangle(new Pen(Brushes.Blue, 3f), SettingClass.listRectangle["Right"]);
                g.DrawRectangle(new Pen(Brushes.Green, 3f), SettingClass.listRectangle["Top"]);
                g.Save();
            }

            return resultBMP;
        }

        public void SetWorkSize(int size)
        {
            SettingClass.listRectangle.Clear();
            int width = this._basicBMP.Width;
            int height = this._basicBMP.Height;

            Rectangle left = new Rectangle(0, 0, size, height - 3);
            Rectangle right = new Rectangle(width - size, 0, size, height - 3);
            Rectangle top = new Rectangle(0, 0, width, size);

            SettingClass.listRectangle["Left"] = left;
            SettingClass.listRectangle["Right"] = right;
            SettingClass.listRectangle["Top"] = top;
        }
    }
}