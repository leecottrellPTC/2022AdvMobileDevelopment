using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBaseballPitchCounter.Models;
using System.ComponentModel;
using Microsoft.Extensions.Configuration;
using SQLite;

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

        public Command NewPitcherCommand { get; private set; }
        public async void NewPitcher()
		{

            //https://stackoverflow.com/questions/72429055/how-to-displayalert-in-a-net-maui-viewmodel
			//DisplayAlert needs to be connected to page
            bool saveIt = await Application.Current.MainPage.DisplayAlert("New Pitcher?", "Save and clear pitcher data?", "Yes", "No");
			if (saveIt)
			{
				App.pitchDbase.InsertPitcher(pitcher);
				pitcher.Name = null;
				pitcher.Balls = 0;
				pitcher.Strikes = 0;
				pitcher.GameDate = DateTime.Today;
			}
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
			NewPitcherCommand = new Command(NewPitcher);
			pitcher = new Pitcher();
		}

	}
}
