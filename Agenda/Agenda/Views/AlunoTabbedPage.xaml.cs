using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoTabbedPage : TabbedPage
    {
        public AlunoTabbedPage()
        {
            InitializeComponent();
        }

        private void btnEnviarProfessora_Clicked(object sender, EventArgs e)
        {

        }
    }
}