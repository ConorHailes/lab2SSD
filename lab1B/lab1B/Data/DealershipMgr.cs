using lab1B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1B.Data
{
    public class DealershipMgr

    {
        private List<Dealership> dealerships = new List<Dealership>();

        public DealershipMgr()
        {
       
        }
        public Dealership GetDealership(int id)
        {
            return dealerships.Find(id);
        }
        public void CreateDealership(Dealership dealership)
        {
            dealerships.Add(dealership);  
        }
        public void DeleteDealership()
        {

        }
        public void UpdateDealership()
        {

        }
    }
}
