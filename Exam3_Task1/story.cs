using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_Task1
{
   public class story
    {
        string name;
        string authorName;
        string genre;
        int noOfChapters;
        int noOfLikes;
        int noOfReads;

        public story()
        {
        }

        public story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.NoOfChapters = noOfChapters;
            this.NoOfLikes = noOfLikes;
            this.NoOfReads = noOfReads;
        }

        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }

        public override string ToString()
        {
            return String.Format("{0,15} {1,15} {2,15} {3,15} {4,15} {5,15}", name,authorName,genre,noOfChapters,noOfLikes,noOfReads);
        }
    
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        


    }
}
