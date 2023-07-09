namespace MauiApp3;

public partial class MainPage : ContentPage
{

	private TimeOnly time = new();
	private bool isRunning;

	public MainPage()
	{
		InitializeComponent();
	}
	private async void OnStarStop(object sender, EventArgs e)
	{
		isRunning = !isRunning;
		startsStopButton.Source = isRunning ? "pause" : "play";

		while(isRunning)
		{
			time = time.Add(TimeSpan.FromSeconds(1));
			setTime();
			await Task.Delay(TimeSpan.FromSeconds(1));
		}
	}

	private void OnReset(object sender, EventArgs e)
	{
		time = new TimeOnly();
		setTime();
	}



    private void setTime()
	{
		Timer.Text = $"{time.Minute}:{time.Second:000}";
	}
	
}

