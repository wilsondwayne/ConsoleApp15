using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </Leo Juster>
    public class MessagePost : Post
    {
        public String Message { get; }

        /// <summary>
        /// Constructor for objects in the MessagePost class
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, string message) : base(author)
        {
            Message = message;
        }
        /// <summary>
        /// This method is abstract and it overides the display method from another
        /// class.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"    Message: {Message}");
            base.Display();
        }
    }
}