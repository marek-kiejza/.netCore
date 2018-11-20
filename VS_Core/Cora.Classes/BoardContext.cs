using Cora.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cora.Model
{
   public class BoardContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}
