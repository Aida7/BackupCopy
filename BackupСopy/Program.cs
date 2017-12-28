using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    public class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            HDD hdd = new HDD();
            Flash flash = new Flash();
            dvd.GetInformation(true);
            dvd.InformationDevice("data", 12);
            dvd.MemoryCapacity(12);
        }
    }
}
