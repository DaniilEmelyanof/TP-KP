using MMag.Data.Interfaces;
using MMag.Data.Models;
using System.Collections.Generic;

namespace MMag.Data.mocks
{
    public class MockCategory : IInstrumentsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Электрогитары", desc = "Гитары со встроенными звукоснимателями"},
                    new Category{categoryName = "Бас-гитары",desc = "Инструменты, наследники контрабасов"},
                    new Category{categoryName = "Барабаны", desc = "Основной инструмент ритма"}
                };
            }
        }
    }
}
