using MMag.Data.Models;

namespace MMag.ViewModels
{
    public class InstrumentsListViewModel
    {
        public IEnumerable<Instrument> getAllInstruments { get; set; }  
        public string currCategory { get; set; }
    }
}
