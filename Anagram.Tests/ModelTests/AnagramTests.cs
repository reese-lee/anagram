using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest //: IDisposable
  {

    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void CharArray_ConvertStringToAnArray_True()
    {
      string newWord = "glug";
      char[] wordArray = newWord.ToCharArray();
      Console.WriteLine(wordArray);
      char[] testArray = { 'g', 'l', 'u', 'g' };
      Assert.AreEqual(wordArray.GetType(), testArray.GetType());
    }

  }
}
