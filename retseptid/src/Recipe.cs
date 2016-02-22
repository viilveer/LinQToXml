using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retseptid.src
{
    class Recipe
    {
        private string _name;

        private List<Indigrient> _indigrients = new List<Indigrient> { };

        public void SetName(string name)
        {
            _name = name;
        }

        public void AddIndigrient(Indigrient indigrient)
        {
            this._indigrients.Add(indigrient);
        }

        public string GetName()
        {
            return _name;
        }

        public List<Indigrient> GetIndigrients()
        {
            return _indigrients;
        }
    }
}
