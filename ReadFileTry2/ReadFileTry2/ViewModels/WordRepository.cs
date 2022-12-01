using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Java.Util;
using ReadFileTry2.Models;

namespace ReadFileTry2.ViewModels
{
    public class WordRepository
    {

       private List<FiveLetter> _list;

        public List<FiveLetter> WordList
        {
            get { return _list; }
            set { _list = value; }
        }

        public WordRepository()
        {
            _list = new List<FiveLetter>();
            FillWordList();
        }

        public async void FillWordList()
        {

            String line;
            FiveLetter aWord = new FiveLetter();

            //String DataFile =  @"words.txt";
            // await Application.Current.MainPage.DisplayAlert("Error", DataFile, "OK");
            try
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("words.txt");
                using StreamReader reader = new StreamReader(fileStream);
                while ((line = reader.ReadLine()) != null)
                {
                    aWord = new FiveLetter();
                    aWord.Word = line;
                    _list.Add(aWord);

                }
                await Application.Current.MainPage.DisplayAlert("Count", "I read " + _list.Count, "OK");
                //solutions.SetBinding(ItemsView.ItemsSourceProperty, "wordlist");

                // solutions.ItemsSource= wordlist;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "WTF");
            }

           // return _list;
        }
        
        

    }
}
