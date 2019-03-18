using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph {
    public partial class Form1 : Form {
        private List<MyCircle> circles;
        private List<Way> ways;

        private void AddCircle(int[] clickCoords) {
            if (circles.FirstOrDefault(c=>c.IsNearClick(clickCoords))!=null) {
                return;
            }
            circles.Add(new MyCircle(clickCoords));
        }

        private void DeleteCircle(int[] clickCoords) {
            circles.RemoveAll(c => c.IsNearClick(clickCoords));
            ways.RemoveAll(w => w.circlePair[0].IsNearClick(clickCoords) || w.circlePair[1].IsNearClick(clickCoords));
        }

        private void SelectCircleOrCreateWay(int[] clickCoords) {
            MyCircle wasSelectedCircle = circles.FirstOrDefault(c => c.IsSelected);

            if (wasSelectedCircle != null) {
                wasSelectedCircle.IsSelected = false;

                if (!wasSelectedCircle.IsNearClick(clickCoords)) {
                    foreach (MyCircle c in circles) {
                        if (c.IsNearClick(clickCoords)) {
                            ways.Add(new Way(wasSelectedCircle, c));
                            break;
                        }
                    }
                }
            }
            else {
                foreach (MyCircle c in circles) {
                    if (c.IsNearClick(clickCoords)) {
                        c.IsSelected = true;
                        break;
                    }
                }
            }
        }

        private void SetStartOrStopCircle(int[] clickCoords, CircleType typ) {
            MyCircle clickedCircle = circles.FirstOrDefault(c => c.IsNearClick(clickCoords));
            if (clickedCircle!=null) {
                foreach (MyCircle c in circles) {
                    if (c.typ == typ) {
                        c.typ = CircleType.Usual;
                    }
                }

                clickedCircle.typ = typ;
            }
        }
        


            public Form1() {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            int[] clickCoords = new int[] { e.X, e.Y };

            if (rbCreateCircle.Checked) {
                this.AddCircle(clickCoords);
            }
            else if (rbDeleteCircle.Checked) {
                this.DeleteCircle(clickCoords);
            }
            else if (rbCreateWay.Checked) {
                this.SelectCircleOrCreateWay(clickCoords);
             }
            else if (rbStartCircle.Checked) {
                this.SetStartOrStopCircle(clickCoords, CircleType.Start);
            }
            else if (rbEndCircle.Checked) {
                this.SetStartOrStopCircle(clickCoords, CircleType.End);
            }

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e) {
            circles = new List<MyCircle>();
            ways= new List<Way>();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            foreach (MyCircle c in circles) {
                SolidBrush brush = new SolidBrush(c.GetColor());  
                Rectangle rect = new Rectangle(c.GetLeftCoord(), c.GetTopCoord(), MyCircle.DIAMETER, MyCircle.DIAMETER);
                e.Graphics.FillEllipse(brush, rect);
            }

            foreach (Way w in ways) {
                Pen pen = new Pen(w.GetColor(), 3);
                e.Graphics.DrawLine(pen, w.GetPoint(0), w.GetPoint(1));
            }
        }

        private void btOk_Click(object sender, EventArgs e) {
            MyGraph g = new MyGraph(circles, ways);
            g.Calc();
            for (int i = 0; i < g.bestWayIndexses.Count(); i++) {
                ways[i].isBest = true;
            }
            int len = (int)g.minWayLen;
            lbWayLen.Text = len.ToString();

            this.Invalidate();
        }
    }
}
