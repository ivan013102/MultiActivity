using ArrayandStringLibrary.Interfaces;
using System;

//MString

namespace ArrayandStringLibrary.Methods
{
    public class StringProcessor : IString
    {
        private string? _inputWord;
        private string? _flippedWord;
        private string? _inputSentence;
        private int _totalWords;

        public void AssignWord(string word)
        {
            _inputWord = word;
        }


        public void GenerateReversedWord()
        {
            if (!string.IsNullOrEmpty(_inputWord))
            {
                char[] characters = _inputWord.ToCharArray();
                Array.Reverse(characters);
                _flippedWord = new string(characters);
            }
        }

        public void ShowReversedWord()
        {
            Console.WriteLine($"Given Word    : {_inputWord}");
            Console.WriteLine($"Flipped Word  : {_flippedWord}");
        }

        public void AssignSentence(string sentence)
        {
            _inputSentence = sentence;
        }


        public void CountWords()
        {
            if (!string.IsNullOrWhiteSpace(_inputSentence))
            {
                string[] parts = _inputSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                _totalWords = parts.Length;
            }
            else
            {
                _totalWords = 0;
            }
        }


        public void ShowWordCount()
        {
            Console.WriteLine($"Sentence Entered : {_inputSentence}");
            Console.WriteLine($"Number of Words  : {_totalWords}");
        }
    }
}