using System.Web;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class WebViewExplorePage : ContentPage
    {
        public WebViewExplorePage()
        {
            InitializeComponent();
         }
        public WebViewExplorePage(string Url)
        {
            InitializeComponent();
            myWebView.Source = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(Url)
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
