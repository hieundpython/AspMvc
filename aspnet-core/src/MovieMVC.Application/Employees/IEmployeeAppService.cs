using Abp.Application.Services.Dto;
using MovieMVC.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieMVC.Employees
{
	public interface IEmployeeAppService
	{
		Task<PagedResultDto<EmployeeListDto>> GetEmployee(GetEmployeeInput input);

		Task CreateEmployee(CreateEmployeeInput input);

	}
}
