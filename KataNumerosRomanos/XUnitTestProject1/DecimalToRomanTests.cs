using System;
using Xunit;
using KataNumerosRomanos;

namespace XUnitTestProject1
{
    public class DecimalToRomanTests
    {
        private KataNumerosRomanos.Decimal decimalToRoman;
        public DecimalToRomanTests()
        {
            decimalToRoman = new KataNumerosRomanos.Decimal();
        }

        [Fact]
        public void GiveNumber_1_Return_I()
        {
            var result = decimalToRoman.ToRoman(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void GivenNumber_2_ShouldReturn_II()
        {
            var result = decimalToRoman.ToRoman(2);

            Assert.Equal("II", result);
        }

        [Fact]
        public void GivenNumber_3_ShouldReturn_III()
        {
            var result = decimalToRoman.ToRoman(3);

            Assert.Equal("III", result);
        }

        [Fact]
        public void GivenNumber_1000_ShouldReturn_M()
        {
            var result = decimalToRoman.ToRoman(1000);

            Assert.Equal("M", result);
        }

        [Fact]
        public void GivenNumber_500_ShouldReturn_D()
        {
            var result = decimalToRoman.ToRoman(500);

            Assert.Equal("D", result);
        }

        [Fact]
        public void GivenNumber_100_ShouldReturn_C()
        {
            var result = decimalToRoman.ToRoman(100);

            Assert.Equal("C", result);
        }

        [Fact]
        public void GivenNumber_50_ShouldReturn_L()
        {
            var result = decimalToRoman.ToRoman(50);

            Assert.Equal("L", result);
        }

        [Fact]
        public void GivenNumber_10_ShouldReturn_X()
        {
            var result = decimalToRoman.ToRoman(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void GivenNumber_1532_ShouldReturn_MDXXII()
        {
            var result = decimalToRoman.ToRoman(1532);

            Assert.Equal("MDXXXII", result);
        }

        [Fact]
        public void GivenNumber_9_ShouldReturn_IX()
        {
            var result = decimalToRoman.ToRoman(9);

            Assert.Equal("IX", result);
        }

        [Fact]
        public void GivenNumber_4_ShouldReturn_IV()
        {
            var result = decimalToRoman.ToRoman(4);

            Assert.Equal("IV", result);
        }

        [Fact]
        public void GivenNumber_999_ShouldReturn_CMXCIX()
        {
            var result = decimalToRoman.ToRoman(999);

            Assert.Equal("CMXCIX", result);
        }
    }
}
;