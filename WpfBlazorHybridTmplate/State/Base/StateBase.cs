using System;

namespace Infrustructrue.State.Base
{
	public class StateBase
	{
		protected Action _listeners;


		public void AddStateChangeListener(Action listener)
		{
			_listeners += listener;
		}

		public void RemoveStateChangeListener(Action listener)
		{
			_listeners -= listener;
		}

		public void StateHasChanged()
		{
			if (_listeners != null)
			_listeners.Invoke();
		}
	}
}