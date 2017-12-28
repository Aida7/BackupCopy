using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    class Flash:Storage
    {
        //скорость USB 3.0, объем памяти
        private int SpeedUSB { get; set; }
        private int Memory { get; set; }


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
