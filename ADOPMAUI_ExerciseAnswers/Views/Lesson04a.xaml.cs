using ADOPMAUI_ExerciseAnswers.ViewModels;

namespace ADOPMAUI_ExerciseAnswers.Views
{

    public partial class Lesson04a : ContentPage
    {
        public Lesson04a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson04aViewModel pageData = args.SelectedItem as Lesson04aViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}