using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame.Guis.Threading
{
	/// <summary>
	/// Provides data for the DispatcherUnhandledException event.
	/// </summary>
	public sealed class DispatcherUnhandledExceptionEventArgs : DispatcherEventArgs
	{
		/// <summary>
		/// Gets the exception that was raised when executing code by way of the dispatcher.
		/// </summary>
		public Exception Exception { get; }
		/// <summary>
		/// Gets or sets whether the exception event has been handled.
		/// </summary>
		public bool Handled { get; set; }
	}
}
