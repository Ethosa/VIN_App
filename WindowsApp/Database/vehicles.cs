//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsApp.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehicles
    {
        public int id { get; set; }
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public int Color { get; set; }
        public string Engine_Type { get; set; }
        public string type_of_drive { get; set; }
        public int driver_id { get; set; }
    
        public virtual drivers drivers { get; set; }
    }
}
