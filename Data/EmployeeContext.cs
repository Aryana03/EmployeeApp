using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Data
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Employees;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Email = "michael.scott@nonamecompany.com",
                    Department = "Management",
                    Role = "CEO",
                    isAdmin = true,
                    Username = "MScott",
                    Password = "randompassword"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Alice",
                    LastName = "Rodriguez",
                    Email = "alice.rodriguez@nonamecompany.com",
                    Department = "Marketing",
                    Role = "Marketing Manager",
                    isAdmin = true,
                    Username = "ARodriguez",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Olivia",
                    LastName = "Patel",
                    Email = "olivia.patel@nonamecompany.com",
                    Department = "Human Resources",
                    Role = "HR Coordinator",
                    isAdmin = true,
                    Username = "OPatel",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "David",
                    LastName = "Nguyen",
                    Email = "david.nguyen@nonamecompany.com",
                    Department = "IT",
                    Role = "Software Developer",
                    isAdmin = false,
                    Username = "DNguyen",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Sophia",
                    LastName = "Garcia",
                    Email = "sophia.garcia@nonamecompany.com",
                    Department = "Customer Service",
                    Role = "Customer Support Representative",
                    isAdmin = false,
                    Username = "SGarcia",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Daniel",
                    LastName = "Kim",
                    Email = "daniel.kim@nonamecompany.com",
                    Department = "IT",
                    Role = "Systems Administrator",
                    isAdmin = false,
                    Username = "DKim",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 7,
                    FirstName = "Emily",
                    LastName = "Ali",
                    Email = "emily.ali@nonamecompany.com",
                    Department = "Operations",
                    Role = "Operations Coordinator",
                    isAdmin = false,
                    Username = "EAli",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 8,
                    FirstName = "Amelia",
                    LastName = "Williams",
                    Email = "amelia.williams@nonamecompany.com",
                    Department = "Sales",
                    Role = "Sales Analyst",
                    isAdmin = false,
                    Username = "AWilliams",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 9,
                    FirstName = "Mia",
                    LastName = "Davis",
                    Email = "mia.davis@nonamecompany.com",
                    Department = "IT",
                    Role = "IT Support Specialist",
                    isAdmin = false,
                    Username = "MDavis",
                    Password = "12345"
                },
                new Employee
                {
                    Id = 10,
                    FirstName = "Gabriel",
                    LastName = "Hernandez",
                    Email = "gabriel.hernandez@nonamecompany.com",
                    Department = "Sales",
                    Role = "Sales Support Specialist",
                    isAdmin = false,
                    Username = "GHernandez",
                    Password = "12345"
                }
                );
        }
    }
}
