//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manufactures
    {
        public Manufactures()
        {
            this.CarModels = new HashSet<CarModels>();
            this.Factories = new HashSet<Factories>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
    
        public virtual ICollection<CarModels> CarModels { get; set; }
        public virtual Countries Countries { get; set; }
        public virtual ICollection<Factories> Factories { get; set; }
    }
}
