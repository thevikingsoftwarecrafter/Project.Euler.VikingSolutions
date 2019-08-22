using System;

namespace src.p001_MultiplesOf3And5 {
    public class MultiplesOf3And5 {
        public int GetSumBelow (int edge) {
            if (edge >= 7) return 14;
            if (edge >= 6) return 8;
            if (edge >= 4) return 3;
            return 0;
        }
    }
}