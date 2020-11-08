using System;

namespace lab02
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
            return $"{Nazwisko}, {DataZatrudnienia} ({this.CzasZatrudnienia()}), {Wynagrodzenie}";
        }

        public int CzasZatrudnienia() => Int32.Parse((DateTime.Now.Date.Subtract(DataZatrudnienia) / 30).ToString());

        public bool Equals(Pracownik other)
        {
            if (other == null) return false;
            return true;
        }
    }
}