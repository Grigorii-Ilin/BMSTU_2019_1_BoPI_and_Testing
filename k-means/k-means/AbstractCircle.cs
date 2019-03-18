using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_means {
    public abstract class AbstractCircle {
        public int diameter { get; set; }
        public Color color { get; set; }

        private int Radius {
            get {
                return diameter / 2;
            }
        }

        public int[] coords;//0=x 1=y

        public int GetLeftCoord() {
            return coords[0] - Radius;
        }

        public int GetTopCoord() {
            return coords[1] - Radius;
        }

        public Point GetCoord() {
            return new Point(coords[0], coords[1]);
        }

        public bool IsNearClick(int[] clickedCoords) {
            for (int i = 0; i < clickedCoords.Length; i++) {
                int distance = Math.Abs(clickedCoords[i] - coords[i]);
                if (distance > Radius) {
                    return false;
                }
            }
            return true;
        }

        //public abstract AbstractCircle CreateAbstractCircle();
        //public abstract AbstractKMean CreateAbstractKMean();
    }


}
