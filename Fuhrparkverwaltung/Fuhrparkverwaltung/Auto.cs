namespace Fuhrparkverwaltung;

public class Auto
{
    private int kilometerstand;
    private double tankinhaltInLitern;
    private double verbrauchPro100Km;

    public Auto(int kilometerstand)
    {
        this.kilometerstand = kilometerstand;
    }

    public Auto(int kilometerstand, double tankinhaltInLitern, double verbrauchPro100Km):this(kilometerstand)
    {
        this.tankinhaltInLitern = tankinhaltInLitern;
        this.verbrauchPro100Km = verbrauchPro100Km;
    }
    
    public int Kilometerstand { get { return kilometerstand; } }
    public double TankinhaltInLitern { get { return tankinhaltInLitern; } }
    public double VerbrauchPro100Km { get { return verbrauchPro100Km; } }
    

    public void Fahren(int streckeInKilometern)
    {
        if (streckeInKilometern > 0)
        {
            tankinhaltInLitern -= streckeInKilometern*(verbrauchPro100Km/100);
            kilometerstand += streckeInKilometern;
        }
    }
}