using Blog.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DATA.Concrate
{
    public class Yazar:BaseBlog
    {

        public string Name { get; set; }

        public int YazarMakaleSayisi { get; set; }

        public ICollection<Makale> Makales { get; set; }



    }
}
