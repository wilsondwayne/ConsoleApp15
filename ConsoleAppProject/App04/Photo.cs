using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This si the class where most methods are held in.
    /// Version 1.0
    /// Dwayne Wilson
    /// </summary>
    public class Post
    {
        /// <summary>
        /// variables and arraylist.
        /// </summary>
        public int ID;

        public string Username;

        public DateTime Timestamp;

        public DateTime Datestamp;

        private static int Instances = 0;

        private int Likes;

        private List<string> Comments;

        /// <summary>
        /// The constructor for the post class
        /// </summary>
        /// <param name="author"></param>
        public Post(string author)
        {
            Instances++;

            ID = Instances;
            Username = author;
            Timestamp = DateTime.Now;
            Datestamp = DateTime.Now;

            Likes = 0;
            Comments = new List<String>();
        }

        /// <summary>
        /// Here you can like the users post. .
        /// (only 1 like)
        /// </summary>
        public void Like()
        {
            Likes++;
        }

        ///<summary>
        /// Here you can unlike the users post.
        ///</summary>
        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }

        ///<summary>
        /// This is where you can comment to the post.
        /// </summary>       
        public void AddComment(String text)
        {
            Comments.Add(text);
        }

        ///<summary>
        /// Details for the post
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    ID: {ID}");
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"    Date: {Datestamp}");
            Console.WriteLine();

            if (Likes > 0)
            {
                Console.WriteLine($"    Likes:  {Likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (Comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {Comments.Count}  comment(s). Click here to view.");
            }
        }

        /// </summary>
        /// String is created to show a timepoint relative to real-time.
        /// </summary>
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

        /// <summary>
        /// return instances
        /// </summary>
        public int GetNumberOfPosts()
        {
            return Instances;
        }
    }
}