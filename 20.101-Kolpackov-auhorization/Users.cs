//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20._101_Kolpackov_auhorization
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID_User { get; set; }
        public int ID_Post { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Posts Posts { get; set; }

        public string GetNamePost
        {
            get
            {
                return this.Posts.PostName.ToString();
            }
        }
    }
}
