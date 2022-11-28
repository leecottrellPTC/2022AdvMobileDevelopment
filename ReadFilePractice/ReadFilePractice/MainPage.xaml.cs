namespace ReadFilePractice;
using ReadFilePractice.ViewModels;


public partial class MainPage : ContentPage
{
	int count = 0;
    public List<String> wordlist = new List<String>();


	public MainPage()
	{
		InitializeComponent();
		//ReadFile();
	}


    public async void FillList(Object o, EventArgs e)
    {
        //solutions.ItemsSource = 
    }

    public async void ReadFile(Object o, EventArgs e)
	{
        String line;
        
        //String DataFile =  @"words.txt";
       // await Application.Current.MainPage.DisplayAlert("Error", DataFile, "OK");
        try
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("words.txt");
            using StreamReader reader = new StreamReader(fileStream);
            while ((line = reader.ReadLine()) != null)
            {
                wordlist.Add(line);
                
            }
            await Application.Current.MainPage.DisplayAlert("Count", "I read " + wordlist.Count, "OK");
           //solutions.SetBinding(ItemsView.ItemsSourceProperty, "wordlist");
            
           // solutions.ItemsSource= wordlist;
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "WTF");
        }


    }




}

