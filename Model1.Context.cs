//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc3839_24522
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db3839_24522Entities : DbContext
    {
        public db3839_24522Entities()
            : base("name=db3839_24522Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<tbldepartment> tbldepartments { get; set; }
        public virtual DbSet<tblcountry> tblcountries { get; set; }
        public virtual DbSet<tblstate> tblstates { get; set; }
    
        public virtual int usp_emp_delete(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_emp_delete", empidParameter);
        }
    
        public virtual ObjectResult<usp_emp_edit_Result> usp_emp_edit(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_emp_edit_Result>("usp_emp_edit", empidParameter);
        }
    
        public virtual ObjectResult<usp_emp_get_Result> usp_emp_get()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_emp_get_Result>("usp_emp_get");
        }
    
        public virtual int usp_emp_insert(string name, string address, Nullable<int> age)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_emp_insert", nameParameter, addressParameter, ageParameter);
        }
    
        public virtual int usp_emp_update(Nullable<int> empid, string name, string address, Nullable<int> age)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_emp_update", empidParameter, nameParameter, addressParameter, ageParameter);
        }
    }
}
