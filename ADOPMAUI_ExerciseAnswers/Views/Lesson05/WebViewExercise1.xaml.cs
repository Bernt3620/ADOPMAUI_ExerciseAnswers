using System.Web;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class WebViewExercise1 : ContentPage
    {
        static int NewsSourceIdx = 0; 
        

        List<NewsSource> myNewsSources;
        NewsSource myNewsSource;

        public WebViewExercise1()
        {
            InitializeComponent();
            NewsSourceIdx = 0;

            myNewsSources = NewsSource.All.ToList();
            myNewsSource = myNewsSources[NewsSourceIdx];
        }
        public WebViewExercise1(NewsSource source):this()
        {
            myNewsSource= source;
            BindingContext = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(myNewsSource.Url)
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((Page)this.Parent).Title = $"Viewing {myNewsSource.Name}"; ;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            NewsSourceIdx = (NewsSourceIdx + 1) % myNewsSources.Count;
            await Navigation.PushAsync(new WebViewExercise1(myNewsSources[NewsSourceIdx]));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
