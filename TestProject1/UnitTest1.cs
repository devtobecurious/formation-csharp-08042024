using CalculTvaAvecDelegues;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestTampon()
        {
            Assert.Equal(1, 1);
        }

        [Fact(DisplayName = "Nous testons ici l'égalité")]
        public void ShouldValidate2Plus2()
        {
            // Arrange
            var calculeur = new CalculerTTC();

            // Act
            var result = calculeur.Calculer(10);

            // Assert
            Assert.Equal(12, result);
        }

    }
}