using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaWeek7_CassanoValentina.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ProvaWeek7_CassanoValentina.RepositoryEF
{
    internal class ContattoConfiguration : IEntityTypeConfiguration<Contatto>
    {

        public void Configure(EntityTypeBuilder<Contatto> modelBuilder)
        {
            modelBuilder.ToTable("Contatto");
            modelBuilder.HasKey(c => c.IDContatto);
             modelBuilder.Property(c => c.Nome).IsRequired();
            modelBuilder.Property(c => c.Cognome).IsRequired();

  
            modelBuilder.HasOne(c => c.Indirizzo).WithOne(i => i.Contatto);


        }
    }
}
