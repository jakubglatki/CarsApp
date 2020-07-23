using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs okreœlaj¹cy kryteria wyszukiwania dla widoku CarProductList.
    /// </summary>
    public interface ICarProductListFilter
    {
        #region Properties

        string FilterModel { get; set; }
        string FilterVIN { get; set; }
        string FilterFactory { get; set; }

        #endregion Properties
    }
}
