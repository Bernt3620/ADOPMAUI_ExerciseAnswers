using ADOPMAUI_Exercise.Views.Lesson06;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class Lesson06aViewModel
    {
        private static string RoutePrefix = "//lesson6/";
        public Type Type { private set; get; }
        public string Title { private set; get; }
        public string Description { private set; get; }
        public string Route { private set; get; }

        public Lesson06aViewModel(Type type, string title, string description, string route = null)
        {
            Type = type;
            Title = title;
            Description = description;
            Route = route ?? RoutePrefix + Regex.Replace(title.ToLower(), @"\W", "");
        }

        static Lesson06aViewModel()
        {
            All = new List<Lesson06aViewModel>
            {

                new Lesson06aViewModel(typeof(ActivityProgressExercise), "Progress and Activity Indicators",
                        "Add Activity and Progress indicators to a page using and async task"),

                new Lesson06aViewModel(typeof(BindingExercise), "Non Trivial Binding Exercise1",
                        "Implement INotifyPropertyChange"),

                new Lesson06aViewModel(typeof(BindingFinal), "Non Trivial Binding Exercise2",
                        "Implement INotifyPropertyChange"),

                new Lesson06aViewModel(typeof(GridBindingExercise), "Non Trivial Binding Exercise3",
                        "Implement INotifyPropertyChange"),
            };

            foreach (var item in All)
            {
                Routing.RegisterRoute(item.Route, item.Type);
            }
        }

        public static IList<Lesson06aViewModel> All { private set; get; }
    }
}
