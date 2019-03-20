using k_means;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_meansTest{
    [TestFixture]
    public class MyCircleTests {

        [TestCase(105, 105, true)]
        [TestCase(105, 5, false)]
        public void IsNearClick_VariousCoords_ChecksThem(int x, int y, bool excepted) {
            int[] circleCoords = new int[] { 100, 100 }; //arrange
            var myCircle = new MyCircle(circleCoords);

            bool result = myCircle.IsNearClick(new int[] { x, y });//act

            Assert.AreEqual(excepted, result);//assert
        }


    }
}
