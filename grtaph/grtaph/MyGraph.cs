using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph {
    class MyGraph {
        public double minWayLen { get; set; }
        public int[] bestWayIndexses;

        private List<MyCircle> cs;
        private List<Way> ws;
        private MyCircle endCircle;

        public MyGraph(List<MyCircle> circles, List<Way> ways) {
            cs = circles;
            ws = ways;
        }

        private bool WasCheckedWay(int checkedWayIndex, LinkedList<int> currentWayIndexes) {
            foreach (int index in currentWayIndexes) {
                if (checkedWayIndex == index) {
                    return true;
                }
            }
            return false;
        }

        private void GreedyAlg(MyCircle curCircle, LinkedList<int> currentWayIndexes, double currentWayLen) {//, int[] checkedWaysIndexes,  int minWayCurrent, int minWayBest) {
            for (int i = 0; i < ws.Count; i++) {
                if (WasCheckedWay(i, currentWayIndexes)) {
                    continue;
                }

                for (int j = 0; j < ws[i].circlePair.Length; j++) {
                    if (curCircle == ws[i].circlePair[j]) {
                        int anotherCircleIndex = Math.Abs(j - 1);
                        currentWayLen += ws[i].WayLen;
                        currentWayIndexes.AddLast(i);

                        if (ws[i].circlePair[anotherCircleIndex].typ == CircleType.End) {
                            if (currentWayLen < minWayLen) {
                                minWayLen = currentWayLen;
                                bestWayIndexses = new int[currentWayIndexes.Count];
                                currentWayIndexes.CopyTo(bestWayIndexses, 0);
                            }
                            else {
                                currentWayIndexes.RemoveLast();
                            }                          
                        }
                        else {
                            GreedyAlg(ws[i].circlePair[anotherCircleIndex], currentWayIndexes, currentWayLen);
                        }
                    }
                }               
            }
        }

        public void Calc() {
            MyCircle startCircle = cs.FirstOrDefault(c => c.typ == CircleType.Start);
            endCircle = cs.FirstOrDefault(c => c.typ == CircleType.End);

            if (startCircle == null || endCircle == null) {
                return;
            }

            minWayLen = 1000000000.0;

            LinkedList<int> currentWayIndexses = new LinkedList<int>();
            GreedyAlg(startCircle, currentWayIndexses, 0.0);
        }

    }
}
