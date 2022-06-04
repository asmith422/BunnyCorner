using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class ASmith53Context : DbContext
    {

        public ASmith53Context(DbContextOptions<ASmith53Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBreederDetail> TblBreederDetails { get; set; }
        public virtual DbSet<TblBunny> TblBunnies { get; set; }
        public virtual DbSet<TblBunnyDetail> TblBunnyDetails { get; set; }
        public virtual DbSet<TblCar> TblCars { get; set; }
        public virtual DbSet<TblDriver> TblDrivers { get; set; }
        public virtual DbSet<TblFaculty> TblFaculties { get; set; }
        public virtual DbSet<TblIncident> TblIncidents { get; set; }
        public virtual DbSet<TblOwnerDetail> TblOwnerDetails { get; set; }
        public virtual DbSet<TblPetDetail> TblPetDetails { get; set; }
        public virtual DbSet<TblPolice> TblPolices { get; set; }
        public virtual DbSet<TblPublicSafety> TblPublicSafeties { get; set; }
        public virtual DbSet<TblStudent> TblStudents { get; set; }
        public virtual DbSet<TblTicket> TblTickets { get; set; }
        public virtual DbSet<TblViolation> TblViolations { get; set; }
        public virtual DbSet<VwBunnyForSale> VwBunnyForSales { get; set; }

        public IConfiguration myconfig { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(myconfig.GetConnectionString("FinalSmithAshleyDBconnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<TblBreederDetail>(entity =>
            {
                entity.HasKey(e => e.BreederLastName);

                entity.ToTable("tblBreederDetails");

                entity.Property(e => e.BreederLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("breederLastName");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BreederFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("breederFirstName");

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblBunny>(entity =>
            {
                entity.HasKey(e => e.Breed);

                entity.ToTable("tblBunny");

                entity.Property(e => e.Breed)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("breed");

                entity.Property(e => e.Domesticated)
                    .HasMaxLength(3)
                    .HasColumnName("domesticated")
                    .IsFixedLength(true);

                entity.Property(e => e.LengthInches)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("length (inches)");

                entity.Property(e => e.Lifespan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lifespan");

                entity.Property(e => e.Origin)
                    .HasMaxLength(30)
                    .HasColumnName("origin")
                    .IsFixedLength(true);

                entity.Property(e => e.Temperment)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("temperment");

                entity.Property(e => e.WeightLbs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("weight (lbs)");
            });

            modelBuilder.Entity<TblBunnyDetail>(entity =>
            {
                entity.HasKey(e => e.BunnyName);

                entity.ToTable("tblBunnyDetails");

                entity.Property(e => e.BunnyName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("bunnyName");

                entity.Property(e => e.Breed)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("breed");

                entity.Property(e => e.BreederLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("breederLastName");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .HasColumnName("color");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex")
                    .IsFixedLength(true);

                entity.HasOne(d => d.BreedNavigation)
                    .WithMany(p => p.TblBunnyDetails)
                    .HasForeignKey(d => d.Breed)
                    .HasConstraintName("FK_tblBunnyDetails_tblBunny");

                entity.HasOne(d => d.BreederLastNameNavigation)
                    .WithMany(p => p.TblBunnyDetails)
                    .HasForeignKey(d => d.BreederLastName)
                    .HasConstraintName("FK_tblBunnyDetails_tblBreederDetails");
            });

            modelBuilder.Entity<TblCar>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("tblCar");

                entity.Property(e => e.CarId)
                    .ValueGeneratedNever()
                    .HasColumnName("carID");

                entity.Property(e => e.CarYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("carYear")
                    .IsFixedLength(true);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .HasColumnName("color");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("licensePlate");

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("make");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<TblDriver>(entity =>
            {
                entity.HasKey(e => e.Driverid);

                entity.ToTable("tblDriver");

                entity.Property(e => e.Driverid)
                    .ValueGeneratedNever()
                    .HasColumnName("driverid");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Dname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dname");

                entity.Property(e => e.Dstate)
                    .HasMaxLength(2)
                    .HasColumnName("dstate")
                    .IsFixedLength(true);

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<TblFaculty>(entity =>
            {
                entity.HasKey(e => e.FacultyId);

                entity.ToTable("tblFaculty");

                entity.Property(e => e.FacultyId)
                    .ValueGeneratedNever()
                    .HasColumnName("facultyID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.FacGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("facGender")
                    .IsFixedLength(true);

                entity.Property(e => e.FacName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("facName");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("hireDate");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblFaculties)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_tblFaculty_tblCar");
            });

            modelBuilder.Entity<TblIncident>(entity =>
            {
                entity.HasKey(e => e.IncidentId);

                entity.ToTable("tblIncident");

                entity.Property(e => e.IncidentId)
                    .ValueGeneratedNever()
                    .HasColumnName("incidentID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.FacultyId).HasColumnName("facultyID");

                entity.Property(e => e.IncidentDate)
                    .HasColumnType("date")
                    .HasColumnName("incidentDate");

                entity.Property(e => e.PsafetyId).HasColumnName("psafetyID");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_tblIncident_tblCar");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK_tblIncident_tblFaculty");

                entity.HasOne(d => d.Psafety)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.PsafetyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIncident_tblPublicSafety");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_tblIncident_tblStudent");
            });

            modelBuilder.Entity<TblOwnerDetail>(entity =>
            {
                entity.HasKey(e => e.OwnerId);

                entity.ToTable("tblOwnerDetails");

                entity.Property(e => e.OwnerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ownerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.OwnerFirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ownerFirstName");

                entity.Property(e => e.OwnerLastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ownerLastName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state")
                    .IsFixedLength(true);

                entity.Property(e => e.Town)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("town");
            });

            modelBuilder.Entity<TblPetDetail>(entity =>
            {
                entity.HasKey(e => e.PetId);

                entity.ToTable("tblPetDetails");

                entity.Property(e => e.PetId)
                    .ValueGeneratedNever()
                    .HasColumnName("petID");

                entity.Property(e => e.Breed)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("breed");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.PetName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("petName");

                entity.Property(e => e.PetNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("petNotes");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.TblPetDetails)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_tblPetDetails_tblOwnerDetails");
            });

            modelBuilder.Entity<TblPolice>(entity =>
            {
                entity.HasKey(e => e.PoliceId);

                entity.ToTable("tblPolice");

                entity.Property(e => e.PoliceId)
                    .ValueGeneratedNever()
                    .HasColumnName("policeID");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("pname");
            });

            modelBuilder.Entity<TblPublicSafety>(entity =>
            {
                entity.HasKey(e => e.PsafetyId);

                entity.ToTable("tblPublicSafety");

                entity.Property(e => e.PsafetyId)
                    .ValueGeneratedNever()
                    .HasColumnName("psafetyID");

                entity.Property(e => e.Badge)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("badge");

                entity.Property(e => e.PGender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pGender")
                    .IsFixedLength(true);

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("pName");
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("tblStudent");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("studentID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("lName");

                entity.Property(e => e.Major)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("major");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_tblStudent_tblCar");
            });

            modelBuilder.Entity<TblTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("tblTicket");

                entity.Property(e => e.TicketId)
                    .ValueGeneratedNever()
                    .HasColumnName("ticketID");

                entity.Property(e => e.Driverid).HasColumnName("driverid");

                entity.Property(e => e.PoliceId).HasColumnName("policeID");

                entity.Property(e => e.TicketDate)
                    .HasColumnType("date")
                    .HasColumnName("ticketDate");

                entity.Property(e => e.ViolationId).HasColumnName("violationID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.Driverid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTicket_tblDriver");

                entity.HasOne(d => d.Police)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.PoliceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTicket_tblPolice");

                entity.HasOne(d => d.Violation)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.ViolationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTicket_tblViolation");
            });

            modelBuilder.Entity<TblViolation>(entity =>
            {
                entity.HasKey(e => e.ViolationId);

                entity.ToTable("tblViolation");

                entity.Property(e => e.ViolationId)
                    .ValueGeneratedNever()
                    .HasColumnName("violationID");

                entity.Property(e => e.Fine).HasColumnName("fine");

                entity.Property(e => e.Violaton)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("violaton");
            });

            modelBuilder.Entity<VwBunnyForSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwBunnyForSale");

                entity.Property(e => e.Breed)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("breed");

                entity.Property(e => e.BreederLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("breederLastName");

                entity.Property(e => e.BunnyName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("bunnyName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
