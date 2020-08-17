using CarsApp.Data;
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
        City FilterCity { get; set; }
        Manufacture FilterManufacture { get; set; }
        #endregion Properties
    }
}
