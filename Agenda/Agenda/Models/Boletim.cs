using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
	public class Boletim
	{
		public int ID_Aluno { get; set; }
		public string Nome { get; set; }
		public decimal Matematica { get; set; }
		public decimal Portugues { get; set; }
		public decimal Geografia { get; set; }
		public decimal Ingles { get; set; }
		public decimal Fisica { get; set; }
		public decimal Quimica { get; set; }
		public decimal Biologia { get; set; }
		public decimal Artes { get; set; }
		public decimal Musica { get; set; }
		public decimal Educacao_Fisica { get; set; }
		public decimal Atividades_Complementares { get; set; }
	}
}
