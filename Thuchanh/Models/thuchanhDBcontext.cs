using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Thuchanh.Models
{
    public partial class thuchanhDBcontext : DbContext
    {
        public thuchanhDBcontext()
            : base("name=thuchanhDBcontext")
        {
        }
        public virtual DbSet<hocsinh> Hocsinhs { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
