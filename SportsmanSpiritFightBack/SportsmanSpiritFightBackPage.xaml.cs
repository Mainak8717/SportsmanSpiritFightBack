using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBackPage : ContentPage
	{
		public SportsmanSpiritFightBackPage()
		{
			InitializeComponent();

			var tapGestureRecognizerLogin = new TapGestureRecognizer();
			tapGestureRecognizerLogin.NumberOfTapsRequired = 1;
			tapGestureRecognizerLogin.Tapped += (s, e) => {
				OnLoginButtonClicked();
			};
			loginLbl.GestureRecognizers.Add(tapGestureRecognizerLogin);	

			var tapGestureRecognizerGuest = new TapGestureRecognizer();
			tapGestureRecognizerGuest.NumberOfTapsRequired = 1;
			tapGestureRecognizerGuest.Tapped += (s, e) => {
				OnGuestButtonClicked();
			};
			guestLbl.GestureRecognizers.Add(tapGestureRecognizerGuest);	
		}
		void OnGuestButtonClicked()
		{
			App.Current.MainPage = new NavigationPage(new SportsmanSpiritFightBack_RegisteredUserHome());
		}
		void OnLoginButtonClicked()
		{
			App.Current.MainPage = new SportsmanSpiritFightBack_LoginScreen();
		}
	}
}
