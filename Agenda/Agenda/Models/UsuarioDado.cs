using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
	internal class UsuarioDado
	{
		public string acess_token { get; set; }
		public string token_type { get; set; }
		public int expires_in { get; set; }
		public string userName { get; set; }
	}
}
