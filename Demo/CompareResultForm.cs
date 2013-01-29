using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class CompareResultForm : Form
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

        public CompareResultForm()
        {
            InitializeComponent();
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;

            switch (trackBar.Name)
            {
                case "trackBar_R":
                    SettingClass.R_Diff = trackBar.Value;
                    this.label_R.Text = "R Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_G":
                    SettingClass.G_Diff = trackBar.Value;
                    this.label_G.Text = "G Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_B":
                    SettingClass.B_Diff = trackBar.Value;
                    this.label_B.Text = "B Diff(" + trackBar.Value + ")";
                    break;
                case "trackBar_WorkSize":
                    SettingClass.WorkSize = trackBar.Value;
                    this.label1.Text = "WorkSize:" + trackBar.Value;
                    break;
                default:
                    break;
            }

            SettingClass.WriteSetting();
        }

        private void CompareResultForm_Load(object sender, EventArgs e)
        {
            trackBar_B.Value = SettingClass.B_Diff;
            trackBar_G.Value = SettingClass.G_Diff;
            trackBar_R.Value = SettingClass.R_Diff;
            trackBar_WorkSize.Value = SettingClass.WorkSize;

            this.label_R.Text = "R Diff(" + SettingClass.B_Diff + ")";
            this.label_G.Text = "G Diff(" + SettingClass.G_Diff + ")";
            this.label_B.Text = "B Diff(" + SettingClass.B_Diff + ")";

            this.label1.Text = "WorkSize:" + SettingClass.WorkSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowBasePicForm showBasePicForm = new ShowBasePicForm();
            showBasePicForm.SetBasePic(this.baseBMP);
            showBasePicForm.Show();
        }
    }
}
