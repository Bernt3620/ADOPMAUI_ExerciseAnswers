using ADOPMAUI_Exercise.Views.Lesson03;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class Lesson03aViewModel
    {
        public Lesson03aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson03aViewModel()
        {
            All = new List<Lesson03aViewModel>
            {
                new Lesson03aViewModel(typeof(StackLayoutExercise), "StackLayout Exercise",
                                    "Try out StackLayout"),
                new Lesson03aViewModel(typeof(AbsoluteLayoutExercise), "AbsoluteLayout Exercise",
                                    "Try out AbsoluteLayout"),
                new Lesson03aViewModel(typeof(GridLayoutExercise), "GridLayout Exercise",
                                    "Try out GridLayout"),
                new Lesson03aViewModel(typeof(ScrollViewExercise), "ScrollView Exercise",
                                    "Try out ScrollView"),
            };
        }

        public static IList<Lesson03aViewModel> All { private set; get; }
    }
}
