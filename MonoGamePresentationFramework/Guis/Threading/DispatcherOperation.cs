using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame.Guis.Threading
{
	/// <summary>
	/// As same as in WPF, represents an object that is used to interact with an operation that has been posted to the Dispatcher queue.
	/// </summary>
	public class DispatcherOperation
	{
		/// <summary>
		/// Initializes a new DispatcherOperation Object.
		/// TODO: DOCS
		/// </summary>
		/// <param name="dispatcher"></param>
		/// <param name="priority"></param>
		/// <param name="status"></param>
		/// <param name="task"></param>
		internal DispatcherOperation(Dispatcher dispatcher, DispatcherPriority priority, DispatcherOperationStatus status, Task task)
		{
			Dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(dispatcher));
			Priority = priority;
			Status = status;
			Task = task ?? throw new ArgumentNullException(nameof(task));
		}

		/// <summary>
		/// Gets the Dispatcher that the operation was posted to.
		/// </summary>
		public Dispatcher Dispatcher { get; }
		/// <summary>
		/// Gets or sets the priority of the operation in the Dispatcher queue.
		/// </summary>
		public DispatcherPriority Priority { get; set; }
		/// <summary>
		/// Gets the current status of the operation.
		/// </summary>
		public DispatcherOperationStatus Status { get; }
		/// <summary>
		/// Gets a Task<TResult> that represents the current operation.
		/// </summary>
		public Task Task { get; }
		/// <summary>
		/// Gets the result of the operation after it has completed.
		/// </summary>
		public object Result { get; }

		/// <summary>
		/// Occurs when the operation is aborted.
		/// </summary>
		public event EventHandler Aborted;
		/// <summary>
		/// Occurs when the operation has completed.
		/// </summary>
		public event EventHandler Completed;

		/// <summary>
		/// Aborts the opration.
		/// </summary>
		/// <returns>true if the operation was aborted; otherwise, false.</returns>
		/// <remarks>If an operation is already in progress, this method will return false. When an operation is aborted, the Status of the DispatcherOperation is set to Aborted and the Aborted event is raised.</remarks>
		public bool Abort()
		{
			//TODO: Implementation
			throw new NotImplementedException();
		}
		/// <summary>
		/// Returns an object that is notified when the asynchronous operation is finished.
		/// </summary>
		/// <returns>An object that is notified when the asynchronous operation is finished.</returns>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TaskAwaiter GetAwaiter()
		{
			//TODO: Implementation
			throw new NotImplementedException();
		}
		/// <summary>
		/// Waits for the operation to complete
		/// </summary>
		/// <returns>The status of the operation.</returns>
		/// <exception cref="InvalidOperationException">Status is equal to Executing. This can occur when waiting for an operation that is already executing on the same thread.</exception>
		public DispatcherOperationStatus Wait()
		{
			//TODO: Implementation
			throw new NotImplementedException();
		}
		/// <summary>
		/// Waits for the operation to complete in the specified period of time.
		/// </summary>
		/// <param name="timeout">The maximum period of time to wait.</param>
		/// <returns>The status of the operation.</returns>
		/// <exception cref="InvalidOperationException">Status is equal to Executing. This can occur when waiting for an operation that is already executing on the same thread.</exception>
		[SecurityCritical]
		public DispatcherOperationStatus Wait(TimeSpan timeout)
		{
			//TODO: Implementation
			throw new NotImplementedException();
		}
		/// <summary>
		/// Begins the operation that is associated with this DispatcherOperation.
		/// </summary>
		/// <returns>null in all cases.</returns>
		protected virtual object InvokeDelegateCore()
		{
			//TODO: Invocation
			return null;
		}
	}
}
