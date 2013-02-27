using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageParser;

namespace Demo
{
    public partial class CompareSetting : Form
    {
        Bitmap baseBMP;
        public void SetBaseBMP(Bitmap bmp)
        {
            this.baseBMP = bmp;
        }

        public void SetShowBMP(Bitmap bmp)
        {
            this.pictureBox2.Image = bmp;
        }

        public CompareSetting()
        {
            InitializeComponent();
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;

            switch (trackBar.Name)
            {
                case "trackBar_R":
                    SettingClass.Instance.R_Diff = trackBar.Value;
                    this.label_R.Text = "R Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_G":
                    SettingClass.Instance.G_Diff = trackBar.Value;
                    this.label_G.Text = "G Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_B":
                    SettingClass.Instance.B_Diff = trackBar.Value;
                    this.label_B.Text = "B Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_WorkSize":
                    SettingClass.Instance.WorkSize = trackBar.Value;
                    this.label1.Text = "WorkSize:" + trackBar.Value;
                    break;
                case "trackBar_ParserRange":
                    SettingClass.Instance.ParseRange = trackBar.Value;
                    this.label2.Text = "Range:" + trackBar.Value;
                    break;
                default:
                    break;
            }

            SettingClass.Instance.WriteSetting(SettingClass.Instance);
        }

        private void CompareResultForm_Load(object sender, EventArgs e)
        {
            trackBar_B.Value = SettingClass.Instance.B_Diff;
            trackBar_G.Value = SettingClass.Instance.G_Diff;
            trackBar_R.Value = SettingClass.Instance.R_Diff;
            trackBar_WorkSize.Value = SettingClass.Instance.WorkSize;
            trackBar_ParserRange.Value = SettingClass.Instance.ParseRange;

            this.label_R.Text = "R Diff(" + SettingClass.Instance.B_Diff + ")";
            this.label_G.Text = "G Diff(" + SettingClass.Instance.G_Diff + ")";
            this.label_B.Text = "B Diff(" + SettingClass.Instance.B_Diff + ")";

            this.label1.Text = "WorkSize:" + SettingClass.Instance.WorkSize;
            this.label2.Text = "Range:" + SettingClass.Instance.ParseRange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowBasePicForm showBasePicForm = new ShowBasePicForm();
            showBasePicForm.SetBasePic(this.baseBMP);
            showBasePicForm.Show();
        }
    }
}
