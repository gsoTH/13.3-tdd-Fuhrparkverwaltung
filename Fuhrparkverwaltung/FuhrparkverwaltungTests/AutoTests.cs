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
        
        
        [TestMethod] public void Auto_kannErzeugtWerdentMitKilometerstandTankinhaltVerbrauch() 
        {
            // Arrange
            int kilometerstand = 10;
            double tankinhaltInLitern = 40;
            double verbrauchPro100Km = 5.3;
            
            // Act
            Auto a = new Auto(kilometerstand, tankinhaltInLitern, verbrauchPro100Km);

            // Assert
            Assert.AreEqual(kilometerstand, a.Kilometerstand);
            Assert.AreEqual(tankinhaltInLitern, a.TankinhaltInLitern);
            Assert.AreEqual(verbrauchPro100Km, a.VerbrauchPro100Km);
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
        
        
        [TestMethod]
        public void Fahren_negativeStreckeWirdIgnoriert()
        {
            // Arrange
            Auto a = new Auto(10);
            
            // Act
            a.Fahren(-1);
            
            // Assert
            Assert.AreEqual(10, a.Kilometerstand);
        }
        
        [TestMethod]
        public void Fahren_senktTankinhaltEntsprechendVerbrauch() 
        {
            //Arrange
            int kilometerstand = 10;
            double tankinhaltInLitern = 10.0;
            double verbrauchPro100Km = 5.7;
            Auto a = new Auto(kilometerstand,tankinhaltInLitern,verbrauchPro100Km);

            //Act
            a.Fahren(100);

            //Assert
            Assert.AreEqual(4.3, a.TankinhaltInLitern);
        }
        
        [TestMethod]
        public void Fahren_tankinhaltWirdNichtNegativ() 
        {
            //Arrange
            int kilometerstand = 10;
            double tankinhaltInLitern = 5.7;
            double verbrauchPro100Km = 5.7;
            Auto a = new Auto(kilometerstand,tankinhaltInLitern,verbrauchPro100Km);

            //Act
            a.Fahren(101);

            //Assert
            Assert.AreEqual(0, a.TankinhaltInLitern);
        }
        
        [TestMethod]
        public void Fahren_nurSoWeitDerTankReicht() 
        {
            //Arrange
            int kilometerstand = 0;
            double tankinhaltInLitern = 8.0;
            double verbrauchPro100Km = 10.0;
            Auto a = new Auto(kilometerstand,tankinhaltInLitern,verbrauchPro100Km);

            //Act
            a.Fahren(100);

            //Assert
            Assert.AreEqual(80, a.Kilometerstand);
        }
    }
}

