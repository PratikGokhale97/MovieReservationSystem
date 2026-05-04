using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.User
{
	public class UpdateUserRoleDto  // This dto is for updating role by admin
	{
		public Role Role { get; set; }
	}
}
