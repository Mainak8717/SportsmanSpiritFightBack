using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SportsmanSpiritFightBack
{
	public partial class SportsmanSpiritFightBack_HomeScreen : MasterDetailPage
	{
		public List<SideMenuItem> menuList { get; set; }
		public SportsmanSpiritFightBack_HomeScreen()
		{
            InitializeComponent(); 
			BindingContext = new MenuViewModel();
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SportsmanSpiritFightBack_RegisteredUserHome)));

			navigationDrawerList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
			{
				var item = (SideMenuItem)e.SelectedItem;
				Type page = item.TargetType;

				if (item.Title.Equals("Logout"))
				{
					App.Current.MainPage = new SportsmanSpiritFightBack_LoginScreen();
				}
				else
				{
					Detail = new NavigationPage((Page)Activator.CreateInstance(page));
					IsPresented = false;
				}
			};
		}
	}
}
