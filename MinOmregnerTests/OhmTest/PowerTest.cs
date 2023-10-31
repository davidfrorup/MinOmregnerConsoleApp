using MinOmregnerConsoleApp;
using NUnit.Framework;
using System;

namespace MinOmregnerTests
{
    public class Tests
    {

        private CalcPower temp;


        [SetUp]
        public void Setup()
        {
            temp = new CalcPower();
        }

        [Test]
        public void GetPowerByVoltageAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = V^2 / R

            // Act
            var result = temp.GetPowerByVoltageAndResistance(10, 100);

            // Assert
            Assert.AreEqual(1, result); //1
            
        }

        [Test]
        public void GetPowerByVoltageAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = V * I

            // Act
            var result = temp.GetPowerByVoltageAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(1000, result); //1000

        }

        [Test]
        public void GetPowerByResistensAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = I^2 * R

            // Act
            var result = temp.GetPowerByResistanceAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(10000, result); //10.000

        }
    }
}

