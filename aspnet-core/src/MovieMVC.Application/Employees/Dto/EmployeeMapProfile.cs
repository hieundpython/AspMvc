using AutoMapper;
using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMVC.Employees.Dto
{
	public class EmployeeMapProfile: Profile
	{
		public EmployeeMapProfile()
		{
			CreateMap<CreateEmployeeInput, Employee>();

			CreateMap<Employee, EmployeeListDto>();

		}
	}
}
