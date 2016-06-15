using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMVC
{
    public class Repo
    {
        public List<job> GetJobs()
        {
            pubs2015Entities objx = new pubs2015Entities();
            var x = from n in objx.jobs select n;
            return x.ToList();
        }
    }
}
