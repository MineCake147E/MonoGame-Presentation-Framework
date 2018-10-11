using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame.Guis.Threading
{
	/// <summary>
	/// Priority of Dispatcher's Operation
	/// </summary>
	public enum DispatcherPriority
	{
		/// <summary>
		/// The enumeration value is -1. This is an invalid priority.
		/// </summary>
		Invalid = -1,
		/// <summary>
		/// The enumeration value is 0. Operations are not processed.
		/// </summary>
		Inactive = 0,
		/// <summary>
		/// The enumeration value is 1. Operations are processed when the system is idle.
		/// </summary>
		SystemIdle = 1,
		/// <summary>
		/// The enumeration value is 2. Operations are processed when the application is idle.
		/// </summary>
		ApplicationIdle = 2,
		/// <summary>
		/// The enumeration value is 3. Operations are processed after background operations have completed.
		/// </summary>
		ContextIdle = 3,
		/// <summary>
		/// The enumeration value is 4. Operations are processed after all other non-idle operations are completed.
		/// </summary>
		Background = 4,
		/// <summary>
		/// The enumeration value is 5. Operations are processed at the same priority as input.
		/// </summary>
		Input = 5,
		/// <summary>
		/// The enumeration value is 6. Operations are processed when layout and render has finished but just before items at input priority are serviced. Specifically this is used when raising the Loaded event.
		/// </summary>
		Loaded = 6,
		/// <summary>
		/// The enumeration value is 7. Operations processed at the same priority as rendering.
		/// </summary>
		Render = 7,
		/// <summary>
		/// The enumeration value is 8. Operations are processed at the same priority as data binding.
		/// </summary>
		DataBind = 8,
		/// <summary>
		/// The enumeration value is 9. Operations are processed at normal priority. This is the typical application priority.
		/// </summary>
		Normal = 9,
		/// <summary>
		/// The enumeration value is 10. Operations are processed before other asynchronous operations. This is the highest priority.
		/// </summary>
		Send = 10
	}
}
