using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class NonTrivialBindingExercise3_ViewModel : BaseViewModel
    {
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

        Command _SetMiddleCommand;
        public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
            new Command(() =>
            {
                SliderValue = 0.5F;
                StepperValue = 5;
            }));
    }
}
