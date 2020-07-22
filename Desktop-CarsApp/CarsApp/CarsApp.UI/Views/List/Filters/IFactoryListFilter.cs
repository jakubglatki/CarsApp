using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs okreœlaj¹cy kryteria wyszukiwania dla widoku FactoryList.
    /// </summary>
    public interface IFactoryListFilter
    {
        #region Properties

        string FilterName { get; set; }
        string FilterCityName { get; set; }
        string FilterManufactureName { get; set; }

        #endregion Properties
    }
}
