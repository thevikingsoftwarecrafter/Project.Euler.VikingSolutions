using System;
using src.p001_MultiplesOf3And5;
using Xunit;

namespace test.p001_MultiplesOf3And5 {
    public class MultiplesOf3And5Should {
        [Fact]
        public void GetAllMultiplesBelowEdge () {
            //Arrange
            MultiplesOf3And5 multiplesOf3And5 = new MultiplesOf3And5 ();

            //Act
            int[] actual = multiplesOf3And5.GetAllBelow (4);

            //Assert
            Assert.Equal (new [] { 3 }, actual);
        }
    }
}