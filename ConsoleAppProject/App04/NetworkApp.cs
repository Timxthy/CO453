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
            ///Get user to type this information
            PhotoPost photoPost = new PhotoPost("Timothy", "Photo.jpg", "Brooklyn Nets 2021 CHAMPS!");
            feed.AddPhotoPost(photoPost);


        }

        private void PostMessage()
        {
            ///User to enter information - placeholder for now
            MessagePost post = new MessagePost("Timothy", "Brooklyn Nets 2021!");
            feed.AddMessagePost(post);
        }
    }

    }
