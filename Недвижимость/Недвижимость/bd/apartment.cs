//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Недвижимость.bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class apartment
    {
        public int Id { get; set; }
        public string Address_City { get; set; }
        public int IdDistricts { get; set; }
        public int Address_House { get; set; }
        public int Address_Number { get; set; }
        public int Coordinate_latitude { get; set; }
        public int Coordinate_longitude { get; set; }
        public string TotalArea { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
    
        public virtual district district { get; set; }
    }
}
