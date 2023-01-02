using ADOPMAUI_Exercise.Views.Lesson05;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class Lesson05aViewModel
    {
        public Lesson05aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson05aViewModel()
        {
            All = new List<Lesson05aViewModel>
            {
               new Lesson05aViewModel(typeof(ListViewExercise1), "ListView Exercise1",
                        "Connect a ListView to Datamodel"),

                new Lesson05aViewModel(typeof(ListViewExercise2), "ListView Exercise2",
                        "Customize the ListView by adding images"),

                new Lesson05aViewModel(typeof(ListViewExercise3), "ListView Exercise3",
                        "Customize the ListView by adding buttons"),

                new Lesson05aViewModel(typeof(ListViewExercise4), "ListView Exercise4",
                        "Use Linq to group items"),
            };
        }

        public static IList<Lesson05aViewModel> All { private set; get; }
    }
}
