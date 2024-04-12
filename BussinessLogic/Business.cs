using System;
using DataLayer;
namespace BussinessLogic
{
    public class Business
    {
        public bool VerifyGroup (string Name)
        {
            GroupInfo DataLayer = new GroupInfo ();
            var result = DataLayer.GetGroup(Name);

            return result.Name != null ? true : false;
        }
    }
}
