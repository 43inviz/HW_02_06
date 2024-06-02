using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02_06
{

    //Створіть додаток для підрахунку кількості входжень
    //підрядка в рядок.Користувач вводить вихідний рядок і
    //слово для пошуку.Додаток відображає результат пошуку.
    internal class WordCountInSentence
    {
        public string _sentence;
        public string _searchedWord;
        public int _count;

        public WordCountInSentence() { }
        public WordCountInSentence(string sentence, string searchedWord)
        {
            _sentence = sentence;
            _searchedWord = searchedWord;
          
        }

        public int getCount() { return _count; }

        public void wordCount()
        {
            for(int i = 0; i <= _sentence.Length - _searchedWord.Length; i++)
            {


                if (_sentence[i] == _searchedWord[0])
                {
                    bool isSearchedWord = true;
                    for (int j = 0; j < _searchedWord.Length; j++)
                    {
                        if (_sentence[i + j] != _searchedWord[j])
                        {
                            isSearchedWord = false;

                        }
                    }
                    if (isSearchedWord == true)
                    {
                        _count++;
                        i += _searchedWord.Length;
                    }
                }
            }
        }
    }
}
