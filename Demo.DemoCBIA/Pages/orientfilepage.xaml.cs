using System.Net;
namespace Demo.DemoCBIA.Pages;

public partial class orientfilepage : ContentPage
{
	public orientfilepage()
	{
		InitializeComponent();
#if ANDROID
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("pdfviewer", (handler, View) =>
        {
            handler.PlatformView.Settings.AllowFileAccess = true;
            handler.PlatformView.Settings.AllowFileAccessFromFileURLs = true;
            handler.PlatformView.Settings.AllowUniversalAccessFromFileURLs = true;
        });

        pdfview.Source = $"file:///android_asset/pdfjs/web/viewer.html?file=file:///android_asset/{WebUtility.UrlEncode("sample-one-day-orientation-schedule.pdf")}";
#else
        pdfview.Source = "sample-one-day-orientation-schedule.pdf";
#endif
    }
}