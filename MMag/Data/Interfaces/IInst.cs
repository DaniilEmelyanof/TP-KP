using MMag.Data.Models;

namespace MMag.Data.Interfaces
{
    public interface IInst
    {
        IEnumerable<Instrument> AllInstruments { get;}
        IEnumerable<Instrument> GetFavInstruments { get; set; }

        Instrument getObjectInstrument(int instrumentId);
    }
}
