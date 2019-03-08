using System;
using BabySitterPayCalculator.Domain;
using Shouldly;
using Xunit;

namespace BabySitterPayCalculatorTests
{
    public class PayCalculatorTests
    {

        [Fact]
        public void WhenInstantiatingCalculatorIsNotNull()
        {
            var testStart = 5;
            var testEnd = 8;
            var calculator = new PayCalculator(testStart, testEnd);
            
            calculator.ShouldNotBeNull();
        }

        [Fact]
        public void WhenCalculatingEveningPayReturnsEveningRateTimesTotalHours()
        {
            var testStart = 5;
            var testEnd = 8;
            var calculator = new PayCalculator(testStart, testEnd);

            var result = calculator.CalculatePay();

            result.ShouldBe(3 * 11);
        }

        [Fact]
        public void WhenCalculationNightPayReturnsNightRateTimesTotalHours()
        {
            var testStart = 10;
            var testEnd = 11;
            var calculator = new PayCalculator(testStart, testEnd);

            var result = calculator.CalculatePay();
            
            result.ShouldBe(1 * 13);
        }

        [Fact]
        public void WhenCalculatingNightAndEveningPayReturnsEveningRatePlusNightRate()
        {
            var testStart = 9;
            var testEnd = 11;
            var calculator = new PayCalculator(testStart, testEnd);

            var result = calculator.CalculatePay();
            
            result.ShouldBe(11 + 13);
        }

        [Fact]
        public void WhenCalculatingAfternoonHoursReturnsAfternoonRateTimesTotal()
        {
            var testStart = 1;
            var testEnd = 4;
            var calculator = new PayCalculator(testStart, testEnd);

            var result = calculator.CalculatePay();
            
            result.ShouldBe(3 * 7);
        }

        [Fact]
        public void WhenCalculatingFullDayPayReturnsMaxPay()
        {
            var testStart = 1;
            var testEnd = 12;
            var calculator = new PayCalculator(testStart, testEnd);

            var result = calculator.CalculatePay();
            
            result.ShouldBe(109);
        }
    }
}