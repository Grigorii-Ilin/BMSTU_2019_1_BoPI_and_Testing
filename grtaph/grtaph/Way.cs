using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graph {
    class Way {
        public bool isBest { get; set; }
        public MyCircle[] circlePair;
        public double WayLen { get; set; }

        public Color GetColor() {
            if (isBest) {
                return Color.Blue;
            }
            return Color.Black;
        }


        public Way(MyCircle firstCircle, MyCircle secondCircle) {
            circlePair = new MyCircle[] { firstCircle, secondCircle };
            isBest = false;
            WayLen = GetWayLen();
        }

        public Point GetPoint(int index) {
            return circlePair[index].GetCoord();
        }

        private double GetWayLen() {
            int catetX = circlePair[1].GetCoord().X - circlePair[0].GetCoord().X;
            int catetY = circlePair[1].GetCoord().Y - circlePair[0].GetCoord().Y;

            return Math.Sqrt(Math.Pow(catetX, 2) + Math.Pow(catetY, 2));
        }

    }
}
