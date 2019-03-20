// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_means {
    public class MyCircle:AbstractCircle {
        public MyCircle(int[] clickCoords) {
            coords = new int[clickCoords.Length];
            for (int i = 0; i < clickCoords.Length; i++) { // Length=2 (x,y)         
                coords[i] = clickCoords[i]; // 0= x , 1= y
            }
            Diameter = 10;
            Color = Color.Green;           
        }


        private double GetWayLen(Point anotherPoint) {
            int catetX = this.GetCoord().X - anotherPoint.X;
            int catetY = this.GetCoord().Y - anotherPoint.Y;

            return Math.Sqrt(Math.Pow(catetX, 2) + Math.Pow(catetY, 2));
        }

        public void CalcKMeansForCircles(List<Cluster> kMeans) {
            double bestDistance = 1000000;
            foreach (var k in kMeans) {
                double curDistance = GetWayLen(k.GetCoord());
                if (curDistance < bestDistance) {
                    bestDistance = curDistance;
                    this.Color = k.Color;
                }
            }
        }
    }
}
