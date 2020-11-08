using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02InterfaceImplementation
{
    class Pracownik : IEquatable<Pracownik>
    {
        private string nazwisko;
        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value.Trim();
        }
        private DateTime dataZatrudnienia;
        public DateTime DataZatrudnienia
        {
            get => dataZatrudnienia;
            set
            {
                if (value >= DateTime.Now.Date) dataZatrudnienia = value;
                else throw new ArgumentException();
            }
        }
        private Decimal wynagrodzenie;
        public Decimal Wynagrodzenie { get => wynagrodzenie; set => wynagrodzenie = value >= 0 ? value : 0; }
        public Pracownik(string nazwisko, DateTime dataZatrudnienia, Decimal wynagrodzenie)
        {
            Nazwisko = nazwisko;
            DataZatrudnienia = dataZatrudnienia;
            Wynagrodzenie = wynagrodzenie;
        }
        public Pracownik()
        {
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Now.Date;
            Wynagrodzenie = 0;
        }
        public override string ToString()
        {
            return $"{Nazwisko}, {DataZatrudnienia:d} ({this.CzasZatrudnienia}), {Wynagrodzenie}";
        }

        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30; //Int32.Parse((DateTime.Now.Date.Subtract(DataZatrudnienia) / 30).ToString());

        public bool Equals(Pracownik other)
        {
            if (other == null) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return (Nazwisko == other.Nazwisko && DataZatrudnienia==other.DataZatrudnienia && Wynagrodzenie == other.Wynagrodzenie);
        }

        public override bool Equals(object obj)
        {
            if (obj is Pracownik) return Equals((Pracownik)obj);
            else return false;
        }
    }
}
