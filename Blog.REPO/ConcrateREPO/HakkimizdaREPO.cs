using Blog.DATA.Concrate;
using Blog.REPO.Abstract;
using Blog.REPO.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.REPO.ConcrateREPO
{
    public class HakkimizdaREPO : BaseBlogREPO<Hakkimizda>, IHakkimizdaREPO
    {
        public HakkimizdaREPO(ApplicationContext context) : base(context)
        {
        }
    }
}
