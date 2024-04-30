using System.Net;

namespace Demo.DemoCBIA.Pages;

public partial class cityhandbook : ContentPage
{
	public cityhandbook()
	{
		InitializeComponent();
#if ANDROID
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("pdfviewer", (handler, View) =>
        {
            handler.PlatformView.Settings.AllowFileAccess = true;
            handler.PlatformView.Settings.AllowFileAccessFromFileURLs = true;
            handler.PlatformView.Settings.AllowUniversalAccessFromFileURLs = true;
        });

        pdfview.Source = $"file:///android_asset/pdfjs/web/viewer.html?file=file:///android_asset/{WebUtility.UrlEncode("mumbai_handbook.pdf")}";
#else
        pdfview.Source = "mumbai_handbook.pdf";
#endif
    }
}