using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{
    public class Country: Song
    {
        public string countrySound { get; set; }
        public Country(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.countrySound = "ten ten ten";
        }

        public override string Play()
        {
            return this.title + " * " + this.author + "\n*Country rhythm* " + this.countrySound;
        }
    }

    public class AlternativeCountry: Country
    {
        public string alternativeCountrySound { get; set; }

        public AlternativeCountry(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.alternativeCountrySound = "lonely lonely lonely";
        }
        public override string Play()
        {
            return base.Play()+"\n*Alternative country rhythm* "+this.alternativeCountrySound;
        }
    }

    public class CountryPop: Country
    {
        public string countryPopSound { get; set; }
        public CountryPop(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.countryPopSound = "alalalala ahihihihi";
        }

        public override string Play()
        {
            return base.Play()+"\n*Country pop rhythm* "+this.countryPopSound;
        }
    }
    public class CountryBlue: Country
    {
        public string countryBlueSound { get; set; }
        public CountryBlue(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.countryBlueSound = "teo teo teo beo beo boe";
        }

        public override string Play()
        {
            return base.Play()+"\n *Country blue rhythm* "+this.countryBlueSound;
        }
    }
}
