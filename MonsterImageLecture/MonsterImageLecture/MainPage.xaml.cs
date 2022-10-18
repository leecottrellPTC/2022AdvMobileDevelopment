namespace MonsterImageLecture;

public partial class MainPage : ContentPage
{
	private String[] monsters = {"alienmonster.jpg", "fridaymonster.jpg", "halloweenmonster.jpg"};
    private String[] posters = { "alienposter.jpg", "fridayposter.jpg", "halloweenposter.jpg" };

    void OnMovieSelectedIndexChanged(object sender, EventArgs e)
	{
		/*
		 * build var for onscrteen object
		 * get the value from the onscreen object
		 * do something with the value
		 */

		var moviePicker = (Picker)sender;
		int selIndex = moviePicker.SelectedIndex;
		ImageSourceConverter imgCvt = new ImageSourceConverter();

		if (selIndex <0 || selIndex >= monsters.Length)
		{
			//could set blank image, or yell
			return;
		}

		monsterImage.Source = (ImageSource)imgCvt.ConvertFromInvariantString(monsters[selIndex]);
        posterImage.Source = (ImageSource)imgCvt.ConvertFromInvariantString(posters[selIndex]);

    }

	public MainPage()
	{
		InitializeComponent();
	}

	
}

