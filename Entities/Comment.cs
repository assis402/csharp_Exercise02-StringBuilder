using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercise02_StringBuilder.Entities
{
    class Comment
    {
        public string Text { get;  set; }
        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
