namespace Infrustructrue.State
{
	public class CounterState : Base.StateBase
	{
		public CounterState() : base()
		{
		}

		public int Count { get; private set; }

		public void SetCount(int count)
		{
			Count = count;

			StateHasChanged();
		}

		public void IncreamentCount()
		{
			Count++;

			StateHasChanged();
		}
	}
}
