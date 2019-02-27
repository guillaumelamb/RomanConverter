using System;
using Xunit;

namespace RomanLetters.Tests
{
    public class RomanTest
    {
        [Fact]
        public void Roman_NotNumber()
        {

        }

        [Fact]
        public void Roman_BigNumber()
        {
            Assert.True(RomanConverter.ToRoman(99999999) == "");
        }

        [Fact]
        public void Roman_Empty()
        {
            //Assert.True(RomanConverter.ToRoman() == "");
        }

        [Fact]
        public void Roman_0()
        {
            Assert.True(RomanConverter.ToRoman(0) == "");
        }

        [Fact]
        public void Roman_1()
        {
            Assert.True(RomanConverter.ToRoman(1) == "I");
        }

        [Fact]
        public void Roman_2()
        {
            Assert.True(RomanConverter.ToRoman(2) == "II");
        }

        [Fact]
        public void Roman_3()
        {
            Assert.True(RomanConverter.ToRoman(3) == "III");
        }

        [Fact]
        public void Roman_4()
        {
            Assert.True(RomanConverter.ToRoman(4) == "IV");
        }

        [Fact]
        public void Roman_5()
        {
            Assert.True(RomanConverter.ToRoman(5) == "V");
        }

        [Fact]
        public void Roman_49()
        {
            Assert.True(RomanConverter.ToRoman(49) == "XLIX");
        }

        [Fact]
        public void Roman_50()
        {
            Assert.True(RomanConverter.ToRoman(50) == "L");
        }

        [Fact]
        public void Roman_99()
        {
            Assert.True(RomanConverter.ToRoman(99) == "XCIX");
        }

        [Fact]
        public void Roman_149()
        {
            Assert.True(RomanConverter.ToRoman(149) == "CXLIX");
        }

        [Fact]
        public void Roman_499()
        {
            Assert.True(RomanConverter.ToRoman(499) == "CDXCIX");
        }

        [Fact]
        public void Roman_3999()
        {
            Assert.True(RomanConverter.ToRoman(3999) == "MMMCMXCIX");
        }
    }
}
