using System.Web;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class WebViewExercise1 : ContentPage
    {
        List<NewsSource> myNewsSources = NewsSource.All.ToList();
        Random rnd = new Random();
        
        public NewsSource CurrentNewsSource { get; set; }


        public WebViewExercise1()
        {
            InitializeComponent();

            CurrentNewsSource = myNewsSources[rnd.Next(0, myNewsSources.Count)];
            BindingContext = this;
        }
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = $"Viewing {CurrentNewsSource.Name}";
        }
    }
}
