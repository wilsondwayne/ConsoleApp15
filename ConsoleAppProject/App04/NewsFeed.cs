using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</Leo Juster> 
    public class NewsFeed
    {
        /// <summary>
        /// Post arraylist.
        /// </summary>
        private readonly List<Post> Posts;

        ///<summary>
        /// Empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
        }

        /// <summary>
        /// Add a text post to the news feed.
        /// </summary>
        public void AddMessagePost(MessagePost message)
        {
            Posts.Add(message);
        }

        /// <summary>
        /// Add a photo post to the news feed.
        /// </summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            Posts.Add(photo);
        }

        ///<summary>
        /// This is what will show you the news feed.
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post Post in Posts)
            {
                Post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        /// <summary>
        /// Allows you to fins post by username.
        /// </summary>
        public void FindUser(string user)
        {
            int counter = 0;

            foreach (Post Post in Posts)
            {
                if (Post.Username == user)
                {
                    Post.Display();
                    Console.WriteLine();
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("\nNo such user exists in the current context ");
            }
        }

        /// <summary>
        /// This function will find a post by using the ID.
        /// </summary>
        public void FindID(int id)
        {
            int counter = 0;

            foreach (Post Post in Posts)
            {
                if (Post.ID == id)
                {
                    Posts.Remove(Post);
                    Console.WriteLine("Your post has been removed ");
                    return;
                }
            }

            if (counter < 1)
            {
                Console.WriteLine("No such ID of a post exists ");
            }
        }

        /// <summary>
        /// This will allows user to find a post by the ID.
        /// </summary>
        public Post FindPost(int id)
        {
            foreach (Post post in Posts)
            {
                if (id == post.ID)
                {
                    return post;
                }
            }
            return null;
        }
    }

}