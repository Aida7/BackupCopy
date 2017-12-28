using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    class DVD:Storage
    {
        //скорость чтения / записи, тип(односторонний (4.7 Гб) /двусторонний(9 Гб)); 
        private int Speed { get; set; }
        //private double unilateral = 4.7;
        //private int bilateral = 9;
        private bool type { get; set; }


        private int memory1;
        private int data1;
        private string name;

        // абстактные методы-получение объема памяти;
        //●	копирование данных(файлов/папок) на устройство,
        //●	получение информации о свободном объеме памяти на устройстве;
        //●	получение общей/полной информации об устройстве
        public override void MemoryCapacity(int memory)
        { this.memory1 = memory; }
        public override void CopyDate(int data)
        { this.data1 = data; }
        public override void GetInformation(bool free)
        {
            if (free == true)
            {
                Console.WriteLine("есть свободное место");
            }
            else
            { Console.WriteLine("нет свободного места"); }
        }
        public override void InformationDevice(string name, int data)
        {
            this.name = name;
            this.data1 = data;
        }
    }
}
