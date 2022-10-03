using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public  bool isAPalindrome(string x)
        {
          return   x.ToLower().SequenceEqual(x.ToLower().Reverse());
        }
    }
}
