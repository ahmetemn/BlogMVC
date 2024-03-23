﻿using Blog.DATA.Concrate;
using Blog.REPO.Abstract;
using Blog.REPO.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.REPO.ConcrateREPO
{
    public class MakaleREPO : BaseBlogREPO<Makale>, IMakeleREPO
    {
        public MakaleREPO(ApplicationContext context) : base(context)
        {
        }
    }
}
