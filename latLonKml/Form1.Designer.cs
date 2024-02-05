namespace latLonKml
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
            this.latitude = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.crs2PntAnswer = new System.Windows.Forms.TextBox();
            this.calcCrs2Pnt = new System.Windows.Forms.Button();
            this.bearing = new System.Windows.Forms.TextBox();
            this.fromPoint = new System.Windows.Forms.TextBox();
            this.toPoint = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.calcCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(81, 13);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(206, 20);
            this.latitude.TabIndex = 0;
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(81, 40);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(206, 20);
            this.longitude.TabIndex = 1;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(103, 66);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(92, 20);
            this.distance.TabIndex = 2;
            // 
            // crs2PntAnswer
            // 
            this.crs2PntAnswer.Location = new System.Drawing.Point(81, 94);
            this.crs2PntAnswer.Name = "crs2PntAnswer";
            this.crs2PntAnswer.Size = new System.Drawing.Size(206, 20);
            this.crs2PntAnswer.TabIndex = 4;
            // 
            // calcCrs2Pnt
            // 
            this.calcCrs2Pnt.Location = new System.Drawing.Point(212, 120);
            this.calcCrs2Pnt.Name = "calcCrs2Pnt";
            this.calcCrs2Pnt.Size = new System.Drawing.Size(75, 23);
            this.calcCrs2Pnt.TabIndex = 5;
            this.calcCrs2Pnt.Text = "Crs2Pnt";
            this.calcCrs2Pnt.UseVisualStyleBackColor = true;
            this.calcCrs2Pnt.Click += new System.EventHandler(this.crs2pnt_Click);
            // 
            // bearing
            // 
            this.bearing.Location = new System.Drawing.Point(201, 66);
            this.bearing.Name = "bearing";
            this.bearing.Size = new System.Drawing.Size(86, 20);
            this.bearing.TabIndex = 3;
            // 
            // fromPoint
            // 
            this.fromPoint.Location = new System.Drawing.Point(81, 151);
            this.fromPoint.Name = "fromPoint";
            this.fromPoint.Size = new System.Drawing.Size(206, 20);
            this.fromPoint.TabIndex = 6;
            // 
            // toPoint
            // 
            this.toPoint.Location = new System.Drawing.Point(81, 177);
            this.toPoint.Name = "toPoint";
            this.toPoint.Size = new System.Drawing.Size(206, 20);
            this.toPoint.TabIndex = 7;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(81, 203);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(100, 20);
            this.course.TabIndex = 8;
            // 
            // calcCourse
            // 
            this.calcCourse.Location = new System.Drawing.Point(212, 229);
            this.calcCourse.Name = "calcCourse";
            this.calcCourse.Size = new System.Drawing.Size(75, 23);
            this.calcCourse.TabIndex = 9;
            this.calcCourse.Text = "Course";
            this.calcCourse.UseVisualStyleBackColor = true;
            this.calcCourse.Click += new System.EventHandler(this.calcCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Distance Bearing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "From Lat,Lon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "To Lat,Lon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcCourse);
            this.Controls.Add(this.course);
            this.Controls.Add(this.toPoint);
            this.Controls.Add(this.fromPoint);
            this.Controls.Add(this.bearing);
            this.Controls.Add(this.calcCrs2Pnt);
            this.Controls.Add(this.crs2PntAnswer);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.MaximumSize = new System.Drawing.Size(316, 310);
            this.MinimumSize = new System.Drawing.Size(316, 310);
            this.Name = "Form1";
            this.Text = "LatLonCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox crs2PntAnswer;
        private System.Windows.Forms.Button calcCrs2Pnt;
        private System.Windows.Forms.TextBox bearing;
        private System.Windows.Forms.TextBox fromPoint;
        private System.Windows.Forms.TextBox toPoint;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Button calcCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

