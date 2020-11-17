using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Employees.Dto;
using MovieMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Employees
{
	public class EmployeeAppService : MovieMVCAppServiceBase, IEmployeeAppService
	{
		private readonly IRepository<Employee> _employeeRepository;

		public EmployeeAppService(IRepository<Employee> employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}
		public async Task CreateEmployee(CreateEmployeeInput input)
		{
			var employee = ObjectMapper.Map<Employee>(input);
			await _employeeRepository.InsertAsync(employee);
		}

		public async Task<PagedResultDto<EmployeeListDto>> GetEmployee(GetEmployeeInput input)
		{
			var query =  _employeeRepository
				.GetAll()
				.WhereIf(
					!input.Filter.IsNullOrEmpty(),
					p => p.Name.Contains(input.Filter) ||
							p.EmailAddress.Contains(input.Filter));



			var listEmployees = await query.OrderBy(p => p.Name)
				.PageBy(input)
				.ToListAsync();
			var totalCount = await query.CountAsync();

			return new PagedResultDto<EmployeeListDto>(totalCount, ObjectMapper.Map<List<EmployeeListDto>>(listEmployees));
		}
	}
}
