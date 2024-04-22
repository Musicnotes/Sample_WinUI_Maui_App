using Microsoft.UI.Xaml.Controls;

using MauiTestApp.Code;
using Page = Microsoft.UI.Xaml.Controls.Page;

namespace Musicnotes.WinUniversal
{

    public sealed partial class ViewerPage : Page, IDisposable
    {
      


        #region create & destroy

        public ViewerPage()
        {
            //init

            this.InitializeComponent();


           
        }

  
        public void Dispose()
        {
 
            //ui
        //    WrapGrid.Children.Remove(TopBar);
        //    TopBar = null;

        //    WrapGrid.Children.Remove(DocumentControl);            
        //    DocumentControl = null;
        }

        #endregion


    }
}
