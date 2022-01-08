using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMag.Data.Interfaces;
using MMag.ViewModels;

namespace MMag.Controllers
{
    public class InstrumentsController : Controller
    {
      
            private readonly IInst _allInstruments;
            private readonly IInstrumentsCategory _allCategories;

            public InstrumentsController(IInst iAllInstruments, IInstrumentsCategory iInstrumentsCategory)
            {
                _allInstruments = iAllInstruments;
                _allCategories = iInstrumentsCategory;
            }

            public ViewResult List()
            {
                InstrumentsListViewModel obj = new InstrumentsListViewModel();
            obj.getAllInstruments = _allInstruments.AllInstruments;
                obj.currCategory = "Электрогитары";
                return View(obj);
            }
        
    }

}

