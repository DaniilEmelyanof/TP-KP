using MMag.Data.Interfaces;
using MMag.Data.Models;

namespace MMag.Data.mocks
{
    public class MockInstruments : IInst
    {
        private readonly IInstrumentsCategory _categoryInstruments = new MockCategory();
        public IEnumerable<Instrument> AllInstruments
        {
            get
            {
                return new List<Instrument>
                {
                    new Instrument{
                        instrumentName = "fender", 
                        year = "1959",
                        shortDesc = "классика гитаростроения",
                        price =4000,
                        img="/img/fender stratocaster.jpg",
                        isFavourite=true,
                        available=true,
                        Category = _categoryInstruments.AllCategories.First()},
                    new Instrument{
                        instrumentName = "fender jazzbass",
                        year = "1969",
                        shortDesc = "сочный звук",
                        price =3500,
                        img="/img/fender jazzbass.jpg",
                        isFavourite=true,
                        available=true,
                        Category = _categoryInstruments.AllCategories.First()},
                    new Instrument{
                        instrumentName = "tama imperial",
                        year = "1980",
                        shortDesc = "короли ритма",
                        price =6000,
                        img="/img/tama.jpg",
                        isFavourite=true,
                        available=true,
                        Category = _categoryInstruments.AllCategories.First()},

                };
            }
        }
        public IEnumerable<Instrument> GetFavInstruments { get; set; }

        public Instrument getObjectInstrument(int instrumentId)
        {
            throw new NotImplementedException();
        }
    }
}

    
