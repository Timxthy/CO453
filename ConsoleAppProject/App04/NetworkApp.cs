using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
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
            throw new NotImplementedException();
        }

        private void PostPhoto()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }

    }
