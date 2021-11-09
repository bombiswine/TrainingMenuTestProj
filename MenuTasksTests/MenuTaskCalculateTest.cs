using NUnit.Framework;
using TrainingMenu.MenuItems;

namespace Test.TrainingMenu.MenuTasksTests
{
    [TestFixture]
    public class MenuTaskCalculateTest
    {
        [TestCase(4, 2, 8, 0.0d)]
        [TestCase(4, -5, 14, -0.5d)]
        [TestCase(1, 6, -5, -1.0d)]
        public void Calculation_Validate_Correctly(int iX, int iY, int iZ, double dResult)
        { 
            Assert.AreEqual(MenuTaskCalculate.CalculateTheFormula(iX, iY, iZ), dResult, delta : double.Epsilon); 
        }
    }
}
