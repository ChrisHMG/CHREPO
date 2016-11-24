using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpPlan.Framework
{
    class DataProvider
    {
        private string _filename = String.Empty;

        private List<RezeptBO> _rezepteList = new List<RezeptBO>();

        public DataProvider (string filename)
        {
            _filename = filename;
            if (!Load())
            {
                Create();
            }
        }

        public void Create()
        {
            _rezepteList.Add(new RezeptBO());
        }

        public bool Load()
        {
            //throw new NotImplementedException();
            bool retval = File.Exists(_filename);

            if (retval)
            {
               
            }

            


            return retval;
        }

    }
}
