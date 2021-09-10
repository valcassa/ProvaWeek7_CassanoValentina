
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.RepositoryEF.Configurations.ContattoConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.RepositoryEF.Configurations
{
    internal class IndirizzoConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Indirizzo>
    {
        public void Configure(EntityTypeBuilder<Indirizzo> modelBuilder)
        {
            modelBuilder.ToTable("Indirizzo");
            modelBuilder.HasKey(i => i.IDIndirizzo);
            modelBuilder.Property(i => i.TipoIndirizzo).IsRequired();
            modelBuilder.Property(i => i.Via).IsRequired();
            modelBuilder.Property(i => i.Città).IsRequired();
            modelBuilder.Property(i => i.CAP).IsRequired();
            modelBuilder.Property(i => i.Provincia).IsRequired();
            modelBuilder.Property(i => i.Nazione).IsRequired();

            modelBuilder.HasOne(i => i.Contatti).WithOne(i => i.IDIndirizzo).HasForeignKey(i => i.IDContatto);


        }
    }
     
}
