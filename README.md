## Customize Specific Date Cell In Month View Of Calendar Xamarin Ios

Customize Specific Date Cell In Month View Of Calendar Xamarin Ios

## Prerequisites

* Visual Studio 2019 (Xamarin)

## Supported platforms

* Android
* iOS
* Windows (UWP)

## How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio 2019.
* Restore the NuGet packages by rebuilding the solution.
* Run the project.

## Xamarin.Forms Register License

You can register the license key in **App.xaml.cs** constructor before InitializeComponent(). If App constructor not available in **App.xaml.cs**, create the "App()" constructor in **App.xaml.cs** and register the license key inside the constructor.

{% tabs %}
{% highlight c# %}
public App()
{
	//Register Syncfusion<sup>®</sup> license
	Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
	
	InitializeComponent();
	
	MainPage = new App1.MainPage();
}
{% endhighlight %}
{% endtabs %}

If you are developing an application using Gorilla Player SDK, it is must to register the Syncfusion<sup>®</sup> license key in Xamarin.Forms.Android, Xamarin.Forms.iOS, and Xamarin.Forms.UWP.

## Blog reference

[View document in Syncfusion Xamarin.iOS Knowledge base](https://www.syncfusion.com/kb/12262/how-to-customize-the-specific-date-cell-in-month-view-of-xamarin-ios-calendar-sfcalendar)

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
