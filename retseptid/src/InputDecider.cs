using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retseptid.src
{
    class InputDecider
    {
        public string Type;

        public string Keyword;

        public bool AskKeyword()
        {
            string[] askKeywordTypes = {"RETSEPT", "KOOSTISOSA"};
            if (Type != null && askKeywordTypes.Any(Type.Equals))
            {
                return true;
            }
            return false;
        }

        public void Validate(string type)
        {
            if (type == "type")
            {
                ValidateType();
            }

            if (type == "keyword")
            {
               ValidateKeyword();
            }
            
        }

        private void ValidateType()
        {
            string[] askKeywordTypes = { "RETSEPT", "KOOSTISOSA", "RETSEPTID" };

            if (askKeywordTypes.Any(Type.Contains) == false)
            {
                throw new Exception("invalid type");
            }
        }

        private void ValidateKeyword()
        {
            if (Keyword.Length > 36)
            {
                throw new Exception("Otsisõna ei saa pikem olla, kui 36 tähemärki");
            }
        }
    }
}
