//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yachts
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccessoriesToBoat
    {
        public int IdAccessoriesToBoat { get; set; }
        public int IdAccessory { get; set; }
        public int IdBoat { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Boat Boat { get; set; }
    }
}