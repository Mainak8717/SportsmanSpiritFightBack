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
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.NumberOfTapsRequired = 1;
			tapGestureRecognizer.Tapped += (s, e) => {
				OnRegisterButtonClicked();
			};
			registerLbl.GestureRecognizers.Add(tapGestureRecognizer);		
		}
		void OnRegisterButtonClicked()
		{
			Navigation.PushAsync(new SportsmanSpiritFightBack_RegistrationScreen());
		}
	}
}
