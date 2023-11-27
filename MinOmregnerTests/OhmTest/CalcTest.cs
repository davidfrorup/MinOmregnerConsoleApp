using MinOmregnerConsoleApp;
using MinOmregnerConsoleApp.Calc.Ohmcalc;
using MinOmregnerConsoleApp.Calc.NormalCalc;
using NUnit.Framework;
using System;

namespace MinOmregnerTests
{
    public class Tests
    {

        private CalcPower power;
        private CalcResistance resistance;
        private CalcVoltage voltage;
        private CalcCurrent current;
        private CalcPlus plus;
        private CalcMinus minus;


        [SetUp]
        public void Setup()
        {
            power = new CalcPower();
            resistance = new CalcResistance();
            voltage = new CalcVoltage();
            current = new CalcCurrent();
            plus = new CalcPlus();
            minus = new CalcMinus();
        }

        [Test]
        public void GetPowerByVoltageAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = V^2 / R

            // Act
            var result = power.GetPowerByVoltageAndResistance(10, 100);

            // Assert
            Assert.AreEqual(1, result); // 1
            
        }

        [Test]
        public void GetPowerByVoltageAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = V * I

            // Act
            var result = power.GetPowerByVoltageAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(1000, result); // 1.000

        }

        [Test]
        public void GetPowerByCurrentAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: P = I^2 * R

            // Act
            var result = power.GetPowerByCurrentAndResistance(10, 100);

            // Assert
            Assert.AreEqual(10000, result); // 10.000

        }

        [Test]
        public void GetResistanceByPowerAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: R = P / I^2

            // Act
            var result = resistance.GetResistanceByPowerAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(0.001, result); // 0.001

        }

        [Test]
        public void GetResistanceByVoltageAndPowerTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: R = V^2 / P

            // Act
            var result = resistance.GetResistanceByVoltageAndPower(10, 100);

            // Assert
            Assert.AreEqual(1, result); // 1

        }

        [Test]
        public void GetResistanceByVoltageAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: R = V / I

            // Act
            var result = resistance.GetResistanceByVoltageAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(0.1, result); // 0.1

        }

        [Test]
        public void GetVoltageByCurrentAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: V = I * R

            // Act
            var result = voltage.GetVoltageByCurrentAndResistance(10, 100);

            // Assert
            Assert.AreEqual(1000, result); // 1.000

        }

        [Test]
        public void GetVoltageByPowerAndCurrentTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: V = P / I

            // Act
            var result = voltage.GetVoltageByPowerAndCurrent(10, 100);

            // Assert
            Assert.AreEqual(0.1, result); // 0.1

        }

        [Test]
        public void GetVoltageByPowerAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: V = "kvadratrod"(P * R)

            // Act
            var result = voltage.GetVoltageByPowerAndResistance(10, 100);

            // Assert
            Assert.AreEqual(31.622776601683793, result); // 31.622776601683793

        }

        [Test]
        public void GetCurrentByPowerAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: I = "kvadratrod"(P / R)


            // Act
            var result = current.GetCurrentByPowerAndResistance(10, 100);

            // Assert
            Assert.AreEqual(0.31622776601683794, result); // 0.31622776601683794

        }

        [Test]
        public void GetCurrentByPowerAndVoltageTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: I = P / V

            // Act
            var result = current.GetCurrentByPowerAndVoltage(10, 100);

            // Assert
            Assert.AreEqual(0.1, result); // 0.1

        }

        [Test]
        public void GetCurrentByVoltageAndResistanceTest()
        {
            // Arrange
            // Beregn effekten ved hjælp af Ohms lov: I = V / R

            // Act
            var result = current.GetCurrentByVoltageAndResistance(10, 100);

            // Assert
            Assert.AreEqual(0.1, result); // 0.1

        }

        [Test]
        public void PlusTest()
        {
            // Arrange
            
            // Act
            var result = plus.Plus(10, 100);

            // Assert
            Assert.AreEqual(110, result); // 110

        }

        [Test]
        public void MinusTest()
        {
            // Arrange

            // Act
            var result = minus.Minus(10, 100);

            // Assert
            Assert.AreEqual(-90, result); // -90

        }
    }
}

