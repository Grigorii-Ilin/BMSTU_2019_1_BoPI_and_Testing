using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graph {

    enum CircleType {
        Start,
        Usual,
        End
    }

    class MyCircle {
        public const int DIAMETER = 20;
        public const int RADIUS = DIAMETER / 2;

        public bool IsSelected { get; set; }
        public CircleType typ { get; set; }

        private int[] coords;//0=x 1=y
        //private Color Cl; //{ get; set; }


        public MyCircle(int[] clickCoords) {
            coords = new int[clickCoords.Length];
            for (int i = 0; i < clickCoords.Length; i++){ // Length=2 (x,y)         
                coords[i] = clickCoords[i]; // 0= x , 1= y
            }

            IsSelected = false;
            typ = CircleType.Usual;
        }

        public Color GetColor() {
            if (IsSelected) {
                return Color.Red;
            }

            switch (typ) {
            case CircleType.Start:
                return Color.Black;
            case CircleType.End:
                return Color.Orange;
            default:
                return Color.Green;
            }
        }

        public int GetLeftCoord() {
            return coords[0] - RADIUS;
        }

        public int GetTopCoord() {
            return coords[1] - RADIUS;
        }

        public Point GetCoord() {
            //Point p = new Point();
            //p.X = coords[0];
            //p.Y= coords[1];
            //return p;
            return new Point(coords[0], coords[1]);
        }

        public bool IsNearClick(int[] clickedCoords) {
            for (int i = 0; i < clickedCoords.Length; i++) {
                int distance = Math.Abs(clickedCoords[i] - coords[i]);
                if (distance > RADIUS) {
                    return false;
                }
            }
            return true;
        }
    }
}
