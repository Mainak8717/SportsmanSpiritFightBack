using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBack_LoginScreen : ContentPage
	{
		public SportsmanSpiritFightBack_LoginScreen()
		{
			InitializeComponent();
			var tapGestureRecognizerRegister = new TapGestureRecognizer();
			tapGestureRecognizerRegister.NumberOfTapsRequired = 1;
			tapGestureRecognizerRegister.Tapped += (s, e) => {
				OnRegisterButtonClicked();
			};
			registerLbl.GestureRecognizers.Add(tapGestureRecognizerRegister);		


			var tapGestureRecognizerLogin = new TapGestureRecognizer();
			tapGestureRecognizerLogin.NumberOfTapsRequired = 1;
			tapGestureRecognizerLogin.Tapped += (s, e) => {
				OnLoginButtonClicked();
			};
			signInLbl.GestureRecognizers.Add(tapGestureRecognizerLogin);	



			var tapGestureRecognizerGuest = new TapGestureRecognizer();
			tapGestureRecognizerGuest.NumberOfTapsRequired = 1;
			tapGestureRecognizerGuest.Tapped += (s, e) => {
				OnGuestButtonClicked();
			};
			guestLbl.GestureRecognizers.Add(tapGestureRecognizerGuest);	

		}
		void OnRegisterButtonClicked()
		{
			App.Current.MainPage = new SportsmanSpiritFightBack_RegistrationScreen();
		}
		void OnLoginButtonClicked()
		{
			App.Current.MainPage = new SportsmanSpiritFightBack_HomeScreen();
		}
		void OnGuestButtonClicked()
		{
			App.Current.MainPage = new NavigationPage(new SportsmanSpiritFightBack_RegisteredUserHome());
		}

	}
}
