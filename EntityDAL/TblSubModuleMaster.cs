//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSubModuleMaster
    {
        public long SubModuleId { get; set; }
        public Nullable<long> ModuleId { get; set; }
        public string SubModuleName { get; set; }
        public string Description { get; set; }
        public Nullable<long> AppId { get; set; }
        public Nullable<long> EntityId { get; set; }
        public Nullable<long> Createdby { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> Updatedby { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string ModuleName { get; set; }
    }
}