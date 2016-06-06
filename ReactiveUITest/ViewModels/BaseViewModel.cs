using System;
using ReactiveUI;

namespace ReactiveUITest
{
	public class BaseViewModel : ReactiveObject
	{
		public SharedDataViewModel SharedDataViewModelInstance 
		{
			get { return SharedDataViewModel.Instance; }
		}
	}
}

