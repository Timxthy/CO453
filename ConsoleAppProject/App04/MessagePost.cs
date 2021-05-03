using System;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Timothy Arole 
    /// version 0.1
    /// </author>
    ///: means (type) of - link
    public class MessagePost : Post
    {
        

        // an arbitrarily long, multi-line message
        public String Message { get; }

        public DateTime Timestamp { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        ///: - base
        public MessagePost(String author, String text): base(author)
        {
            
            Message = text;
            

            
        }

        public MessagePost(string author) : base(author)
        {
        }
    }
}
