//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminCoop
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id_user { get; set; }
        public string unique_name { get; set; }
        public string password { get; set; }
        public int id_account { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
