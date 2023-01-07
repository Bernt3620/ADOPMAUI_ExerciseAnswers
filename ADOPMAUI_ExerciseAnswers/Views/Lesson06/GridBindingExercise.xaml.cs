using System;
using System.Collections.Generic;

using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
	public partial class GridBindingExercise : ContentPage
	{
		private GridBindingExerciseViewModel viewModel => BindingContext as GridBindingExerciseViewModel;
		public GridBindingExercise()
		{
			InitializeComponent();
			BindingContext = new GridBindingExerciseViewModel();
		}
	}
}

