using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;

namespace ImageParser
{
    [Serializable]
    public class SettingClass
    {
        private  int r_Diff;
        private int g_Diff;
        private int b_Diff;
        private int workSize;

        private const string fileName = "Setting.xml";
        private List<Rectangle> compareResult = new List<Rectangle>();

        public static SettingClass Instance
        {
            get 
            {
                return _setting;
            }
        }

        private static SettingClass _setting = new SettingClass();

        private SettingClass()
        {
        }

        public  List<Rectangle> CompareResult
        {
            get { return compareResult; }
            set { compareResult = value; }
        }

        public Dictionary<LeftOrRight, Rectangle> listRectangle = new Dictionary<LeftOrRight, Rectangle>();

        public void WriteSetting(SettingClass obj)
        {
            SerializableOperate.ObjectSerializable(obj, fileName);
        }

        public void ReadSetting()
        {
            if (!File.Exists(fileName))
            {
                return;
            }

         object o    = SerializableOperate.ObjectUnSerializable(fileName);
        
            if(o != null)
            {
                _setting = (SettingClass)o;
            }
        }

        public  int WorkSize
        {
            get { return workSize; }
            set { workSize = value; }
        }

        public  int G_Diff
        {
            get { return g_Diff; }
            set { g_Diff = value; }
        }

        public  int B_Diff
        {
            get { return b_Diff; }
            set { b_Diff = value; }
        }

        public  int R_Diff
        {
            get { return r_Diff; }
            set { r_Diff = value; }
        }
    }
}
