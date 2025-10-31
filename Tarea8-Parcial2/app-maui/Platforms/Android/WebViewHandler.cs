using Android.Webkit;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Tarea8Parcial2.Platforms.Android
{
    public class CustomWebChromeClient : MauiWebChromeClient
    {
        public CustomWebChromeClient(IWebViewHandler handler) : base(handler)
        {
        }

        public override void OnPermissionRequest(PermissionRequest? request)
        {
            if (request == null)
                return;

            var resources = request.GetResources();
            if (resources != null)
            {
                request.Grant(resources);
            }
        }

        public override bool OnShowFileChooser(global::Android.Webkit.WebView? webView, IValueCallback? filePathCallback, FileChooserParams? fileChooserParams)
        {
            return base.OnShowFileChooser(webView, filePathCallback, fileChooserParams);
        }
    }

    public static class WebViewHandlerConfig
    {
        public static void ConfigureWebView()
        {
            WebViewHandler.Mapper.AppendToMapping("CustomWebViewHandler", (handler, view) =>
            {
                if (handler.PlatformView is global::Android.Webkit.WebView webView)
                {
                    webView.Settings.JavaScriptEnabled = true;
                    webView.Settings.DomStorageEnabled = true;
                    webView.Settings.MediaPlaybackRequiresUserGesture = false;
                    webView.Settings.SetGeolocationEnabled(true);

                    webView.SetWebChromeClient(new CustomWebChromeClient(handler));
                }
            });
        }
    }
}
