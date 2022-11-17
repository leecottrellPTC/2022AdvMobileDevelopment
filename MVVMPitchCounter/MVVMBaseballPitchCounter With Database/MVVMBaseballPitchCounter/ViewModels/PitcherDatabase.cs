using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MVVMBaseballPitchCounter.Models;

using System.ComponentModel;

namespace MVVMBaseballPitchCounter.ViewModels
{
    public class PitcherDatabase
    {
        private SQLiteConnection conn;
        string _dbPath;
        private void Init()
        {
            if (conn != null)
            {
                return;
            }
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Pitcher>();
        }

        public PitcherDatabase(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async void InsertPitcher(Pitcher newPitcher)
        {
            int result = 0;
            try
            {
                Init();
                //if (string.IsNullOrEmpty(newPitcher.Name))
                //{
                //    throw new Exception("Name required");
               // }
                result = conn.Insert(newPitcher);
            }
            catch(Exception ex)
            {
                await MVVMBaseballPitchCounter.App.Current.MainPage.DisplayAlert("Error - not added", 
                    ex.ToString(), "OK");
            }
        }//end Insert

        public List<Pitcher> GetPitchers()
        {
            try
            {
                Init();
                return conn.Table<Pitcher>().OrderBy(p => p.GameDate).ToList();
            }
            catch (Exception ex)
            {
                MVVMBaseballPitchCounter.App.Current.MainPage.DisplayAlert("Error - could not read",
                   ex.ToString(), "OK");
            }
            return new List<Pitcher>();
        }//end Read
    }
}
