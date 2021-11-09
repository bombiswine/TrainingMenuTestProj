using NUnit.Framework;
using TrainingMenu;
using TrainingMenu.MenuItems;

namespace Test.TrainingMenu.MenuTasksTests
{
    [TestFixture]
    public class MenuTaskStringProcessingTest
    {
        /************************************************
         *         Tests for "AreEqual" method          *
         ************************************************/
        [TestCase("Bel Ami", "Bel Ami")]
        [TestCase("+7(900)671-21-85", "+7(900)671-21-85")]
        public void AreEqual_Validate(string s1, string s2)
        {
            MenuTaskStringsProcessing.AreEqual(s1, s2);
        }

        [TestCase("Bel Ami", "Let f is an injection")]
        [TestCase("+7(900)671-21-85", "aMerson@box.com")]
        public void AreEqual_Throws_ValidationEx(string s1, string s2)
        {
            Assert.That(() => MenuTaskStringsProcessing.AreEqual(s1, s2), Throws.TypeOf<ValidationException>());
        }

        /************************************************
         *  Tests for "AreEqualAfterModifying" method   *
         ************************************************/
        [TestCase("   BeL   AMI  ", "bel ami")]
        [TestCase("Aunt Rumpumpel", "  aUnT rUmPuMpEl")]
        public void AreEqualAfterModifying_Validate(string s1, string s2)
        {
            MenuTaskStringsProcessing.AreEqualAfterModifying(s1, s2);
        }

        [TestCase("Bel Ami", "Let f is an injection")]
        [TestCase("+7(900)671-21-85", "aMerson@box.com")]
        public void AreEqualAfterModifying_Throws_ValidationEx(string s1, string s2)
        {
            Assert.That(() => MenuTaskStringsProcessing.AreEqualAfterModifying(s1, s2), Throws.TypeOf<ValidationException>());
        }

        /************************************************
        *      Tests for "AreFlipStrings" method        *
        ************************************************/
        [TestCase("imA leB", "Bel Ami")]
        [TestCase("2002", "2002")]
        public void AreFlipStrings_Validate(string s1, string s2)
        {
            MenuTaskStringsProcessing.AreFlipStrings(s1, s2);
        }

        [TestCase("Bel Ami", "Let f is an injection")]
        [TestCase("+7(900)671-21-85", "aMerson@box.com")]
        public void AreFlipStrings_Throws_ValidationEx(string s1, string s2)
        {
            Assert.That(() => MenuTaskStringsProcessing.AreFlipStrings(s1, s2), Throws.TypeOf<ValidationException>());
        }
    }
}
