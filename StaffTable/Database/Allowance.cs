//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StaffTable.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Allowance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Allowance()
        {
            this.AllowanceSize = new HashSet<AllowanceSize>();
        }
    
        public int AllowanceID { get; set; }
        public string AllowanceName { get; set; }
        public Nullable<int> PostID { get; set; }
    
        public virtual Post Post { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowanceSize> AllowanceSize { get; set; }
    }
}
