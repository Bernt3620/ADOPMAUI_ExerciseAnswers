using ADOPMAUI_Exercise.Views.Lesson03;
using Microsoft.Maui.Controls;

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
                    new Lesson03aViewModel(typeof(StackLayoutExploration), "StackLayout Exploration",
                                      "Explore StackLayout before the exercise"),
                    new Lesson03aViewModel(typeof(StackLayoutExercise), "StackLayout Exercise",
                                      "Try your skills in this exercise"),
                    new Lesson03aViewModel(typeof(ScrollViewExercise), "ScrollView Exercise",
                                      "Have fun with ScrollView"),
                    new Lesson03aViewModel(typeof(AbsoluteLayoutExploration), "AbsoluteLayout Exploration",
                                      "Explore AbsoluteLayout before the exercise"),
                    new Lesson03aViewModel(typeof(AbsoluteLayoutExercise), "AbsoluteLayout Exercise",
                                      "Have fun with AbsoluteLayout"),
                    new Lesson03aViewModel(typeof(GridLayoutExploration), "GridLayout Exploration",
                                      "Explore GridLayout before the exercise"),
                    new Lesson03aViewModel(typeof(GridLayoutExercise), "GridLayout Exercise",
                                      "Have fun with GridLayout"),
            };
        }

        public static IList<Lesson03aViewModel> All { private set; get; }
    }
}
