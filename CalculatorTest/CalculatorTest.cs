using Xunit;
using String_Calculator_Kata;

namespace Calculator_Test
{
    public class CalculatorShould
    {
        [Fact]
        public void AddNumbersInStringWithEmptyString()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("");

            Assert.Equal(0, x);
        }
        [Fact]
        public void AddNumbersInStringWithOneNumber()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("2");

            Assert.Equal(2, x);
        }
        [Fact]
        public void AddNumbersInStringWithTwoNumbers()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1,2");
             
            Assert.Equal(3, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1\n2");

            Assert.Equal(3, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter1()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1\n2,3");

            Assert.Equal(6, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter22()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("//;\n1;2;8");

            Assert.Equal(11, x);
        }
    }
}
