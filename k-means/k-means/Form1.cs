// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_means {
    public partial class Form1 : Form {
        private static List<MyCircle> circles;
        private static List<Cluster> kMeans;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            int[] clickCoords = new int[] { e.X, e.Y };

            if (rbAdd.Checked) {
                if (chbCluster.Checked) {
                    kMeans.Add(new Cluster( clickCoords));
                }
                else {
                    circles.Add(new MyCircle(clickCoords));
                }
            }
            if (rbDelete.Checked) {
                if (chbCluster.Checked) {
                    kMeans.RemoveAll(c => c.IsNearClick(clickCoords));
                }
                else {
                    circles.RemoveAll(c => c.IsNearClick(clickCoords));
                }
            }

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e) {
            circles = new List<MyCircle>();
            kMeans = new List<Cluster>();

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            //if (circles!=null) {
            foreach (MyCircle c in circles) {
                SolidBrush brush = new SolidBrush(c.color);
                Rectangle rect = new Rectangle(c.GetLeftCoord(), c.GetTopCoord(), c.diameter, c.diameter);
                e.Graphics.FillEllipse(brush, rect);
            }
            //}


            //if (kMeans!=null) {
            foreach (var k in kMeans) {
                SolidBrush brush = new SolidBrush(k.color);
                Rectangle rect = new Rectangle(k.GetLeftCoord(), k.GetTopCoord(), k.diameter, k.diameter);
                e.Graphics.FillRectangle(brush, rect);
            }
            //}

            
        }

        private void btOK_Click(object sender, EventArgs e) {
            for (int i = 0; i < 10; i++) {
                foreach (var c in circles) {
                    c.CalcKMeansForCircles(kMeans);
                }

                foreach (var k in kMeans) {
                    k.KMeansMove(circles);
                }

                this.Invalidate();
                //Thread.Sleep(3000);

            }
        }
    }
}
