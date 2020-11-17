using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMVC.Employees.Dto
{
	public class CreateEmployeeInput
	{
		public string Name { get; set; }

		public GenderEnum Gender { get; set; }

		public DateTime BirthDate { get; set; }

		public string EmailAddress { get; set; }

		public string Jobs { get; set; }
	}
}
