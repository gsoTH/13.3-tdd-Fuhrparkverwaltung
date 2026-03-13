namespace Fuhrparkverwaltung;

public class Auto
{
    private int kilometerstand;

    public Auto(int kilometerstand)
    {
        this.kilometerstand = kilometerstand;
    }
    
    public int Kilometerstand { get { return kilometerstand; } }

    public void Fahren(int streckeInKilometern)
    {
        this.kilometerstand += streckeInKilometern;
    }
}