using MakeFitMVC.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeFitMVC.Business
{
    public class Login: ILogin
    {

        public bool CheckLoginDetails()
        {
            return true;
        }
    }
}
