using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBack_RegisteredUserHome : ContentPage
	{
		public SportsmanSpiritFightBack_RegisteredUserHome()
		{
			InitializeComponent();


		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("FAB Clicked!", "Congrats on creating your FAB!", "Thanks!");
		}
		void OnClick(object sender, EventArgs e)
		{
			ToolbarItem tbi = (ToolbarItem)sender;
			this.DisplayAlert("Selected!", tbi.Text, "OK");
		 }
	}
}
