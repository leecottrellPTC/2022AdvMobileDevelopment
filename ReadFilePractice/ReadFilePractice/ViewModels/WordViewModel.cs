using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadFilePractice.Models;

namespace ReadFilePractice.ViewModels
{
    public class WordViewModel
    {
        public WordViewModel()
        {
            WordRepository wordRepository = new WordRepository(); ;
            wordList = wordRepository.FullWordList;
        }

        public List<Word> wordList { get; set; }


    }
}
