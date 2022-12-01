using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Android.Provider.UserDictionary;

namespace ReadTextFileLecture
{
    public class TermRepository
    {
		private List<Term> _list;

		public List<Term> TheList
		{
			get { return _list; }
			set { _list = value; }
		}

		private int _termcount;

		public int TermCount
		{
			get { return _termcount; }
			set { _termcount = value; }
		}

        public async void FillWordList()
        {
            String line;
            Term aTerm = new Term();
            try
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("terms.txt");
                using StreamReader reader = new StreamReader(fileStream);
                while ((line = reader.ReadLine()) != null)
                {
                    aTerm = new Term();
                    aTerm.TheTerm = line;
                    _list.Add(aTerm);
                }//end while
                //await App.Current.MainPage.DisplayAlert("Read", "I read " + _list.Count + " words", "OK");
            }
            catch (Exception ex)
            {
                _termcount = -1;    //error condition
                Term error = new Term();
                error.TheTerm = ex.ToString();

            }//end catch
        }//end fillwordlist  

        public TermRepository()
        {
            if(_list == null) { 
                _list = new List<Term>();   
                FillWordList();
                _termcount = _list.Count;
            }
        }
    }//end class
}//end namespace
