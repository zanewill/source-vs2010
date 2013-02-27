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
        private LeftOrRight lor = LeftOrRight.Note;
        public Bitmap BasicBMP
        {
            get { return _basicBMP; }
            set { _basicBMP = value; }
        }

        public BMPParser(Bitmap basicBMP)
        {
            _basicBMP = basicBMP;
        }

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

                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.ListRectangle[LeftOrRight.Left]);
                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.ListRectangle[LeftOrRight.Right]);
                g.DrawRectangle(new Pen(Brushes.Green, 1f), SettingClass.Instance.ListRectangle[LeftOrRight.Top]);

                if (lors.Keys.Contains(LeftOrRight.Left))
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.ListRectangle[LeftOrRight.Left]);
                }
                if (lors.Keys.Contains(LeftOrRight.Right))
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.ListRectangle[LeftOrRight.Right]);
                }
                if (lors.Keys.Contains(LeftOrRight.Top) )
                {
                    g.DrawRectangle(new Pen(Brushes.Red, 3f), SettingClass.Instance.ListRectangle[LeftOrRight.Top]);
                }
                
                g.Save();
            }

            return resultBMP;
        }

        private Dictionary<LeftOrRight, bool> CompareRectangle(List<Rectangle> lsRe)
        {
            int leftCount = 0;
            int rightCount = 0;
            int topCount = 0;

            Dictionary<LeftOrRight, bool> lors = new Dictionary<LeftOrRight, bool>();
            bool b = false;
            foreach (Rectangle re in lsRe)
            {
                if (SettingClass.Instance.ListRectangle[LeftOrRight.Left].Contains(re))
                {
                    leftCount++;
                    if (leftCount >= SettingClass.Instance.ParseRange)
                    {
                        if (!lors.TryGetValue(LeftOrRight.Left, out b))
                        {
                            lors.Add(LeftOrRight.Left, true);
                        }
                    }
                }

                if (SettingClass.Instance.ListRectangle[LeftOrRight.Right].Contains(re))
                {
                    rightCount++;
                    if (rightCount>= SettingClass.Instance.ParseRange)
                    {
                        if (!lors.TryGetValue(LeftOrRight.Right, out b))
                        {
                            lors.Add(LeftOrRight.Right, true);
                        }
                    }
                }

                if (SettingClass.Instance.ListRectangle[LeftOrRight.Top].Contains(re))
                {
                    topCount++;
                    if (topCount>= SettingClass.Instance.ParseRange)
                    {
                        if (!lors.TryGetValue(LeftOrRight.Top, out b))
                        {
                            lors.Add(LeftOrRight.Top, true);
                        }
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
            SettingClass.Instance.ListRectangle.Clear();
            int width = this._basicBMP.Width;
            int height = this._basicBMP.Height;

            Rectangle left = new Rectangle(0, 0, size, height - 3);
            Rectangle right = new Rectangle(width - size, 0, size, height - 3);
            Rectangle top = new Rectangle(0, 0, width, size);

            SettingClass.Instance.ListRectangle[LeftOrRight.Left] = left;
            SettingClass.Instance.ListRectangle[LeftOrRight.Right] = right;
            SettingClass.Instance.ListRectangle[LeftOrRight.Top] = top;
        }
    }
}