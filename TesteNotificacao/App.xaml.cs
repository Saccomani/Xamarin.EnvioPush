using PushNotification.Plugin;
using Xamarin.Forms;

namespace TesteNotificacao
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TesteNotificacaoPage();
		}

		protected override void OnStart()
		{
			CrossPushNotification.Current.Register();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
