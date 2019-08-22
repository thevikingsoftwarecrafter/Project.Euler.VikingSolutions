using System;
using System.Collections.Generic;
using src.p001_MultiplesOf3And5;
using Xunit;

namespace test.p001_MultiplesOf3And5 {
    public class MultiplesOf3And5Should {

        [Theory]
        [InlineData (3, 0)]
        [InlineData (4, 3)]
        [InlineData (5, 3)]
        [InlineData (6, 8)]
        [InlineData (7, 14)]
        public void GetAllMultiplesBelowEdge (int edge, int expected) {
            //Arrange
            MultiplesOf3And5 multiplesOf3And5 = new MultiplesOf3And5 ();

            //Act
            int actual = multiplesOf3And5.GetSumBelow (edge);

            //Assert
            Assert.Equal (expected, actual);
        }
    }
}