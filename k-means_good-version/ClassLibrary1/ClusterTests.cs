using k_means;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_meansTest {
    [TestFixture]
    class ClusterTests {

        [TestCase]
        public void KMeansMove_NewCoordinates_CheckThem() {
            Color cl = Color.Red;

            var circles = new List<MyCircle>(); //arrange
            circles.Add(new MyCircle(new int[] { 2, 3 }));
            circles.Add(new MyCircle(new int[] { 4, 5 }));

            foreach (var c in circles) {
                c.Color = cl;
            }

            var clusterCoords = new int[] { 100, 200 };
            var cluster = new Cluster(clusterCoords);
            cluster.Color = cl;

            cluster.KMeansMove(circles); //act

            Assert.AreEqual(3, cluster.coords[0]);//assert
            Assert.AreEqual(4, cluster.coords[1]);
        }

        [TestCase]
        public void KMeansMove_NoCirclesSameCoords_ReturnsTrue() {
            var circles = new List<MyCircle>(); //arrange

            var clusterCoords = new int[] { 100, 200 };
            var cluster = new Cluster(clusterCoords);

            cluster.KMeansMove(circles); //act

            Assert.AreEqual(100, cluster.coords[0]);//assert
            Assert.AreEqual(200, cluster.coords[1]);
        }
    }
}
