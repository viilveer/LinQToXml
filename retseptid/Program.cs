using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using retseptid.src;

namespace retseptid
{
    class Program
    {
        static void Main(string[] args)
        {
            InputDecider inputDecider = new InputDecider();
            
            XElement xelement = XElement.Load("..\\..\\retseptid.xml");

            Console.WriteLine("Kirjuta RETSEPT, kui soovid otsida toidu retsepti nime järgi, RETSEPTID, et kuvada kõiki või KOOSTISOSA, et otsida koostisosa järgi.");
            inputDecider.Type = Console.ReadLine();
            inputDecider.Validate("type");

            if (inputDecider.AskKeyword())
            {
                Console.WriteLine("Kirjuta otsisõna.");
                inputDecider.Keyword = Console.ReadLine();
                inputDecider.Validate("keyword");
            }

            IEnumerable<XElement> result = src.QueryProvider.GetResult(xelement, inputDecider.Type, inputDecider.Keyword);
            List<src.Recipe> recipes = src.RecipeFactory.CreateFromXmlElementList(result);

            foreach (src.Recipe recipe in recipes) {
                Console.WriteLine(recipe.GetName());
                foreach (Indigrient indigrient in recipe.GetIndigrients())
                {
                    Console.WriteLine(indigrient.ToString());
                }
               
                Console.WriteLine("----------------------------------------");
            }
                
        }
    }
}
