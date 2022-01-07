using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPC.DataBase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(new SQLiteConnection()
        { ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "ICOPC.db", ForeignKeys = true }.ConnectionString }, true)
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<tbl_ERC20> Tbl_ERC20 { get; set; }
        public DbSet<tbl_TRC20> Tbl_TRC20 { get; set; }
    }
}
