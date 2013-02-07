using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;

namespace Demo
{
    public class SettingClass
    {
        private static int r_Diff;
        private static int g_Diff;
        private static int b_Diff;
        private static int workSize;

        private  const string fileName = "Setting.xml";
        private static List<Rectangle> compareResult = new List<Rectangle>();
        public static List<Rectangle> CompareResult
        {
            get { return compareResult; }
            set { compareResult = value; }
        }

        public static Dictionary<LeftOrRight, Rectangle> listRectangle = new Dictionary<LeftOrRight, Rectangle>();

        public static void WriteSetting()
        {
            string xmlContent = "<Root>" +
                                    "<R>" + r_Diff + "</R>" +
                                    "<G>" + g_Diff + "</G>" +
                                    "<B>" + b_Diff + "</B>" +
                                    "<W>" + workSize + "</W>" +
                                 "</Root>";


            File.WriteAllText(fileName, xmlContent);
        }

        public static void ReadSetting()
        {
            if (!File.Exists(fileName))
            {
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            string xmlContent = File.ReadAllText(fileName);
            xmlDoc.LoadXml(xmlContent);
            XmlElement element = xmlDoc.DocumentElement;

            foreach (XmlNode ele in element.ChildNodes)
            {
                if (ele.Name == "R")
                {
                    SettingClass.R_Diff = Convert.ToInt32(ele.InnerText);
                }
                else if (ele.Name == "G")
                {
                    SettingClass.G_Diff = Convert.ToInt32(ele.InnerText);
                }
                else if (ele.Name == "B")
                {
                    SettingClass.B_Diff = Convert.ToInt32(ele.InnerText);
                }
                else if (ele.Name == "W")
                {
                    SettingClass.WorkSize = Convert.ToInt32(ele.InnerText);
                }
            }
        }

        public static int WorkSize
        {
            get { return SettingClass.workSize; }
            set { SettingClass.workSize = value; }
        }

        public static int G_Diff
        {
            get { return SettingClass.g_Diff; }
            set { SettingClass.g_Diff = value; }
        }

        public static int B_Diff
        {
            get { return SettingClass.b_Diff; }
            set { SettingClass.b_Diff = value; }
        }

        public static int R_Diff
        {
            get { return r_Diff; }
            set { r_Diff = value; }
        }
    }
}
