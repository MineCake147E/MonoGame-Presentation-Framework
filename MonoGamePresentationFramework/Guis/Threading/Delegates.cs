using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame.Guis.Threading
{
	/// <summary>
	/// Represents the method that will handle the UnhandledException event.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The event data.</param>
	public delegate void DispatcherUnhandledExceptionEventHandler(object sender, DispatcherUnhandledExceptionEventArgs e);
}
