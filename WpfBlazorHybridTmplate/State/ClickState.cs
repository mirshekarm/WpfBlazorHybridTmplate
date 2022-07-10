namespace Infrustructrue.State
{
	public class ClickState : Base.StateBase
	{
		public ClickState() : base()
		{
		}

		public string? ClickName { get; private set; }

		public void SetClickName(string name)
		{
			ClickName = name;

			StateHasChanged();
		}
	}
}
