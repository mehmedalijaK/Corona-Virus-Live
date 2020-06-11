using Newtonsoft.Json;

namespace CoronaLive.Classes
{
    public class Country
    {
        private string country;
        private CountryInfo countryInfo;
        private object updated;
        private int cases;
        private int? todayCases;
        private int deaths;
        private int? todayDeaths;
        private int recovered;
        private int active;
        private int critical;
        private double? casesPerOneMillion;
        private double? deathsPerOneMillion;
        private int tests;
        private int testsPerOneMillion;

        #region Konstruktor
        public Country()
        {
            this.country = "";
            this.countryInfo = null;
            this.updated = null;
            this.cases = 0;
            this.todayCases = 0;
            this.deaths = 0;
            this.todayDeaths = 0;
            this.recovered = 0;
            this.active = 0;
            this.critical = 0;
            this.casesPerOneMillion = 0;
            this.deathsPerOneMillion = 0;
            this.tests = 0;
            this.testsPerOneMillion = 0;
        }

        [JsonConstructor]
        public Country(string country, CountryInfo countryInfo, object updated, int cases,
           int? todayCases, int deaths, int? todayDeaths, int recovered, int active,
            int critical, double? casesPerOneMillion, double? deathsPerOneMillion, int tests, int testsPerOneMillion)
        {
            this.country = country;
            this.countryInfo = countryInfo;
            this.updated = updated;
            this.cases = cases;
            if (todayCases == 0) this.todayCases = null;
            else this.todayCases = todayCases;
            this.deaths = deaths;
            if (todayDeaths == 0) this.todayDeaths = null;
            else this.todayDeaths = todayDeaths;
            this.recovered = recovered;
            this.active = active;
            this.critical = critical;
            this.casesPerOneMillion = casesPerOneMillion;
            this.deathsPerOneMillion = deathsPerOneMillion;
            this.tests = tests;
            this.testsPerOneMillion = testsPerOneMillion;

        }

        #endregion

        #region Svojstva
        public string ImeDrzave { get { return country; } set { country = value; } }
        public CountryInfo DodatneInformacije { get { return countryInfo; } set { countryInfo = value; } }
        public object UpdateID { get { return updated; } set { updated = value; } }
        public int UkupnoZarazenih { get { return cases; } set { cases = value; } }
        public int? SlucajeviDanas { get { if (todayCases == 0) return null; else return todayCases; } set { if (value == 0) todayCases = null; else todayCases = value; } }
        public int UkupnoMrtvih { get { return deaths; } set { deaths = value; } }
        public int? MrtviDanas { get { return todayDeaths; } set { todayDeaths = value; } }
        public int UkupnoPreboleloKoronu { get { return recovered; } set { recovered = value; } }
        public int AktivniSlucajeviKorone { get { return active; } set { active = value; } }
        public int UkupnoZivotnoUgrozenih { get { return critical; } set { critical = value; } }
        public double? SlucajevaPoMilionuStanovnika { get { return casesPerOneMillion; } set { casesPerOneMillion = value; } }
        public double? SmrtiPoMilionuStanovnika { get { return deathsPerOneMillion; } set { deathsPerOneMillion = value; } }
        public int UkupnoTestiranihStanovnika { get { return tests; } set { tests = value; } }
        public int TestovaPoMilionuStanovnika { get { return testsPerOneMillion; } set { testsPerOneMillion = value; } }
        #endregion

        public static Country operator +(Country a, Country b)
        {
            int? AtodayC = 0;
            int? AtodayD = 0;
            int? BtodayC = 0;
            int? BtodayD = 0;

            if (a.todayCases == null)
                AtodayC = 0;
            else AtodayC = a.todayCases;

            if (b.todayCases == null)
                BtodayC = 0;
            else BtodayC = b.todayCases;

            if (a.todayDeaths == null)
                AtodayD = 0;
            else AtodayD = a.todayDeaths;

            if (b.todayDeaths == null)
                BtodayD = 0;
            else
                BtodayD = b.todayDeaths;

            int? rez1 = AtodayC + BtodayC;
            int? rez2 = AtodayD + BtodayD;



            return new Country("Ceo svet", b.countryInfo, a.updated, a.cases + b.cases, rez1.GetValueOrDefault(0), a.deaths + b.deaths,
                rez2.GetValueOrDefault(0), a.recovered + b.recovered, a.active + b.active, a.critical + b.critical, a.casesPerOneMillion + b.todayCases,
                a.deathsPerOneMillion + b.deathsPerOneMillion, a.tests + b.tests, a.testsPerOneMillion + b.testsPerOneMillion);
        }
    }

    public class CountryInfo
    {
        public int? _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public string flag { get; set; }
    }
}
