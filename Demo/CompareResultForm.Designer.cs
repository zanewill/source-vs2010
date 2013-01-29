namespace Demo
{
    partial class CompareResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.label_R = new System.Windows.Forms.Label();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.label_G = new System.Windows.Forms.Label();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.label_B = new System.Windows.Forms.Label();
            this.trackBar_WorkSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBtn_LeftOrRight = new System.Windows.Forms.RadioButton();
            this.radioBtn_Angle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WorkSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 480);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar_R
            // 
            this.trackBar_R.Location = new System.Drawing.Point(813, 42);
            this.trackBar_R.Maximum = 256;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.Size = new System.Drawing.Size(194, 45);
            this.trackBar_R.TabIndex = 2;
            this.trackBar_R.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_R.Location = new System.Drawing.Point(663, 42);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(82, 24);
            this.label_R.TabIndex = 3;
            this.label_R.Text = "R Diff";
            // 
            // trackBar_G
            // 
            this.trackBar_G.Location = new System.Drawing.Point(813, 98);
            this.trackBar_G.Maximum = 256;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(194, 45);
            this.trackBar_G.TabIndex = 2;
            this.trackBar_G.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_G.Location = new System.Drawing.Point(663, 98);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(82, 24);
            this.label_G.TabIndex = 3;
            this.label_G.Text = "G Diff";
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(813, 154);
            this.trackBar_B.Maximum = 256;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(194, 45);
            this.trackBar_B.TabIndex = 2;
            this.trackBar_B.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_B.Location = new System.Drawing.Point(663, 154);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(82, 24);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "B Diff";
            // 
            // trackBar_WorkSize
            // 
            this.trackBar_WorkSize.Location = new System.Drawing.Point(813, 210);
            this.trackBar_WorkSize.Maximum = 256;
            this.trackBar_WorkSize.Name = "trackBar_WorkSize";
            this.trackBar_WorkSize.Size = new System.Drawing.Size(194, 45);
            this.trackBar_WorkSize.TabIndex = 2;
            this.trackBar_WorkSize.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(663, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "WorkSize";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Basi Pic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBtn_LeftOrRight
            // 
            this.radioBtn_LeftOrRight.AutoSize = true;
            this.radioBtn_LeftOrRight.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_LeftOrRight.Location = new System.Drawing.Point(813, 261);
            this.radioBtn_LeftOrRight.Name = "radioBtn_LeftOrRight";
            this.radioBtn_LeftOrRight.Size = new System.Drawing.Size(137, 24);
            this.radioBtn_LeftOrRight.TabIndex = 5;
            this.radioBtn_LeftOrRight.TabStop = true;
            this.radioBtn_LeftOrRight.Text = "LeftOrRight";
            this.radioBtn_LeftOrRight.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Angle
            // 
            this.radioBtn_Angle.AutoSize = true;
            this.radioBtn_Angle.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_Angle.Location = new System.Drawing.Point(813, 304);
            this.radioBtn_Angle.Name = "radioBtn_Angle";
            this.radioBtn_Angle.Size = new System.Drawing.Size(77, 24);
            this.radioBtn_Angle.TabIndex = 5;
            this.radioBtn_Angle.TabStop = true;
            this.radioBtn_Angle.Text = "Angle";
            this.radioBtn_Angle.UseVisualStyleBackColor = true;
            // 
            // CompareResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 509);
            this.Controls.Add(this.radioBtn_Angle);
            this.Controls.Add(this.radioBtn_LeftOrRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_G);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.trackBar_B);
            this.Controls.Add(this.trackBar_G);
            this.Controls.Add(this.trackBar_WorkSize);
            this.Controls.Add(this.trackBar_R);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CompareResultForm";
            this.Text = "CompareResult";
            this.Load += new System.EventHandler(this.CompareResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WorkSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar_R;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.TrackBar trackBar_G;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.TrackBar trackBar_B;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TrackBar trackBar_WorkSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioBtn_LeftOrRight;
        private System.Windows.Forms.RadioButton radioBtn_Angle;
    }
}