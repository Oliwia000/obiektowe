using System;

class Osoba
{
   protected string imie;
   protected string nazwisko;
   protected string dataUrodzenia;

    public Osoba(string imie, string nazwisko, string dataUrodzenia)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.dataUrodzenia = dataUrodzenia;
    }
    public virtual void WypiszInfo()
    {
        Console.WriteLine($"Imię: {imie} , Nazwisko: {nazwisko} , Data Urodzenia: {dataUrodzenia}");
    }

class Student : Osoba {

        private int rok;
        private int grupa;
        private  int nrindeksu;

    public Student (string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrindeksu)
        :base (imie, nazwisko, dataUrodzenia)
    {
        
        this.rok = rok;
        this.grupa = grupa;
        this.nrindeksu = nrindeksu;
    }
    public  override void WypiszInfo()
    { 
        base.WypiszInfo();
        Console.WriteLine($"Rok: {rok} , Grupa: {grupa} , Nr Indeksu: {nrindeksu}");
    }
}

class Pilkarz:Osoba
{
      private  string pozycja;
      private string klub;
      private  int liczbaGoli;

    public Pilkarz(string imie, string nazwisko, string dataUrodzenia,string pozycja, string klub)
        : base (imie, nazwisko, dataUrodzenia)
    {
        this.pozycja = pozycja;
        this.klub = klub;
        liczbaGoli = 0;
    }
    public override void WypiszInfo()
    {
        base.WypiszInfo();
        Console.WriteLine($"Pozycja: {pozycja} , Klub : {klub} , Liczba Goli: {liczbaGoli}");
    } 
    public void StrzelGola()
    {
        liczbaGoli++; 
    }
}

    class Program
    {
        public static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Jan", "Kowalski", "14.07.1997");
            Osoba student = new Student("Krystian", "Nowak", "21.02..2024", 2, 5, 252355);
            Osoba pilkarz = new Pilkarz("Robert", "Lewqandowksi", "21.08.1988", "napastnik", "FC Barcelona");
            osoba.WypiszInfo();
            student.WypiszInfo();
            pilkarz.WypiszInfo();

            Student student2 = new Student("Jan", "Kaczyński", "15.08.2003", 2, 1, 212542);
            Pilkarz pilkarz2 = new Pilkarz("Wojciech", "Szczęsny", "18.04.1990", "bramkarz", "FC Barcelona");

            student2.WypiszInfo();
            pilkarz2.WypiszInfo();

            ((Pilkarz)pilkarz).StrzelGola();
            pilkarz2.StrzelGola();
            pilkarz2.StrzelGola();

            pilkarz.WypiszInfo();
            pilkarz2.WypiszInfo();

            Console.ReadKey();
        }
    }


}
