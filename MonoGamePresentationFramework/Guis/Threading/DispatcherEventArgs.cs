using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame.Guis.Threading
{
	/// <summary>
	/// Dispatcher related event.
	/// </summary>
	public class DispatcherEventArgs : EventArgs
	{
		/// <summary>
		/// Dispatcher that relates to this event.
		/// </summary>
		public Dispatcher Dispatcher { get; }
	}
}
