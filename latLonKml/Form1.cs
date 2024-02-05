using System;
using System.Windows.Forms;
using aviationLib;

namespace latLonKml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crs2pnt_Click(object sender, EventArgs e)
        {
            LatLon ll = new LatLon(latitude.Text, longitude.Text);

            LatLon nll = ll.PointFromHeadingDistance(Convert.ToDouble(distance.Text) * 1.15, Convert.ToDouble(bearing.Text));

            crs2PntAnswer.Text = nll.decimalLat.ToString("F6") + "~" + nll.decimalLon.ToString("F6");
        }

        private void calcCourse_Click(object sender, EventArgs e)
        {
            String[] fllt = fromPoint.Text.Split(',');
            LatLon fll = new LatLon(fllt[0], fllt[1]);

            String[] tllt = toPoint.Text.Split(',');
            LatLon tll = new LatLon(tllt[0], tllt[1]);

            Double c = fll.TrueCourse(tll);
            course.Text = c.ToString("F0");
        }
    }
}
