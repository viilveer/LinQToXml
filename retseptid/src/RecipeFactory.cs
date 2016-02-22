using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace retseptid.src
{
    class RecipeFactory
    {
        public static List<Recipe> CreateFromXmlElementList(IEnumerable<XElement> document)
        {
            List<Recipe> recipes = new List<Recipe> { };

           // IEnumerable<XElement> retseptid = document;
            foreach (XElement retsept in document)
            {
                Recipe recipe = new Recipe();
                recipe.SetName(retsept.Attribute("toidunimi").Value);
                foreach (XElement koostisosa in retsept.Elements())
                {
                    Indigrient indigrient = new Indigrient
                    {
                        Name = koostisosa.Attribute("nimi").Value,
                        Comment = koostisosa.Attribute("kommentaar").Value,
                        Amount = koostisosa.Attribute("kogus").Value
                    };
                    recipe.AddIndigrient(indigrient);
                }
                recipes.Add(recipe);
            }

            return recipes;
        }
    }
}
