using System;

namespace BuilderCalisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaBuilder araba = new Opel();
            ArabaUret arabaUret = new ArabaUret();
            arabaUret.Uret(araba);
            araba.Yazdir();
        }
    }
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public string Vites { get; set; }
    }


    abstract class ArabaBuilder
    {
        protected Araba araba;
    
        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
        public void Yazdir()
        {
            Console.WriteLine(araba.KM+" "+araba.Marka+" "+araba.Model+" "+araba.Vites);
        }
    }
    class Opel : ArabaBuilder
    {
        public Opel()
        {
            araba = new Araba();
        }
        public override void SetKM()
        {
            araba.KM = 100;
        }

        public override void SetMarka()
        {
            araba.Marka="opel";

        }

        public override void SetModel()
        {
            araba.Model= "Astra";

        }

        public override void SetVites()
        {
            araba.Vites = "otomatik";
        }
    }
    class Toyota : ArabaBuilder
    {
        public Toyota()
        {
            araba = new Araba();
        }
        public override void SetKM()
        {
            araba.KM = 100;
        }

        public override void SetMarka()
        {
            araba.Marka = "toyota";

        }

        public override void SetModel()
        {
            araba.Model = "x";

        }

        public override void SetVites()
        {
            araba.Vites = "otomatik";
        }

    }
    class ArabaUret
    {
        public void Uret(ArabaBuilder arabaBuilder)
        {
            arabaBuilder.SetKM();
            arabaBuilder.SetMarka();
            arabaBuilder.SetModel();
            arabaBuilder.SetVites();
        }
    }
}
