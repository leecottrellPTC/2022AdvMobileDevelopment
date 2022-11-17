using MVVMBaseballPitchCounter.Models;

namespace MVVMBaseballPitchCounter.Views;

public partial class ShowPitchers : ContentPage
{

	public void FillTheList(object sender, EventArgs args)
	{
		List<Pitcher> pitchers = App.pitchDbase.GetPitchers();
		pitcherList.ItemsSource = pitchers;
	}

    public ShowPitchers()
	{
		InitializeComponent();
	}
}