using System;

namespace src.p001_MultiplesOf3And5 {
    public class MultiplesOf3And5 {
        public int GetSumBelow (int edge) {
            if (edge == 0) return 0;
            int valueToCheck = (edge - 1);
            
            return FilteredValue(valueToCheck) + GetSumBelow (valueToCheck);
        }

        private int FilteredValue(int value)
        {
            return (IsMultipleOf3(value) || IsMultipleOf5(value)) ? value : 0;
        }

        private static bool IsMultipleOf5(int value)
        {
            return value % 5 == 0;
        }

        private static bool IsMultipleOf3(int value)
        {
            return value % 3 == 0;
        }
    }
}