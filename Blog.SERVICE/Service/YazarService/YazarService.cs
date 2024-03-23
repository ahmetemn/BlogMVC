using Blog.DATA.Concrate;
using Blog.REPO.Abstract;
using Blog.SERVICE.Models.YazarVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.SERVICE.Service.YazarService
{
    public class YazarService : IYazarService
    {


        private readonly IYazarREPO _yazarRepo;

        public YazarService(IYazarREPO yazarRepo)
        {
            _yazarRepo = yazarRepo;
        }

        public int Create(YazarCreateVms model)
        {

            var yazar = new Yazar
            {
                Name = model.Name,
                ImagePath = model.ImagePath,


            }; 

            return _yazarRepo.Create(yazar); 

        }
    }
}
