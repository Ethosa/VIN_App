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
    
    public partial class licences
    {
        public int id { get; set; }
        public System.DateTime licence_date { get; set; }
        public System.DateTime expire_date { get; set; }
        public string categories { get; set; }
        public string licence_series { get; set; }
        public int licence_number { get; set; }
        public int driver_id { get; set; }
    
        public virtual drivers drivers { get; set; }
    }
}
