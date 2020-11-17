using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMVC.Models
{
	public class Employee: FullAuditedEntity
	{
		public virtual string Name { get; set; }
		
		public virtual GenderEnum Gender { get; set; }

		public virtual DateTime BirthDate { get; set; }

		public virtual string EmailAddress { get; set; }

		public virtual string Jobs { get; set; }
	}

	public enum GenderEnum
	{
		Male = 1, 
		Female = 2
	}
}
