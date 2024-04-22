#if IOS || MACCATALYST
using PlatformView = Microsoft.Maui.Platform.MauiTextField;
#elif ANDROID
using PlatformView = AndroidX.AppCompat.Widget.AppCompatEditText;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.TextBox;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using Microsoft.Maui.Handlers;
using MauiTestApp.Code;
using Musicnotes.WinUniversal;

namespace Musicnotes.Forms.UWP.Code.CustomRenderers.Buttons
{
    public class CustomPageRenderer : ViewHandler<CustomPage, ViewerPage>
    {
        public CustomPageRenderer(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override ViewerPage CreatePlatformView() => new ViewerPage();
    }
}