using System.Diagnostics;
//using SwoleTrack.ViewModel;

namespace SwoleTrack;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

	}
    //This is the Youtube Button, And the object of "sender"/ being clicked is sending the user to a new page which is the SwoleTrack's Youtube home page.
    private async void Youtube_Button_Clicked(Object sender, EventArgs e)
	{
		try
		{ 
		Uri uri = new("https://www.youtube.com/channel/UCk_KiICUs5r6m3kaZz4AR4A/featured");
		await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
	}

		catch (Exception)
		{ }
		
		
		}
    //This is the Twiiter Button, And the object of "sender"/ being clicked is sending the user to a new page which is the SwoleTrack's Instagram home page.
    private async void Insta_Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Uri inst = new("https://www.instagram.com/swoletrack/");
			await Browser.Default.OpenAsync(inst, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception)
		{}
	}
	//This is the Twiiter Button, And the object of "sender"/ being clicked is sending the user to a new page which is the SwoleTrack's Twitter home page.
	private async void Twitter_Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Uri twitter = new("https://twitter.com/SwoleTrack");
			await Browser.Default.OpenAsync(twitter, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception)
		{ }
	}
	//This is data binding for the array of Qoutes.
	//public HomePage (HomePageViewModel vm)
	//{
	//	InitializeComponent();
	//	BindingContext= vm; 
	//}

	//void UpdatedLabel()
	//{
	//	Qoute.Text = string.Empty;
	//}


}