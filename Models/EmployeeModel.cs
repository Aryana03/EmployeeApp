﻿namespace EmployeeApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int ManagerId { get; set; }

        public EmployeeModel()
        {

        }

    }
}
