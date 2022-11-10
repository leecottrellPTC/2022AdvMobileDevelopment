using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBaseballPitchCounter.Models;
using System.ComponentModel;

namespace MVVMBaseballPitchCounter.ViewModels
{
    public class PitcherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged(string propertyName)
		{
			if(PropertyChanged != null)
			{
				PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
				this.PropertyChanged(this, args);
			}//sends message to the model
		}

		public Command AddBallCommand { get; private set; }
		public Command AddStrikeCommand { get; private set; }

		public void AddBall()
		{
			pitcher.Balls++;
		}

		public void AddStrike()
		{
			pitcher.Strikes++;
		}

		private Pitcher pitcher;

		public Pitcher ThePitcher
		{
			get { return pitcher; }
			set { pitcher = value; }
		}

		public PitcherViewModel()
		{
			AddBallCommand = new Command(AddBall);
			AddStrikeCommand = new Command(AddStrike);
			pitcher = new Pitcher();
		}

	}
}
