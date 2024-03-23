using Blog.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DATA.Concrate
{
    public class Makale:BaseBlog
    {


        public string MakaleName { get; set; }

        public string ImagePath { get; set; }

        public string MakaleIcerik { get; set; }


        public  int MakeleOkunmaSayisi { get; set; }

        public int  YazarId { get; set; }
        public Yazar Yazar { get; set; }
    }
}
