using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WordCount
{
    public class WordCountTest
    {
        [Test]
        public void empty_input_should_return_0()
        {
            CollectionAssert.AreEqual(new Dictionary<string,int>(),WordCount.Count(""));
        }

        [Test]
        public void input_ali_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int>{{"ali",1}}, WordCount.Count("ali"));
        }

        [Test]
        public void input_ali_ali_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "ali", 2 } }, WordCount.Count("ali ali"));
        }
    }
}
