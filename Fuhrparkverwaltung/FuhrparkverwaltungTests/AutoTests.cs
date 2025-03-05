using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_steigertKilometerstand()
        {
            // Arrange
            int kilometerstand = 10;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;
            
            // Act
            a.Fahren(streckeInKilometern);
            
            // Assert
            Assert.AreEqual(60, a.Kilometerstand);
        }
    }
}

