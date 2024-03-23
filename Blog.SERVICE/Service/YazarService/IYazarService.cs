using Blog.SERVICE.Models.YazarVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.SERVICE.Service.YazarService
{
    public interface IYazarService
    {

        int Create(YazarCreateVms model);

        //int Update(BurgerUpdateVMs model);


        //Task<int> UpdateStatus(int id);

        //Task<int> Delete(int id);


        //Task<List<Burger>> GetAllBurgers();


        //Task<List<BurgerGetAllVms>> GetAllMenu();

        //Task<List<BurgerGetAllVms>> GetAllActiveMenu();

        //Task<BurgerUpdateVMs> GetMenu(int id);

    }
}
