using System;

//IString

namespace ArrayandStringLibrary.Interfaces
{
    public interface IString
    {
        void AssignWord(string word);
        void AssignSentence(string sentence);
        void GenerateReversedWord();
        void CountWords();
        void ShowReversedWord();
        void ShowWordCount();
    }
}