using System;

namespace Algorithms
{
   public static  class PalidromeEquality
    {
       public static bool IsPalindrome (string wordTocomapre)
        {
            //read the word backbawars
            // start from the end write to a temp
            //compare with origunal
            var wordChars = wordTocomapre.ToCharArray();
            Array.Reverse(wordChars);
            var revWord = new string(wordChars);

            return wordTocomapre.Equals(revWord);
        }

        public static bool IsPalindromePhrase(string wordTocomapre)
        {
            //trim
            var phrase = wordTocomapre.ToLower().Trim();
            var wordChars = phrase.ToCharArray();
            
            var temp = Array.FindAll(wordChars,x => char.IsLetterOrDigit(x));
            return IsPalindrome(new string(temp));
        }
    }

    public class Dog:Animal
    {
        public Dog()
        {
           
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Sound(int loud)
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }

    public abstract class Animal
    {
        public abstract void Move();
        public abstract void Sound(int loud);

        public virtual void Draw()
        {
            Console.WriteLine("draw");
        }
    }
}
