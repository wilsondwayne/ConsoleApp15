using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class SocialNetwork
    {
        /// <summary>
        /// variables for the class.
        /// </summary>
        public int PostID = 0;

        /// <summary>
        /// Object for the news feed.
        /// </summary>
        NewsFeed news = new NewsFeed();

        /// <summary>
        /// The run method.
        /// </summary>
        public void Run()
        {
            DisplayMenu();
        }

        /// <summary>
        /// The display menu for the app.
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Social Network ");

            string[] choices =
            {
              "Post Message", "Post Photo", "Display All Posts By A User", "Display All Posts", "Remove Post", "Quit"
            };

            int exit = 0;

            do
            {
                Console.WriteLine("\nSocial Network Menu \n");
                int choice = ConsoleHelper.SelectChoice(choices);


                if (choice == 1)
                {
                    PostMessage();
                }
                else if (choice == 2)
                {
                    PostPhoto();
                }
                else if (choice == 3)
                {
                    FindUserPosts();
                }
                else if (choice == 4)
                {
                    news.Display();
                }
                else if (choice == 5)
                {
                    RemovePost();
                }
                else if (choice == 6)
                {
                    exit = 1;
                }
            }
            while (exit != 1);
        }


        /// <summary>
        /// This is the post message, this message will appear before you post.
        /// </summary>
        public void PostMessage()
        {
            int id = PostID++;

            Console.WriteLine("\nWhat is your name ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat message would you like to post");
            string message = Console.ReadLine();
            Console.WriteLine();

            MessagePost post = new MessagePost(name, message);
            news.AddMessagePost(post);
        }

        /// <summary>
        /// This will allow you to add an image to your post.
        /// </summary>
        public void PostPhoto()
        {
            int id = PostID++;

            Console.WriteLine("\nPlease enter the author name ");
            string authorname = Console.ReadLine();

            Console.WriteLine("\nInsert filename of your photo ");
            string filename = Console.ReadLine();

            Console.WriteLine("\nPlease write a caption for your photo ");
            string caption = Console.ReadLine();

            PhotoPost photo = new PhotoPost(authorname, filename, caption);
            news.AddPhotoPost(photo);
        }

        /// <summary>
        /// This allows to you search (find) users via their ussername.
        /// </summary>
        public void FindUserPosts()
        {
            Console.WriteLine("\nWhich users posts would you like to find ");
            string user = Console.ReadLine();

            news.FindUser(user);
        }

        /// <summary>
        /// This allows you to remove/delete the post you have posted.
        /// </summary>
        public void RemovePost()
        {
            Console.WriteLine("\nWhat is the ID of the post you would like to remove ");
            int choice = Convert.ToInt32(Console.ReadLine());

            news.FindID(choice);
        }
        /// <summary>
        /// Options of what to do once you have selected the comment option.
        /// </summary>
        /// <param name="post"></param>
        public void MenuChoices(Post post)
        {
            Console.WriteLine("\nWhat would you like to do");
            string[] choices = { "Like this post", "Unlike this post", "Comment on this post" };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                post.Like();
                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 2)
            {
                post.Unlike();
                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 3)
            {
                Console.WriteLine("What comment would you like to add to this post ");
                string comment = Console.ReadLine();

                post.AddComment(comment);

                Console.WriteLine("\nYour action has been recorded ");
            }
        }
    }
}