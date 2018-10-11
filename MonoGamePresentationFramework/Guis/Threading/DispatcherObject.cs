using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MonoGame.Guis.Threading
{
	public abstract class DispatcherObject
	{
		public Dispatcher Dispatcher { get; }
		protected DispatcherObject()
		{

		}
	}
}
