using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            
           post.setText( postText);
            post.ShowPost();
           // Console.ReadKey();

        }
    }

    class Post
    {
        private string Text { get; set; }

        //write a constructor here
        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(Text);
        }

        //write a property for member text
        public string getText()
        { return Text; }
        public void setText(string x)
        {  Text=x; }

    }
}
/*
Social Network


You are making a social network application and want to add post creation functionality.
As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
Complete the class with
- a constructor, which outputs "New post" as called,
- Text property, which will allow you to get and set the value of the text field.

Once you have made the changes to the program so that it works correctly, then in main, the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it.

Sample Input
Hello!

Sample Output
New post
Hello!
Recall the value keyword for set accessor.

     */
