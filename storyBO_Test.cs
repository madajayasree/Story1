using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exam3_Task1;

namespace Story_BO
{
    [TestFixture]
    class storyBO_Test
    {
        storyBO story = null;
        List<story> lst = new List<story>();

        [SetUp]
        public void setup()
        {
            story = new storyBO();
            lst = new List<story>();
            //string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads
          
            story obj = new story("jaya", "raj", "romance", 43, 24, 100);
            story obj1 = new story("pooja", "dileep", "love", 76,46, 12);
            story obj2 = new story("pujitha", "kumar", "crush", 46, 45, 123);
            story obj3 = new story("sree", "kumar", "laugh", 76, 4, 567);

            lst.Add(obj);
            lst.Add(obj1);
            lst.Add(obj2);
            lst.Add(obj3);


        }
        [Test]
        public void TestSortByAuthorName()
        {
            List<story> result = story.FindStory(lst,"kumar");
            Assert.AreEqual(2,result.Count);

        }

        [Test]
        public void TestSortByNoOfLikes()
        {
            List<story> result = story.FindStory(lst, 24);
            Assert.AreEqual(3, result.Count);
        }

    }
}
