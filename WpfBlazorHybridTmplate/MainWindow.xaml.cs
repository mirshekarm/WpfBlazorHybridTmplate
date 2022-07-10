using Infrustructrue.State;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace WpfBlazorHybridTmplate
{
	public partial class MainWindow : Window
	{
		public MainWindow(ClickState clickState)
		{
			InitializeComponent();

            ClickState = clickState;

            clickState.AddStateChangeListener(() => ClickStateTextBlock.Text = clickState.ClickName);
        }

        public ClickState ClickState { get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClickState.SetClickName("Wpf clicked!");
        }
    }
}
