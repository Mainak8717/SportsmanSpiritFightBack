using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBack_RegistrationScreen : ContentPage
	{
		public SportsmanSpiritFightBack_RegistrationScreen()
		{
			InitializeComponent();
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.NumberOfTapsRequired = 1;
			tapGestureRecognizer.Tapped += (s, e) => {
				OnRegisterButtonClicked();
			};
		Register.GestureRecognizers.Add(tapGestureRecognizer);	
		}
		void OnRegisterButtonClicked()
		{
			App.Current.MainPage = new SportsmanSpiritFightBack_HomeScreen();
		}
	}
}
