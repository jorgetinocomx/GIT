using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// Generic entity.
    /// </summary>
    internal class Entity
    {
        private int identifier;
        private string _description;

        public int Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


    }
}
