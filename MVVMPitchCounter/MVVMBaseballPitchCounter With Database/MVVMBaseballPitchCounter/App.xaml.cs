using MVVMBaseballPitchCounter.ViewModels;

namespace MVVMBaseballPitchCounter;

public partial class App : Application
{
	public static PitcherDatabase pitchDbase { get; private set; }
	public App(PitcherDatabase database)
	{
		InitializeComponent();

		MainPage = new AppShell();
		pitchDbase = database;
	}
}
