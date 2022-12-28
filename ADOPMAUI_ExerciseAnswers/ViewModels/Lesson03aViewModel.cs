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
                                    "Try out StackLayout in this exercise"),
                new Lesson03aViewModel(typeof(AbsoluteLayoutExercise), "AbsoluteLayout Exercise",
                                    "Try out AbsoluteLayout in this exercise"),
                new Lesson03aViewModel(typeof(GridLayoutExercise), "GridLayout Exercise",
                                    "Try out GridLayout in this exercise"),
                new Lesson03aViewModel(typeof(ScrollViewExercise), "ScrollView Exercise",
                                    "Try out ScrollView in this exercise"),
            };
        }

        public static IList<Lesson03aViewModel> All { private set; get; }
    }
}
