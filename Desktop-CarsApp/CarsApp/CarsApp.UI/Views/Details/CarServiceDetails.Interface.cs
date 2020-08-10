using System;
using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs widoku CarServiceDetails.
    /// </summary>
    public interface ICarServiceDetails : IBaseWindowView
    {
        #region Properties

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarService CurrentCarService { get; set; }


        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        HandledCarProduct CurrentHandledCarProduct { get; set; }


        /// <summary>
        /// CarProduct do dodania.
        /// </summary>
        CarProduct CarProductToAdd { get; set; }

        /// <summary>
        /// CarProduct do dodania.
        /// </summary>
        CarProductList CarProductList { get; set; }

        /// <summary>
        /// Lista HandledCarProduct
        /// </summary>
        ICollection<HandledCarProduct> HandledCarProductsCollection { get; set; }
        #endregion Properties
    }
}
