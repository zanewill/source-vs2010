using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageParser
{
    public enum LeftOrRight
    {
        Note,
        Left,
        Right,
        Top
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

        private LeftOrRight lor = LeftOrRight.Note;

        public Bitmap ComparseBMP(Bitmap targetBMP)
        {
            Bitmap resultBMP = (Bitmap)targetBMP.Clone();
            SetWorkSize(SettingClass.Instance.WorkSize);
            List<Rectangle> compareResult = ImageComparer.Compare(_basicBMP, targetBMP);
            using (Graphics g = Graphics.FromImage(resultBMP))
            {   
                if (compareResult.Count > 0)
                {
                    g.DrawRectangles(new Pen(Brushes.Blue, 1f), compareResult.ToArray());
                }

                Dictionary<LeftOrRight, bool> lors = CompareRectangle(compareResult);

                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.listRectangle[LeftOrRight.Left]);
                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.listRectangle[LeftOrRight.Right]);
                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.listRectangle[LeftOrRight.Top]);

                if (lors.Keys.Contains(LeftOrRight.Left))
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.listRectangle[LeftOrRight.Left]);
                }
                if (lors.Keys.Contains(LeftOrRight.Right))
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.listRectangle[LeftOrRight.Right]);
                }
                if (lors.Keys.Contains(LeftOrRight.Top) )
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.listRectangle[LeftOrRight.Top]);
                }
                
                g.Save();
            }

            return resultBMP;
        }

        private Dictionary<LeftOrRight, bool> CompareRectangle(List<Rectangle> lsRe)
        {
            Dictionary<LeftOrRight, bool> lors = new Dictionary<LeftOrRight, bool>();
            bool b = false;
            foreach (Rectangle re in lsRe)
            {
                if (SettingClass.Instance.listRectangle[LeftOrRight.Left].Contains(re))
                {
                    if (!lors.TryGetValue(LeftOrRight.Left, out b))
                    {
                        lors.Add(LeftOrRight.Left, true);
                    }
                }

                if (SettingClass.Instance.listRectangle[LeftOrRight.Right].Contains(re))
                {
                    if (!lors.TryGetValue(LeftOrRight.Right, out b))
                    {
                        lors.Add(LeftOrRight.Right, true);
                    }
                }

                if (SettingClass.Instance.listRectangle[LeftOrRight.Top].Contains(re))
                {
                    if (!lors.TryGetValue(LeftOrRight.Top, out b))
                    {
                        lors.Add(LeftOrRight.Top, true);
                    }
                }

                if (lors.Keys.Contains(LeftOrRight.Left) && lors.Keys.Contains(LeftOrRight.Right)&& lors.Keys.Contains(LeftOrRight.Top))
                {
                    break;
                }
            }
            return lors;
        }

        public void SetWorkSize(int size)
        {
            SettingClass.Instance.listRectangle.Clear();
            int width = this._basicBMP.Width;
            int height = this._basicBMP.Height;

            Rectangle left = new Rectangle(0, 0, size, height - 3);
            Rectangle right = new Rectangle(width - size, 0, size, height - 3);
            Rectangle top = new Rectangle(0, 0, width, size);

            SettingClass.Instance.listRectangle[LeftOrRight.Left] = left;
            SettingClass.Instance.listRectangle[LeftOrRight.Right] = right;
            SettingClass.Instance.listRectangle[LeftOrRight.Top] = top;
        }
    }
}