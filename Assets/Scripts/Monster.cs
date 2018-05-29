using System.Xml;
using System.Xml.Serialization;

public class Monster
{
    public string Namn;
    public string Namn2;
    public double Prisinklmoms;
    public double Volymiml;
    public double PrisPerLiter;
    public string Varugrupp;
    public string Alkoholhalt;
  
    public Monster(string Namn, string Namn2, double Prisinklmoms, double Volymiml,
                   double PrisPerLiter, string Varugrupp, string Alkoholhalt)
    {
        this.Namn = Namn;
        this.Namn2 = Namn2;
        this.Prisinklmoms = Prisinklmoms;
        this.Volymiml = Volymiml;
        this.PrisPerLiter = PrisPerLiter;
        this.Varugrupp = Varugrupp;
        this.Alkoholhalt = Alkoholhalt;
    }
}