using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class BindingFinalViewModel : BaseViewModel //Inheritance step 4
    {
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }
        float _steppervalue;
        public float StepperValue
        {
            set => Set<float>(ref _steppervalue, value, "StepperValue");
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
