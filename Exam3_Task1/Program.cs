using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the No of stories");
            Console.WriteLine("Enter  story details seperated by kamas: name,authorname,genre,NoofChapters,NoOfLikes,NoOfRedas");

            int count; 
                count = Convert.ToInt32(Console.ReadLine());

            List<story> story_obj = new List<story>();
            for(int i =0; i<count; i++)
            {
                string story = Console.ReadLine();
                string[] storyDetails = story.Split(',');
                story objjob = new story(storyDetails[0], storyDetails[1], storyDetails[2], int.Parse(storyDetails[3]), int.Parse(storyDetails[4]), int.Parse(storyDetails[5]));

                story_obj.Add(objjob);
            }

            Console.WriteLine("Enter type of search 1:By Author 2:By No Of lIkes");
            int choice = Convert.ToInt32(Console.ReadLine());
            storyBO sbo = new storyBO();
            List<story> Search = null;  


            switch (choice)
            {
                case 1:

                    Console.WriteLine("search by Author");
                    Console.WriteLine("enter Author name");
                    Search = sbo.FindStory(story_obj, Console.ReadLine());

                    break;

                case 2:

                    Console.WriteLine("search by No of Likes");
                    Console.WriteLine("Enter no of likes");
                    Search = sbo.FindStory(story_obj, Convert.ToInt32(Console.ReadLine()));

                    break;

            }

            foreach (var item in Search)
            {
                Console.WriteLine(item);
            }






        }
    }
}
