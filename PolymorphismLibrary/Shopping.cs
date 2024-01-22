using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PolymorphismLibrary
{
    public class Shopping
    {
        public void VerifyId(int id,string Proofname)
        {

            string idval = id.ToString();


        }


        public void VerifyId(string id, string Proofname)
        {
            if (Proofname=="Pan")
            {
                if (id.Length == 10)
                {
                    Console.WriteLine("Valid pan");
                }
                else
                {
                    Console.WriteLine("Invalid pan");
                }
            }
            else
            {
                if (id.Length == 8)
                {
                    Console.WriteLine("Valid passport");
                }
                else
                {
                    Console.WriteLine(  "Invalid PAssport no");
                }
            }
        }




        public void Pay(int amt)
        { }

        public void Pay(int amt,string upi)
        { }
        public bool Pay(int amt, int cardno)
        {
            return true;
        }


    }
}
