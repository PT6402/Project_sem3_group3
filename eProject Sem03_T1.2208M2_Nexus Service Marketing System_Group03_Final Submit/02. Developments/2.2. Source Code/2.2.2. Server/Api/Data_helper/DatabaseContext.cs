
using Api.Interface.IService;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Api.Data_helper
{
    public class DatabaseContext : DbContext
    {
        private readonly IPassword _pass;

        public DatabaseContext(DbContextOptions options, IPassword pass) : base(options)
        {
            _pass = pass;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee_type> Employee_types { get; set; }
        public DbSet<Address_store> Address_stores { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Connect_type> Connect_types { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<ImportReceipt> ImportReceipt { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Duration> Durations { get; set; }
        public DbSet<Call_charges> Call_charges { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<TP_contract> TP_contract { get; set; }
        public DbSet<Addresses> Address { get; set; }
        public DbSet<Order_handler> Order_handler { get; set; }
        public DbSet<Duration_callCharges> Duration_callCharges { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Contract_Service> Contract_Services { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity
                .HasOne(x => x.User)
                .WithOne(x => x.Employees)
                .HasForeignKey<Employee>(x => x.User_Id)
                .HasConstraintName("FK_Emp_User");

                entity
                .HasOne(x => x.Employee_type)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.Employee_type_Id)
                .HasConstraintName("FK_Emp_Emp_type");

                entity
                .HasOne(x => x.Address_store)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.Address_store_Id)
                .HasConstraintName("FK_Emp_Address_store");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity
                .HasOne(x => x.Supplier)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Supplier_Id)
                .HasConstraintName("FK_Product_Supplier");
            });

            modelBuilder.Entity<ImportReceipt>(entity =>
            {
                entity
                .HasOne(x => x.Product)
                .WithMany(x => x.ImportReceipt)
                .HasForeignKey(x => x.Product_Id)
                .HasConstraintName("FK_Product_ImportReceipt")
                .OnDelete(DeleteBehavior.NoAction);

                entity
                .HasOne(x => x.Storage)
                .WithMany(x => x.import_receipt)
                .HasForeignKey(x => x.Storage_id)
                .HasConstraintName("FK_ImportReceipt_Storage")
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity
                .HasOne(x => x.Connect_type)
                .WithMany(x => x.Packages)
                .HasForeignKey(x => x.Connect_type_Id)
                .HasConstraintName("FK_Packages_Connect_type");
            });

            modelBuilder.Entity<Duration>(entity =>
            {
                entity
                .HasOne(x => x.Package)
                .WithMany(x => x.Durations)
                .HasForeignKey(x => x.Package_Id)
                .HasConstraintName("FK_Duration_Package");
            });

            modelBuilder.Entity<Duration_callCharges>(entity =>
            {
                entity
                .HasOne(x => x.Duration)
                .WithMany(x => x.Duration_callChargeses)
                .HasForeignKey(x => x.Duration_Id)
                .HasConstraintName("FK_Duration_callCharges_Duration")
                .OnDelete(DeleteBehavior.NoAction);

                entity
                .HasOne(x => x.Call_charges)
                .WithMany(x => x.Duration_CallCharges)
                .HasForeignKey(x => x.Call_charges_Id)
                .HasConstraintName("FK_Duration_callCharges_Call_charges")
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity
                .HasOne(x => x.Duration_callCharges)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.Duration_callCharges_Id)
                .HasConstraintName("FK_Order_Duration_callCharges")
                .OnDelete(DeleteBehavior.Cascade);

                entity
                .HasOne(x => x.Duration)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.Duration_Id)
                .HasConstraintName("FK_Order_Duration")
                .OnDelete(DeleteBehavior.Cascade);

                entity
                .HasOne(x => x.Contract_Service)
                .WithOne(x => x.Order)
                .HasForeignKey<Order>(x => x.ContractService_Id)
                .HasConstraintName("FK_Order_Contract_Service")
                .OnDelete(DeleteBehavior.NoAction);

                entity
                .HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.User_Id)
                .HasConstraintName("FK_Order_User")
                .OnDelete(DeleteBehavior.NoAction);

                entity
                .HasOne(x => x.Addresses)
                .WithOne(x => x.Order)
                .HasForeignKey<Order>(x => x.Addresses_Id)
                .HasConstraintName("FK_Order_Address_Id")
                .OnDelete(DeleteBehavior.NoAction);

                entity
                .HasOne(x => x.Coupon)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.Coupon_Id)
                .HasConstraintName("FK_Order_Coupon")
                .OnDelete(DeleteBehavior.NoAction);


            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity
                .HasOne(x => x.Order)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.Order_Id)
                .HasConstraintName("FK_Payment_Order");
            });

            modelBuilder.Entity<TP_contract>(entity =>
            {


                entity
                .HasOne(x => x.User)
                .WithOne(x => x.TP_contract)
                .HasForeignKey<TP_contract>(x => x.User_Id)
                .HasConstraintName("FK_Contractor_User");


            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity
                .HasOne(x => x.Connect_type)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Connect_type_Id)
                .HasConstraintName("FK_Product_ConnectType");
            });

            modelBuilder.Entity<Order_handler>(entity =>
            {
                entity
                .HasOne(x => x.Order)
                .WithMany(x => x.Order_handlers)
                .HasForeignKey(x => x.Order_Id)
                .HasConstraintName("FK_Order_handle_Order");

                entity
                .HasOne(x => x.Address_store)
                .WithMany(x => x.Order_handlers)
                .HasForeignKey(x => x.Address_store_Id)
                .HasConstraintName("FK_Order_handle_Address_store");

                entity
                .HasOne(x => x.Employee)
                .WithMany(x => x.Order_handlers)
                .HasForeignKey(x => x.Employee_Id)
                .HasConstraintName("FK_Order_handle_Employee")
                 .OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity
                .HasOne(x => x.TP_contract)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.TP_contract_Id)
                .HasConstraintName("FK_User_TpContractor");

                entity
               .HasOne(x => x.Employees)
               .WithOne(x => x.User)
               .HasForeignKey<User>(x => x.Employees_Id)
               .HasConstraintName("FK_User_Employee");

            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity
                .HasOne(x => x.User)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.User_Id)
                .HasConstraintName("FK_Feedback_User");

                entity
               .HasOne(x => x.Duration)
               .WithMany(x => x.Feedbacks)
               .HasForeignKey(x => x.Duration_Id)
               .HasConstraintName("FK_FeedBack_Duration");

            });

            modelBuilder.Entity<Call_charges>(entity =>
            {
                entity
                .HasOne(x => x.Duration)
                .WithMany(x => x.Call_Charges)
                .HasForeignKey(x => x.Duration_Id)
                .HasConstraintName("FK_Call_charges_Duration");


            });

            modelBuilder.Entity<Contract_Service>(entity =>
            {
                entity
                .HasOne(x => x.TP_Contract)
                .WithMany(x => x.Contract_Services)
                .HasForeignKey(x => x.TP_Contract_Id)
                .HasConstraintName("FK_Contract_Services_TpContractor");

                entity
                .HasOne(x => x.Order)
                .WithOne(x => x.Contract_Service)
                .HasForeignKey<Contract_Service>(x => x.Order_Id)
                .HasConstraintName("FK_Contract_Services_Order");

            });
            modelBuilder.Entity<Address_store>(entity =>
            {
                entity
                .HasOne(x => x.Addresses)
                .WithOne(x => x.Address_Store)
                .HasForeignKey<Address_store>(x => x.Address_Id)
                .HasConstraintName("FK_Address_store_Addresses");

            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity
                .HasOne(x => x.Address_Store)
                .WithOne(x => x.Storage)
                .HasForeignKey<Storage>(x => x.Address_store_id)
                .HasConstraintName("FK_Storage_Address_store")
                .OnDelete(DeleteBehavior.NoAction);
            });

         /*   modelBuilder.Entity<Connect_type>().HasData
               (
                   new Connect_type { Id = 1, Name = "Dial-up", First_Letter = "D", Description = "dial-up", Security_Deposit = 325 },
                   new Connect_type { Id = 2, Name = "Broad Band", First_Letter = "B", Description = "Broad Band", Security_Deposit = 500 },
                   new Connect_type { Id = 3, Name = "LandLine", First_Letter = "L", Description = "LandLine", Security_Deposit = 250 }
               );
            modelBuilder.Entity<Package>().HasData
                (
                    new Package { Id = 1, Name = "Hourly Basic", Connect_type_Id = 1 },
                    new Package { Id = 2, Name = "Unlimited 28Kbps", Connect_type_Id = 1 },
                     new Package { Id = 3, Name = "Unlimited 56Kbps", Connect_type_Id = 1 },
                     new Package { Id = 4, Name = "Hourly Basic", Connect_type_Id = 2 },
                    new Package { Id = 5, Name = "Unlimited 64Kbps", Connect_type_Id = 2 },
                     new Package { Id = 6, Name = "Unlimited 128Kbps", Connect_type_Id = 2 },
                      new Package { Id = 7, Name = "Local Plan= Rental + Callcharges", Connect_type_Id = 3 },
                       new Package { Id = 8, Name = "STD Plan", Connect_type_Id = 3 }
                );
            modelBuilder.Entity<Duration>().HasData
                (
                    new Duration { Id = 1, Package_Id = 1, Time = "10Hrs", Price = 50, Validate = "1" },
                     new Duration { Id = 2, Package_Id = 1, Time = "30Hrs", Price = 130, Validate = "3" },
                      new Duration { Id = 3, Package_Id = 1, Time = "60Hrs", Price = 260, Validate = "6" },
                      new Duration { Id = 4, Package_Id = 2, Time = "Monthly", Price = 75, Validate = "1" },
                      new Duration { Id = 5, Package_Id = 2, Time = "Quarterly", Price = 150, Validate = "3" },
                      new Duration { Id = 6, Package_Id = 3, Time = "Monthly", Price = 100, Validate = "1" },
                      new Duration { Id = 7, Package_Id = 3, Time = "Quarterly", Price = 180, Validate = "3" },
                      new Duration { Id = 8, Package_Id = 4, Time = "30Hrs", Price = 175, Validate = "1" },
                      new Duration { Id = 9, Package_Id = 4, Time = "60Hrs", Price = 315, Validate = "3" },
                       new Duration { Id = 10, Package_Id = 5, Time = "Monthly", Price = 225, Validate = "1" },
                      new Duration { Id = 11, Package_Id = 5, Time = "Quarterly", Price = 400, Validate = "3" },
                        new Duration { Id = 12, Package_Id = 6, Time = "Monthly", Price = 350, Validate = "1" },
                      new Duration { Id = 13, Package_Id = 6, Time = "Quarterly", Price = 445, Validate = "3" },
                        new Duration { Id = 14, Package_Id = 7, Time = "Unlimited", Price = 75, Validate = "12", Description = "Local ULT : 55 cent/min" },
                    new Duration { Id = 15, Package_Id = 7, Time = "Monthly", Price = 35, Validate = "1", Description = "Local M: 75cent/min" },
                      new Duration { Id = 16, Package_Id = 8, Time = "Monthly", Price = 125, Validate = "1", Description = "Local: 70cent/min; STD:2.25$/min ; Messaging for mobiles:1$/min" },
                      new Duration { Id = 17, Package_Id = 8, Time = "Half-Yearly", Price = 420, Validate = "6", Description = "Local: 60cent/min; STD:2$/min ; Messaging for mobiles:1.15$/min" },
                      new Duration { Id = 18, Package_Id = 8, Time = "Yearly", Price = 799, Validate = "12", Description = "Local: 60cent/min; STD:1.75$/min ; Messaging for mobiles:1.12$/min" }
                );

            modelBuilder.Entity<Call_charges>().HasData
               (
               new Call_charges { Id = 1, Name = "Local ULT", Price = 55, Unit = "cent/min", Duration_Id = 14 },
                new Call_charges { Id = 2, Name = "Local M", Price = 75, Unit = "cent/min", Duration_Id = 15 },
                new Call_charges { Id = 3, Name = "Local", Price = 70, Unit = "cent/min", Duration_Id = 16 },
                new Call_charges { Id = 4, Name = "STD", Price = 2.25f, Unit = "$/min", Duration_Id = 16 },
                new Call_charges { Id = 5, Name = "Messaging for mobiles", Price = 1, Unit = "$/min", Duration_Id = 16 },
                new Call_charges { Id = 6, Name = "Local", Price = 60, Unit = "cent/min", Duration_Id = 17 },
                new Call_charges { Id = 7, Name = "STD", Price = 2, Unit = "$/min", Duration_Id = 17 },
                new Call_charges { Id = 8, Name = "Messaging for mobiles", Price = 1.15f, Unit = "$/min", Duration_Id = 17 },
                new Call_charges { Id = 9, Name = "Local", Price = 60, Unit = "cent/min", Duration_Id = 18 },
                new Call_charges { Id = 10, Name = "STD", Price = 1.75f, Unit = "$/min", Duration_Id = 18 },
                new Call_charges { Id = 11, Name = "Messaging for mobiles", Price = 1.12f, Unit = "$/min", Duration_Id = 18 }
               );

            modelBuilder.Entity<Duration_callCharges>().HasData
                (
                    new Duration_callCharges { Id = 1, Duration_Id = 1, Call_charges_Id = null },
                     new Duration_callCharges { Id = 2, Duration_Id = 2, Call_charges_Id = null },
                      new Duration_callCharges { Id = 3, Duration_Id = 3, Call_charges_Id = null },
                       new Duration_callCharges { Id = 4, Duration_Id = 4, Call_charges_Id = null },
                        new Duration_callCharges { Id = 5, Duration_Id = 5, Call_charges_Id = null },
                         new Duration_callCharges { Id = 6, Duration_Id = 6, Call_charges_Id = null },
                          new Duration_callCharges { Id = 7, Duration_Id = 7, Call_charges_Id = null },
                           new Duration_callCharges { Id = 8, Duration_Id = 8, Call_charges_Id = null },
                            new Duration_callCharges { Id = 9, Duration_Id = 9, Call_charges_Id = null },
new Duration_callCharges { Id = 10, Duration_Id = 10, Call_charges_Id = null },
                              new Duration_callCharges { Id = 11, Duration_Id = 11, Call_charges_Id = null },
                               new Duration_callCharges { Id = 12, Duration_Id = 12, Call_charges_Id = null },
                                new Duration_callCharges { Id = 13, Duration_Id = 13, Call_charges_Id = null },
                                 new Duration_callCharges { Id = 14, Duration_Id = 14, Call_charges_Id = 1 },
                                 new Duration_callCharges { Id = 15, Duration_Id = 15, Call_charges_Id = 2 },
                                 new Duration_callCharges { Id = 16, Duration_Id = 16, Call_charges_Id = 3 },
                                 new Duration_callCharges { Id = 17, Duration_Id = 16, Call_charges_Id = 4 },
                                 new Duration_callCharges { Id = 18, Duration_Id = 16, Call_charges_Id = 5 },
                                 new Duration_callCharges { Id = 19, Duration_Id = 17, Call_charges_Id = 6 },
                                 new Duration_callCharges { Id = 20, Duration_Id = 17, Call_charges_Id = 7 },
                                 new Duration_callCharges { Id = 21, Duration_Id = 17, Call_charges_Id = 8 },
                                 new Duration_callCharges { Id = 22, Duration_Id = 18, Call_charges_Id = 9 },
                                 new Duration_callCharges { Id = 23, Duration_Id = 18, Call_charges_Id = 10 },
                                 new Duration_callCharges { Id = 24, Duration_Id = 18, Call_charges_Id = 11 }
                );

            //Supplier
            modelBuilder.Entity<Supplier>().HasData
            (
                new Supplier { Id = 1, brandName = "UniFi", Phone = "0462146762", Address = "ha noi" },
                new Supplier { Id = 2, brandName = "Grandstream", Phone = "0646272131", Address = "ha noi" },
                new Supplier { Id = 3, brandName = "Panasonic", Phone = "0646272131", Address = "ha noi" }

            );
            //Product
            modelBuilder.Entity<Product>().HasData
            (
                //Dial_up
                //UniFi
                new Product
                {
                    Id = 1,
                    Name = "UniFi AC Lite",
                    //Seri = "UF001",
                    //Quantity = 10,
                    Connect_type_Id = 1,
                    Supplier_Id = 1,
                    Numb_Connect = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "UniFi AC Pro",
                    //Seri = "UF002",
                    //Quantity = 15,
                    Connect_type_Id = 1,
                    Supplier_Id = 1,
                    Numb_Connect = 15
                },
                new Product
                {
                    Id = 3,
                    Name = "UniFi AC Nano",
                    //Seri = "UF003",
                    //Quantity = 20,
                    Connect_type_Id = 1,
                    Supplier_Id = 1,
                    Numb_Connect = 25
                },
                new Product
                {
                    Id = 4,
                    Name = "UniFi AC NanoPro",
                    //Seri = "UF004",
                    //Quantity = 30,
                    Connect_type_Id = 1,
                    Supplier_Id = 1,
                    Numb_Connect = 51
                },
                //Grandstream
                new Product
                {
                    Id = 5,
                    Name = "GrandStream AC Lite",
                    //Seri = "GS001",
                    //Quantity = 10,
                    Connect_type_Id = 1,
                    Supplier_Id = 2,
                    Numb_Connect = 10
                },
                new Product
                {
                    Id = 6,
                    Name = "GrandStream AC Pro",
                    //Seri = "GS002",
                    //Quantity = 15,
                    Connect_type_Id = 1,
                    Supplier_Id = 2,
                    Numb_Connect = 15
                },
                new Product
                {
                    Id = 7,
                    Name = "GrandStream AC Nano",
                    //Seri = "GS003",
                    //Quantity = 20,
                    Connect_type_Id = 1,
                    Supplier_Id = 2,
                    Numb_Connect = 25
                },
                new Product
                {
                    Id = 8,
                    Name = "GrandStream AC NanoPro",
                    //Seri = "GS004",
                    //Quantity = 30,
                    Connect_type_Id = 1,
                    Supplier_Id = 2,
                    Numb_Connect = 51
                },
                //Board Band
                //UniFi
                new Product
                {
                    Id = 9,
                    Name = "UniFi AC Lite Max",
                    //Seri = "UFM001",
                    //Quantity = 10,
                    Connect_type_Id = 2,
                    Supplier_Id = 1,
                    Numb_Connect = 10
                },
                new Product
                {
                    Id = 10,
                    Name = "UniFi AC Pro Max",
                    //Seri = "UFM002",
                    //Quantity = 15,
                    Connect_type_Id = 2,
                    Supplier_Id = 1,
                    Numb_Connect = 15
                },
                new Product
                {
                    Id = 11,
                    Name = "UniFi AC Nano Max",
                    //Seri = "UFM003",
                    //Quantity = 20,
                    Connect_type_Id = 2,
                    Supplier_Id = 1,
                    Numb_Connect = 25
                },
                new Product
                {
                    Id = 12,
                    Name = "UniFi AC NanoPro Max",
                    //Seri = "UFM004",
                    //Quantity = 30,
                    Connect_type_Id = 2,
                    Supplier_Id = 1,
                    Numb_Connect = 51
                },

    //Grandstream
    new Product
    {
        Id = 13,
        Name = "GrandStream AC Lite Max",
        //Seri = "GSM001",
        //Quantity = 10,
        Connect_type_Id = 2,
        Supplier_Id = 2,
        Numb_Connect = 10
    },
    new Product
    {
        Id = 14,
        Name = "GrandStream AC Pro Max",
        //Seri = "GSM002",
        //Quantity = 15,
        Connect_type_Id = 2,
        Supplier_Id = 2,
        Numb_Connect = 15
    },
    new Product
    {
        Id = 15,
        Name = "GrandStream AC Nano Max",
        //Seri = "GSM003",
        //Quantity = 20,
        Connect_type_Id = 2,
        Supplier_Id = 2,
        Numb_Connect = 25
    },
    new Product
    {
        Id = 16,
        Name = "GrandStream AC NanoPro Max",
        //Seri = "GSM004",
        //Quantity = 30,
        Connect_type_Id = 2,
        Supplier_Id = 2,
        Numb_Connect = 51
    },
    //Landline
    //Local
    new Product
    {
        Id = 17,
        Name = "KXTS500",
        //Seri = "PNSN001",
        //Quantity = 10,
        Connect_type_Id = 3,
        Supplier_Id = 3,
        Numb_Connect = 10
    },
    //STD
    new Product
    {
        Id = 18,
        Name = "IP Fanvil X7A",
        //Seri = "PNSN002",
        //Quantity = 15,
        Connect_type_Id = 3,
        Supplier_Id = 3,
        Numb_Connect = 15
    }
);

            //employee_type
            modelBuilder.Entity<Employee_type>().HasData
                (
                    new Employee_type { Id = 1, Name = "Sale" },
                    new Employee_type { Id = 2, Name = "Technician" }

                );

            var pass = _pass.CreatePassword("123");
            //user
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasData
                (
                    new User { Id = 1, FullName = "Nguyen Van Thien", Phone = "0932859395", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "user", Status = "Active" },
                    new User { Id = 2, FullName = "admin", Phone = "0971866177", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "admin" },
                    new User { Id = 3, FullName = "Tran Thien Hieu", Phone = "0123456789", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Sale" },
                    new User { Id = 4, FullName = "Tran Van Phat", Phone = "0987654321", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Technician" },
                    new User { Id = 5, FullName = "Nguyen Van A", Phone = "0796526595", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Sale" },
                    new User { Id = 6, FullName = "Nguyen Van B", Phone = "0955797871", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Sale" },
                    new User { Id = 7, FullName = "Nguyen Van C", Phone = "0689764123", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Sale" },
                    new User { Id = 8, FullName = "Nguyen Van D", Phone = "0689434167", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Technician" },
                    new User { Id = 9, FullName = "Nguyen Van E", Phone = "0689764139", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Technician" },
                    new User { Id = 10, FullName = "Nguyen Van F", Phone = "0329764195", PasswordHash = pass.PasswordHash, PasswordSalt = pass.PasswordSalt, Role = "Emp_Technician" }
                );
            });

            //employee
            modelBuilder.Entity<Employee>().HasData(
                    new Employee { Id = 1, User_Id = 3, Employee_type_Id = 1, Address_store_Id = 1 },
                    new Employee { Id = 2, User_Id = 4, Employee_type_Id = 2, Address_store_Id = 1 },
                    new Employee { Id = 3, User_Id = 5, Employee_type_Id = 1, Address_store_Id = 2 },
                     new Employee { Id = 4, User_Id = 8, Employee_type_Id = 2, Address_store_Id = 2 },
                     new Employee { Id = 5, User_Id = 6, Employee_type_Id = 1, Address_store_Id = 3 },
                    new Employee { Id = 6, User_Id = 9, Employee_type_Id = 2, Address_store_Id = 3 },
                    new Employee { Id = 7, User_Id = 7, Employee_type_Id = 1, Address_store_Id = 4 },
                     new Employee { Id = 8, User_Id = 10, Employee_type_Id = 2, Address_store_Id = 4 }
                );

            //address
            modelBuilder.Entity<Addresses>().HasData(
            new Addresses { Id = 1, Address_full = "Ngõ 93, đường Hồ Tùng Mậu, phường Mai Dịch, Quận Cầu Giấy", Phone_code = "24", Province_code = "1", District_code = "5", Ward_code = "163" },
            new Addresses { Id = 2, Address_full = "số 1 Cao Thắng, phương Thanh Bình, Quận Hải Châu", Phone_code = "236", Province_code = "48", District_code = "492", Ward_code = "20227" },
            new Addresses { Id = 3, Address_full = "soc trang, long phu, phu huu", Phone_code = "299", Province_code = "94", District_code = "946", Ward_code = "31657" },
            new Addresses { Id = 4, Address_full = "33 Nguyễn Ảnh Thủ, xã Bà Điểm, huyện Hóc Môn", Phone_code = "28", Province_code = "79", District_code = "784", Ward_code = "27592" }
        );

            //address  store
            modelBuilder.Entity<Address_store>().HasData(
                    new Address_store { Id = 1, Address_Id = 1 },
                    new Address_store { Id = 2, Address_Id = 2 },
                    new Address_store { Id = 3, Address_Id = 3 },
                    new Address_store { Id = 4, Address_Id = 4 }
                );

            //storage
            modelBuilder.Entity<Storage>().HasData(
                    new Storage { Id = 1, Address_store_id = 1 },
                    new Storage { Id = 2, Address_store_id = 2 },
                    new Storage { Id = 3, Address_store_id = 3 },
                    new Storage { Id = 4, Address_store_id = 4 }
                );

            //Storage
            modelBuilder.Entity<ImportReceipt>().HasData
            (
                // Storage = 1
                new ImportReceipt { Id = 1, Product_Id = 1, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 2, Product_Id = 2, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 3, Product_Id = 3, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 4, Product_Id = 4, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 5, Product_Id = 5, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 6, Product_Id = 6, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 7, Product_Id = 7, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 8, Product_Id = 8, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 9, Product_Id = 9, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 10, Product_Id = 10, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 11, Product_Id = 11, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 12, Product_Id = 12, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 13, Product_Id = 13, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 14, Product_Id = 14, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 15, Product_Id = 15, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 16, Product_Id = 16, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 17, Product_Id = 17, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                new ImportReceipt { Id = 18, Product_Id = 18, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 1 },
                // Storage = 2
                new ImportReceipt { Id = 19, Product_Id = 1, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 20, Product_Id = 2, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 21, Product_Id = 3, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 22, Product_Id = 4, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 23, Product_Id = 5, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 24, Product_Id = 6, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 25, Product_Id = 7, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 26, Product_Id = 8, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 27, Product_Id = 9, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 28, Product_Id = 10, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 29, Product_Id = 11, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 30, Product_Id = 12, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 31, Product_Id = 13, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 32, Product_Id = 14, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 33, Product_Id = 15, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 34, Product_Id = 16, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 35, Product_Id = 17, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                new ImportReceipt { Id = 36, Product_Id = 18, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 2 },
                // Storage = 3
                new ImportReceipt { Id = 37, Product_Id = 1, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 38, Product_Id = 2, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 39, Product_Id = 3, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 40, Product_Id = 4, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 41, Product_Id = 5, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 42, Product_Id = 6, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 43, Product_Id = 7, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 44, Product_Id = 8, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 45, Product_Id = 9, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 46, Product_Id = 10, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 47, Product_Id = 11, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 48, Product_Id = 12, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 49, Product_Id = 13, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 50, Product_Id = 14, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 51, Product_Id = 15, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 52, Product_Id = 16, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 53, Product_Id = 17, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                new ImportReceipt { Id = 54, Product_Id = 18, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 3 },
                // Storage = 4
                new ImportReceipt { Id = 55, Product_Id = 1, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 56, Product_Id = 2, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 57, Product_Id = 3, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 58, Product_Id = 4, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 59, Product_Id = 5, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 60, Product_Id = 6, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 61, Product_Id = 7, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 62, Product_Id = 8, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 63, Product_Id = 9, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 64, Product_Id = 10, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 65, Product_Id = 11, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 66, Product_Id = 12, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 67, Product_Id = 13, Quantity = 10, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 68, Product_Id = 14, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 69, Product_Id = 15, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 70, Product_Id = 16, Quantity = 30, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 71, Product_Id = 17, Quantity = 15, Time = DateTime.Now, Status = "Done", Storage_id = 4 },
                new ImportReceipt { Id = 72, Product_Id = 18, Quantity = 20, Time = DateTime.Now, Status = "Done", Storage_id = 4 }
            );
            //Coupon
            modelBuilder.Entity<Coupon>().HasData(
                    new Coupon { Id = 1, Name = "code coupon", To = 10, From = 15, Percent_discount = 25 },
                    new Coupon { Id = 2, Name = "code coupon 1", To = 15, From = 25, Percent_discount = 50 },
                    new Coupon { Id = 3, Name = "code coupon 2", To = 25, From = 50, Percent_discount = 75 },
                    new Coupon { Id = 4, Name = "code coupon 3", To = 50, From = 1000, Percent_discount = 100 }
                ); */

        }
    }
}
