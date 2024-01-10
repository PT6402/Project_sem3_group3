using System;
using Lib.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lib.Dto.EmployeeDto
{
	public class EmployeeDto
	{
       
        public int Id { get; set; }
        
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public int Employee_type_id { get; set; }
        public int Address_store_id { get; set; }
    }
}

