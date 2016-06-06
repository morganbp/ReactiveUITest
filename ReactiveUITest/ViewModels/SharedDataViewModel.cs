using System;
using ReactiveUI;

namespace ReactiveUITest
{
	public class SharedDataViewModel : ReactiveObject
	{
		private static SharedDataViewModel _instance;
		private static object _synchLock = new object();
		private object _initSynch = new object();
		private bool _initialized = false;

		public SharedDataViewModel ()
		{
		}

		public static SharedDataViewModel Instance 
		{
			get
			{
				lock (_synchLock) {
					if (_instance == null) {
						_instance = new SharedDataViewModel ();
					}
					return _instance;
				}
			}
		}

		public void EnsureInitialized()
		{
			lock(_initSynch){
				if (!_initialized) {
					Initialize ();
					_initialized = true;
				}		
			}
		}

		public void Initialize(){
			
		}
	}
}

