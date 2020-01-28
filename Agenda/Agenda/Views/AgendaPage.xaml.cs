using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendaPage : ContentPage
    {
		public AgendaPage()
        {
            InitializeComponent();
		}

		private async void btnJan(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new JaneiroPage());
		}
		private async void btnFev(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new FevereiroPage());
		}
		private async void btnMar(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MarcoPage());
		}
		private async void btnAbril(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new AbrilPage());
		}
		private async void btnMaio(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MaioPage());
		}
		private async void btnJun(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new JunhoPage());
		}
		private async void btnJul(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new JulhoPage());
		}
		private async void btnAgo(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new AgostoPage());
		}
		private async void btnSet(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new SetembroPage());
		}
		private async void btnOut(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new OutubroPage());
		}
		private async void btnNov(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new NovembroPage());
		}
		private async void btnDez(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new DezembroPage());
		}
	}
}