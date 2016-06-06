using System;
using ReactiveUI;

namespace ReactiveUITest
{
	public class MainViewModel : BaseViewModel
	{

		private string _title;

		public string Title
		{
			get { return _title;}
			set { this.RaiseAndSetIfChanged (ref _title, value);}
		}

		public MainViewModel(){
			this.WhenAnyValue (x => x.Title);
		}
	}
}

