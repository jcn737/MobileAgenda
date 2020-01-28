using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
	public class Reuniao
	{
		public int ID_Aluno { get; set; }
		public string Nova { get; set; }
		public string Agendadas { get; set; }
		public DateTime Data_Nova { get; set; }
		public DateTime Data_Agendadas { get; set; }
		public DateTime Data_Marcar { get; set; }
		public DateTime Hora_Nova { get; set; }
		public DateTime Hora_Agendadas { get; set; }
		public DateTime Hora_Marcar { get; set; }
	}
}
