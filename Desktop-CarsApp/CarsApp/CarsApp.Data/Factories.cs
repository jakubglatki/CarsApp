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
    
    public partial class Factories
    {
        public Factories()
        {
            this.CarProducts = new HashSet<CarProducts>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public long CityId { get; set; }
        public long ManufactureId { get; set; }
    
        public virtual ICollection<CarProducts> CarProducts { get; set; }
        public virtual Cities Cities { get; set; }
        public virtual Manufactures Manufactures { get; set; }
    }
}
