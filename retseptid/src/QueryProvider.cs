using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace retseptid.src
{
    class QueryProvider
    {
        public static IEnumerable<XElement> GetResult(XElement element, string type, string keyword)
        {
            IEnumerable<XElement> result;
            switch (type)
            {
                case "RETSEPT":
                    result = from retsept in element.Elements("retsept")
                             where retsept.Attribute("toidunimi").Value.Contains(keyword)
                             select retsept;
                    break;
                case "KOOSTISOSA":
                    result = from retsept in element.Elements("retsept")
                             from koostisosa in retsept.Elements("koostisosa")
                             where koostisosa.Attribute("nimi").Value.Contains(keyword)
                             select retsept;
                    break;
                case "RETSEPTID":
                    result = from retsept in element.Elements("retsept")
                             select retsept;
                    break;
                default:
                    throw new Exception("Unknown type!");
            }

            return result;
        }

    }
}
