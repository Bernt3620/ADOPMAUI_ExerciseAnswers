using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
    public partial class BindingFinal : ContentPage
    {
        public BindingFinal()
        {
            InitializeComponent();
            BindingContext = new BindingFinalViewModel { SliderValue = 0.2F, StepperValue = 0.2F };
        }
    }
}