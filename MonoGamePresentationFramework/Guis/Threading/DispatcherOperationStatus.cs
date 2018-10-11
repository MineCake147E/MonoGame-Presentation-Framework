using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame.Guis.Threading
{
	//
	// 概要:
	//     状態の値を示します、 System.Windows.Threading.DispatcherOperationです。
	public enum DispatcherOperationStatus
	{
		//
		// 概要:
		//     操作が保留中とはまだ、 System.Windows.Threading.Dispatcher キューです。
		Pending = 0,
		//
		// 概要:
		//     操作が中止されます。
		Aborted = 1,
		//
		// 概要:
		//     操作を完了するとします。
		Completed = 2,
		//
		// 概要:
		//     操作は実行を開始しましたが完了していません。
		Executing = 3
	}
}
