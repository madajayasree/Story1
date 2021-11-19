using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_Task1
{
   public class storyBO
    {
        public List<story> FindStory(List<story> storyList, String authorName)
        {
            List<story> results = new List<story>();
            foreach (var item in storyList)
            {
                if (item.AuthorName.Equals(authorName))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public List<story> FindStory(List<story> storyList, int noOfLikes)
        {
            List<story> results = new List<story>();
            foreach (var item in storyList)
            {
                if (item.NoOfLikes >= noOfLikes)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
