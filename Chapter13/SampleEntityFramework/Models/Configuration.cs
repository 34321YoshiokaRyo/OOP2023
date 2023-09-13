using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace SampleEntityFramework.Models {
    internal class Configuration : DbMigrationsConfiguration<BooksDbContext>{

        public Configuration() {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFramework.Models.BooksDbcontext";
        }

    }
}
