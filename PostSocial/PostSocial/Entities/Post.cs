
using System.Text;

namespace PostSocial.Entities {
    internal class Post {
        public DateTime Moment { get; set; }
        public string Titulo { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string titulo, string content, int likes) {
            Moment = moment;
            Titulo = titulo;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        // let's print the content of each post with the comment
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            // let's put the text of each comment
            // for this we will go through the lis of comments and for each element of the list we will add the text of the comments
            foreach(Comment coment in Comments) {
                sb.AppendLine(coment.Text);
            }

            return sb.ToString();
        }


    }
}
