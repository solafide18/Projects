using System;
using System.Linq;
using IndoCybreShop.Data;
using IndoCybreShop.Models.TestCandidate;

namespace IndoCybreShop.Repository
{
    public class ShopOrdering
    {
        TestCandidateContext _ctx;
        public ShopOrdering()
        {
            
        }
        public ShopOrdering(TestCandidateContext i_ctx)
        {
            _ctx = i_ctx;
        }
        public string generateOrderNumber()
        {
            string result = "";
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var data = _ctx.runningNumber.Where(f=>f.Year == year && f.RunningMonth == month).FirstOrDefault();
            if(data == null){
                data = new RunningNumber();
                data.Year = year;
                data.RunningMonth = month;
                data.Prefix = "ODR";
                data.CurrentNo = 1;
                _ctx.runningNumber.Add(data);
                _ctx.SaveChanges();
                result = $"{data.Year}/{data.RunningMonth}/{data.Prefix}/{data.CurrentNo.ToString().PadLeft(4,'0')}";
            }else{
                data.CurrentNo++;
                _ctx.runningNumber.Update(data);
                _ctx.SaveChanges();
                result = $"{data.Year}/{data.RunningMonth}/{data.Prefix}/{data.CurrentNo.ToString().PadLeft(4,'0')}";
            }

            return result;
        }
    }
}