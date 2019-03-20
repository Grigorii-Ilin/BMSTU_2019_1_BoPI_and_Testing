using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_means {
    public class Cluster:AbstractCircle {
        public Cluster(int[] clickCoords) {
            coords = new int[clickCoords.Length];
            for (int i = 0; i < clickCoords.Length; i++) { // Length=2 (x,y)         
                coords[i] = clickCoords[i]; // 0= x , 1= y
            }

            Diameter = 16;

            var rnd = new Random();
            const int COLOR_MAX = 256;
            Color = Color.FromArgb(rnd.Next(COLOR_MAX), rnd.Next(COLOR_MAX), rnd.Next(COLOR_MAX));
        }

        public void KMeansMove(List<MyCircle> circles) {
            var curCircles = circles.FindAll(c => c.Color == this.Color);
            if (curCircles.Count <= 0) {
                return;
            }

            for (int i = 0; i < this.coords.Length; i++) {
                this.coords[i] = 0; 
            }

            foreach (var c in curCircles) {
                for (int i = 0; i < c.coords.Length; i++) {
                    this.coords[i] += c.coords[i];
                }
            }
            for (int i = 0; i < this.coords.Length; i++) {
                this.coords[i] /= curCircles.Count;
            }
        }
    }
}
