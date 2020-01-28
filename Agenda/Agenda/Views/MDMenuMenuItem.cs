using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Views
{

    public class MDMenuMenuItem
    {
        public MDMenuMenuItem()
        {
            TargetType = typeof(MDMenuDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type TargetType { get; set; }
    }
}