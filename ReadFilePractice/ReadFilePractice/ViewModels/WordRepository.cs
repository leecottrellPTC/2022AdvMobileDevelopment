using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Java.Nio.Channels;
using ReadFilePractice.Models;
using ReadFilePractice.Viewmodels;

namespace ReadFilePractice.ViewModels
{
    public class WordRepository
    {
        public WordRepository()
        {
            ReadFile();
        }

        public async void ReadFile()
        {
            String line;
            Word word = new Word() ;

            //String DataFile =  @"words.txt";
            // await Application.Current.MainPage.DisplayAlert("Error", DataFile, "OK");
            try
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("words.txt");
                using StreamReader reader = new StreamReader(fileStream);
                while ((line = reader.ReadLine()) != null)
                {
                    word.AWord = line;
                    FullWordList.Add(word);

                }
                await Application.Current.MainPage.DisplayAlert("Count", "I read " + FullWordList.Count, "OK");
                //solutions.SetBinding(ItemsView.ItemsSourceProperty, "wordlist");

                // solutions.ItemsSource= wordlist;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "WTF");
            }


        }
        public List<Word> FullWordList { get; set; }

    }
}
