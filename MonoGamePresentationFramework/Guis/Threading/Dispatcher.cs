using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MonoGame.Guis.Threading
{
	public sealed class Dispatcher
	{
		#region Static Members
		private static Dictionary<Thread, Dispatcher> Dispatchers = new Dictionary<Thread, Dispatcher>();
		public static Dispatcher CurrentDispatcher
		{
			get
			{
				var thread = Thread.CurrentThread;
				if (Dispatchers.TryGetValue(thread, out var result)) return result;
				else
				{
					var dispatcher = new Dispatcher(thread);
					Dispatchers.Add(thread, dispatcher);
					return dispatcher;
				}
			}
		}


		#endregion
		private Dispatcher(Thread thread)
		{
			Thread = thread;
		}
		/// <summary>
		/// Determines whether the Dispatcher has finished shutting down.
		/// </summary>
		public bool HasShutdownFinished { get; private set; } = false;
		/// <summary>
		/// Determines whether the Dispatcher is shutting down.
		/// </summary>
		public bool HasShutdownStarted { get; private set; } = false;
		/// <summary>
		/// Gets the thread this Dispatcher is associated with.
		/// </summary>
		public Thread Thread { get; }

		#region Events
		/// <summary>
		/// Occurs when a thread exception is thrown and uncaught during execution of a delegate by way of Invoke or BeginInvoke.
		/// </summary>
		public event DispatcherUnhandledExceptionEventHandler UnhandledException;
		/// <summary>
		/// Occurs when the Dispatcher finishes shutting down.
		/// </summary>
		public event EventHandler ShutdownFinished;
		/// <summary>
		/// Occurs when the Dispatcher begins to shut down.
		/// </summary>
		public event EventHandler ShutdownStarted;
		#endregion
	}
}
