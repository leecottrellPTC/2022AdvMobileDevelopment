using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilePractice.Models
{
    public class Word : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string name)
		{
			if(this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(name));
			}
		}


		private String _AWord;

		public String AWord
		{
			get { return _AWord; }
			set { _AWord = value;
                OnPropertyChanged("AWord");}


        }

	}
}
