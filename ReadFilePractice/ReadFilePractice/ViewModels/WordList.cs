using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilePractice.Viewmodels
{
    public class WordList
    {
        public List<String> wordlist { get; set; }
        public List<String> solutions { get; set; }

        public WordList() {
            Application.Current.MainPage.DisplayAlert("WordList", "WordList", "OK");
            ReadFile();
        }

        public async void ReadFile()
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
}
