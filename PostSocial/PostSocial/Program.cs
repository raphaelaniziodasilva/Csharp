using PostSocial.Entities;

namespace PostSocial {
    internal class Program {
        static void Main(string[] args) {
            // creating comment
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            // creating post
            Post p1 = new Post(
                DateTime.Parse("05/09/2023"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12);

            // adding comment in list of Post using the method
            p1.AddComment(c1);
            p1.AddComment(c2);


            // creating comment
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            // creating post
            Post p2 = new Post(
                DateTime.Parse("11/08/2023"),
                "Good night guys",
                "See you tomorrow!",
                4);

            // adding comment in list of Post using the method
            p2.AddComment(c3);
            p2.AddComment(c4);

            // let's print the content of each post with the comments
            Console.WriteLine(p1);
            Console.WriteLine(p2);






        }
    }
}