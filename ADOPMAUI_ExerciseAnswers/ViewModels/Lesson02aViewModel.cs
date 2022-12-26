using ADOPMAUI_ExerciseAnswers.Views.Lesson02;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_ExerciseAnswers.ViewModels
{
    public class Lesson02aViewModel
    {
        public Lesson02aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson02aViewModel()
        {
            All = new List<Lesson02aViewModel>
            {
                
                new Lesson02aViewModel(typeof(SetProperties1), "Set properties1",
                                      "Togle a BoxView color"),

                new Lesson02aViewModel(typeof(SetProperties2), "Set properties2",
                                      "Add elements using various syntax"),

                new Lesson02aViewModel(typeof(MarkupExtension1), "MarkupExtension1",
                                      "using x:Static"),

                new Lesson02aViewModel(typeof(MarkupExtension2), "MarkupExtension2",
                                      "using OnPlatform"),
                
                new Lesson02aViewModel(typeof(MarkupExtension3), "MarkupExtension3",
                                      "using OnIdiom"),

                new Lesson02aViewModel(typeof(BindingExercise1), "BindingExercise1",
                                      "Databinding to multiple properties"),

                new Lesson02aViewModel(typeof(BindingExercise2), "BindingExercise2",
                        "Databinding using BindingContext"),

/*
                new Lesson02aViewModel(typeof(XamlPlusCodePage), "XAML + Code",
                                      "Interact with a Slider and Button"),

                // Part 2. Essential XAML Syntax
                new Lesson02aViewModel(typeof(GridDemoPage), "Grid Demo",
                                      "Explore XAML syntax with the Grid"),

                 // Part 3. XAML Markup Extensions
                new Lesson02aViewModel(typeof(SharedResourcesPage), "Shared Resources",
                                      "Using resource dictionaries to share resources"),


                new Lesson02aViewModel(typeof(StaticDemoPage), "x:Static Demo",
                                      "Using the x:Static markup extensions"),

                new Lesson02aViewModel(typeof(TypeDemoPage), "x:Type Demo",
                                      "Associate Buttons with a Type"),

                new Lesson02aViewModel(typeof(ReferenceDemoPage), "x:Reference Demo",
                                      "Reference named elements on the page in Binding"),

                new Lesson02aViewModel(typeof(OnPlatformDemoPage), "OnPlatform Demo",
                        "Specify values per platform"),
 
                new Lesson02aViewModel(typeof(OnIdiomDemoPage), "OnIdiom Demo",
                        "Specify values per idiom"),

              
                new Lesson02aViewModel(typeof(SliderBindingsPage), "Slider Bindings",
                                      "Bind properties of two views on the page"),

                new Lesson02aViewModel(typeof(SliderTransformsPage), "Slider Transforms",
                                      "Use Sliders with bindings"),

                 new Lesson02aViewModel(typeof(StringFormattingPage), "String Formatting",
                                      "Use standard .NET formatting specfications"),
                 
                 new Lesson02aViewModel(typeof(MultiBindingStringFormatPage), "String Formatting",
                                      "Combine strings from a MultiBinding"),
*/
            };
        }

        public static IList<Lesson02aViewModel> All { private set; get; }
    }
}
