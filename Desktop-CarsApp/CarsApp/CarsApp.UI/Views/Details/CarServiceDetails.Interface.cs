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

        #endregion Properties
    }
}
