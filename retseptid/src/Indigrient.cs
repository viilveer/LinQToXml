using System;

namespace retseptid.src
{
    class Indigrient
    {
        public string Name;

        public string Comment;

        public string Amount;

        public override string ToString()
        {
            return Comment.Length > 0 ? string.Concat(Name, " - ", Amount, " (", Comment, ")") : string.Concat(Name, " - ", Amount);
        }
    }
}
