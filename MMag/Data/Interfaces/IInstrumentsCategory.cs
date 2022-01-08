using MMag.Data.Models;

namespace MMag.Data.Interfaces
{
    public interface IInstrumentsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
