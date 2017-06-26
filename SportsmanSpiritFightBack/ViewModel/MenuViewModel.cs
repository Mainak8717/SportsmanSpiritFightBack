using System;
using System.Collections.Generic;

namespace SportsmanSpiritFightBack
{
public class MenuViewModel
{
	public List<SideMenuItem> MenuItems
	{
		get;
	}
	public MenuViewModel()
	{
		MenuItems = new List<SideMenuItem>();

		var page1 = new SideMenuItem() { Title = "Home", Icon = "Home_Icon.png", TargetType = typeof(SportsmanSpiritFightBack_RegisteredUserHome) };
		var page2 = new SideMenuItem() { Title = "Situation CheckList", Icon = "CheckList_Icon.png",TargetType = typeof(SportsmanSpiritFightBack_SituationChecklist)};
		var page3 = new SideMenuItem() { Title = "Legal Help", Icon = "LegalHelp_Icon.png",TargetType = typeof(SportsmanSpiritFightBack_LegalHelp) };
		var page4 = new SideMenuItem() { Title = "Demo Video", Icon = "Videos_Icon.png",TargetType = typeof(SportsmanSpiritFightBack_DemoVideos) };
		var page5 = new SideMenuItem() { Title = "Follow Up", Icon = "FollowUp_icon.png",TargetType = typeof(SportsmanSpiritFightBack_FollowUp) };
		var page6 = new SideMenuItem() { Title = "Contact Us", Icon = "ContactUs_Icon.png",TargetType = typeof(SportsmanSpiritFightBack_ContactUs) };
		var page7 = new SideMenuItem() { Title = "Logout", Icon = "Logout_Icon.png"};


		// Adding menu items to menuList
		MenuItems.Add(page1);
		MenuItems.Add(page2);
		MenuItems.Add(page3);
		MenuItems.Add(page4);
		MenuItems.Add(page5);
		MenuItems.Add(page6);
		MenuItems.Add(page7);
	}
}
}