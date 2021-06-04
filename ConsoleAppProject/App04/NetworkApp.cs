using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        NewsFeed feed = new NewsFeed();
        


        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Timothy's Space");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" + "Display All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.MakeChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostPhoto(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }
                
            } while (!wantToQuit);

        }

        

        private void DisplayAll()
        {
            feed.Display();

        }

        private void PostPhoto()
        {
            Console.WriteLine("Please write your username.");
            string author = Console.ReadLine();

            Console.WriteLine("Please add a file loaction for your image");
            string pPost = Console.ReadLine();

            Console.WriteLine("Please add a caption for your image");
            string caption = Console.ReadLine();


            ///Get user to type this information
            PhotoPost photoPost = new PhotoPost(author, pPost, caption);
            feed.AddPhotoPost(photoPost);


        }

        private void PostMessage()
        {
            Console.WriteLine("Please write your username.");
            string author = Console.ReadLine();

            Console.WriteLine("Please type your comment");
            string comment = Console.ReadLine();


            ///User to enter information - placeholder for now
            MessagePost post = new MessagePost(author, comment);
            feed.AddMessagePost(post);
        }
    }

    }
