using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBackPage : ContentPage
	{
		public SportsmanSpiritFightBackPage()
		{
			InitializeComponent();
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.NumberOfTapsRequired = 1;
			tapGestureRecognizer.Tapped += (s, e) => {
				OnLoginButtonClicked();
			};
			loginLbl.GestureRecognizers.Add(tapGestureRecognizer);		
		}

		void OnLoginButtonClicked()
		{
			Navigation.PushAsync(new SportsmanSpiritFightBack_LoginScreen());
		}
	}
}
