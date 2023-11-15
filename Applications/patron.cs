using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    class patron
    {
        public string PatronName{ get; set; }
        public int PatronId  { get; set; }
        public string Address  { get; set; }
        public int  PhoneNumber  { get; set; }
        public string EmailId  { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBuy  { get; set; }

        public void addpatron()
        {
            Console.WriteLine("pls enter the patron name:");
            string PatronName = Console.ReadLine();

            Console.WriteLine("pls enter the patron id:");
            int PatronId = int.Parse(Console.ReadLine());

            Console.WriteLine("pls enter address:");
            string Address = Console.ReadLine();

            Console.WriteLine("pls enter the phonenumber:");
            int PhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("pls enter the emailid:");
            string EmailId = Console.ReadLine();

            Console.WriteLine("pls enter the create time:");
            DateTime CreateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("pls enter the createdbuy:");
            string CreateBuy = Console.ReadLine();
        }
    }
}
