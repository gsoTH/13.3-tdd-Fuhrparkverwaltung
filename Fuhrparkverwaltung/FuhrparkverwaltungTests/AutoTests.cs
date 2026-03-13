using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {

        [TestMethod]
        public void Auto_kannErstelltWerden()
        {
            // Arrange
            int kilometerstand = 10;
            
            // Act
            Auto a = new Auto(kilometerstand);
            
            
            // Assert
            Assert.AreEqual(kilometerstand, a.Kilometerstand);
            
        }
        
        [TestMethod]
        public void Fahren_steigertKilometerstand()
        {
            // Arrange
            Auto a = new Auto(10);
            int streckeInKilometern = 50;
            
            // Act
            a.Fahren(streckeInKilometern);
            
            // Assert
            Assert.AreEqual(60, a.Kilometerstand);
        }
    }
}

