using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public class BuildInOven: Product, ISmiley
    {
        private List<string> _accessoriesList;
        private bool _isClean;

        public void AddAccessory(string item)
        {
            _accessoriesList.Add(item);
        }

        public bool CleanFunction
        {
            get { return _isClean; }
            set{ _isClean = value; }
        }


        public smiley GetSmiley()
        {
            if (_isClean)
                return smiley.Happy;
            else
                return smiley.Neutral;
        }
    }
}
