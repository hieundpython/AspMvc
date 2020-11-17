using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMVC.Employees.Dto
{
	public class GetEmployeeInput : PagedAndSortedResultRequestDto
	{
		public string Filter { get; set; }
	}
}
