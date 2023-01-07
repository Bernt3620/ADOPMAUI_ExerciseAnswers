using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
    public partial class NonTrivialBindingExercise2 : ContentPage
    {
        private NonTrivialBindingExercise2_ViewModel _viewModel;

        public NonTrivialBindingExercise2()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NonTrivialBindingExercise2_ViewModel { SliderValue = 0.2F, StepperValue = 2 };
        }


        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Instance Values", 
                $"SliderValue {_viewModel.SliderValue}\nStepperValue {_viewModel.StepperValue}", "OK");


        }
    }

    #region Step 3 and 4
    public class NonTrivialBindingExercise2_ViewModel //: BaseViewModel //Inheritance Step 4
    {
        #region Step 3
        
        public float SliderValue { get; set; }
        public int StepperValue { get; set; }
        
        #endregion

        
        #region Step 4
        /*
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }

        int _steppervalue;
        public int StepperValue
        {
            set => Set<int>(ref _steppervalue, value, "StepperValue");
            get => _steppervalue;
        }
        */
        #endregion

        #region Step 6
        Command _SetMiddleCommand;
        public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
            new Command(() =>
            {
                SliderValue = 0.5F;
                StepperValue = 5;
            }));
        #endregion
    }


    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Step 6
    /* Copy into  BindingExerciseViewModel and replace exisiting properties
    Command _SetMiddleCommand;
    public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
        new Command(() =>
        {
            SliderValue = 0.5F;
            StepperValue = 5;
        }));
    */
    #endregion
}