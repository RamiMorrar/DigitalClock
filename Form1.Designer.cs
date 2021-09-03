
namespace DigitalClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LabelTime = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTime.Location = new System.Drawing.Point(110, 213);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(267, 117);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "20:02";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSecond.Location = new System.Drawing.Point(376, 232);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(98, 80);
            this.labelSecond.TabIndex = 1;
            this.labelSecond.Text = "22";
            this.labelSecond.Click += new System.EventHandler(this.labelSecond_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDate.Location = new System.Drawing.Point(120, 330);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(251, 39);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "September 2 2021";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDay.Location = new System.Drawing.Point(364, 330);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(139, 39);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Thursday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1057, 489);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.LabelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Timer timer;
    }
}

