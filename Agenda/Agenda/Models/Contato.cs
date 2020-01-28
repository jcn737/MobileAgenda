using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
	public class Contato
    {
        public int ID_Aluno { get; set; }
        public string Telefone_Diretoria { get; set; }
		public string Telefone_Coordenadoria { get; set; }
		public string Telefone_Secretaria { get; set; }
		public string Telefone_Financeiro { get; set; }
		public string Telefone_Professora { get; set; }
		public string Email_Diretoria { get; set; }
		public string Email_Coordenadoria { get; set; }
		public string Email_Secretaria { get; set; }
		public string Email_Financeiro { get; set; }
		public string Email_Professora { get; set; }			
	}
}
