using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{
    public abstract class Song
    {
        public string author { get; set; }
        public string title { get; set; }
        public Song(string newTitle, string newAuthor)
        {
            this.author = newAuthor;
            this.title = newTitle;
        }

        public abstract string Play();
    }
}
