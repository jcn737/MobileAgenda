using Agenda.Models;
using Agenda.Service;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JaneiroPage : ContentPage
    {
        DataService ds = null;
        List<Janeiro> _janeiro = new List<Janeiro>();

        public JaneiroPage()
        {
            InitializeComponent();
            ds = new DataService();
            AtualizaDados();
        }

        public async void AtualizaDados()
        {
            try
            {                
                _janeiro = await ds.GetJaneiroAsync();
                listaJaneiro.ItemsSource = _janeiro.ToList();

                //int idAluno = Convert.ToInt32(txtIdAluno);
                //janeiro = await this.GetJaneiroAsync(idAluno);
                //listaJaneiro.ItemsSource = _janeiro.Where(x => x.ID_Aluno == ds.id).ToList();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro : ", ex.Message, "OK");
                await DisplayAlert("Erro : ", ex.Source, "OK");
            }
        }        
    }
}