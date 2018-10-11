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
		//
		// 概要:
		//     決定するかどうか、 System.Windows.Threading.Dispatcher シャット ダウンが完了します。
		//
		// 戻り値:
		//     true ディスパッチャーがシャット ダウンを完了している場合それ以外の場合、 falseです。
		public bool HasShutdownFinished { get; private set; } = false;
		//
		// 概要:
		//     決定するかどうか、 System.Windows.Threading.Dispatcher がシャット ダウンします。
		//
		// 戻り値:
		//     true 場合、 System.Windows.Threading.Dispatcher のシャット ダウン以外の場合が開始 falseします。
		public bool HasShutdownStarted { get; private set; } = false;
		//
		// 概要:
		//     このスレッドを取得 System.Windows.Threading.Dispatcher に関連付けられています。
		//
		// 戻り値:
		//     スレッド。
		public Thread Thread { get; }
	}
}
