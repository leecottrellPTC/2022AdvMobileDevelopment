namespace ReadFilePractice;
using ReadFilePractice.Viewmodels;

public partial class App : Application
{
    WordList theLists ;
    String DataFile = "words.txt";
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        theLists= new WordList();
       // ReadFile();
	}

    //public async void ReadFile()
    //{
    //    String line;
    //    DataFile = FileSystem.AppDataDirectory + @"100words.txt";
    //    await Application.Current.MainPage.DisplayAlert("Error", DataFile, "OK");
    //    try
    //    {
    //        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(DataFile);
    //        using StreamReader reader = new StreamReader(fileStream);
    //        while ((line = reader.ReadLine()) != null)
    //        {
    //            wordlist.Add(line);
    //        }
    //        await Application.Current.MainPage.DisplayAlert("Count", "I read " + wordlist.Count, "OK");
    //    }
    //    catch (Exception ex)
    //    {
    //        await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "WTF");
    //    }
    //}
}
