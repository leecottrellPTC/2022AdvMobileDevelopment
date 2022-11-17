using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SQLite;

namespace MVVMBaseballPitchCounter.Models
{
	[Table("Pitcher")]
    public class Pitcher:INotifyPropertyChanged
    {
		[PrimaryKey, AutoIncrement]
		public int PitcherPK { get; set; }

		private String _name;
		[MaxLength(100)]
		public String Name
		{
			get { return _name; }
			set { _name = value;
				OnPropertyChanged("Name");
			}
		}

		private DateTime _gameDate;

		
		public DateTime GameDate
		{
			get { return _gameDate; }
			set { _gameDate = value;
				OnPropertyChanged("GameDate");
			}
		}



		private int _balls;
		
		public int Balls
		{
			get { return _balls; }
			set { _balls = value;
				TotalPitches = _balls + _strikes;
				OnPropertyChanged("Balls");
			}
		}

		private int _strikes;

		public int Strikes
		{
			get { return _strikes; }
			set { _strikes = value;
                TotalPitches = _balls + _strikes;
                OnPropertyChanged("Strikes");
            }
		}

		private int _total;

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string Propertyname)
		{
			if(PropertyChanged != null)
			{
				PropertyChangedEventArgs args = new PropertyChangedEventArgs(Propertyname);
				this.PropertyChanged(this, args);

			}
		}

		public int TotalPitches
		{
			get { return _total; }
			set { _total = value;
				OnPropertyChanged("TotalPitches");
			}
		}

		public Pitcher()
		{
			_balls = 0;	
			_strikes = 0;
			_total = 0;
			_gameDate = DateTime.Today;
			//_name = "Nolan Ryan";
		}


	}
}
