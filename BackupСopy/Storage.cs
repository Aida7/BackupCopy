using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    public abstract class Storage
    {
        //●	наименование носителя;
        //●	модель
        private string carrierName;
        private string model;

        private int createData;
        private int data;
        private int time;
        
        // абстактные методы-получение объема памяти;
        //●	копирование данных(файлов/папок) на устройство,
        //●	получение информации о свободном объеме памяти на устройстве;
        //●	получение общей/полной информации об устройстве

        public abstract void MemoryCapacity(int m);
        public abstract void CopyDate(int data);
        public abstract void GetInformation(bool free);
        public abstract void InformationDevice(string name,int data);

        public Storage()
        {
            DVD dvd = new DVD();
            HDD hdd = new HDD();
            Flash flash = new Flash();

        }

        //●	расчет общего количества памяти всех устройств;
        //●	копирование информации на устройства;
        //●	расчет времени необходимого для копирования;
        //●	расчет необходимого количества носителей информации представленных типов для переноса информации.
        public void AmountofMemory(int data1,int data2,int data3)
        { createData = data1 + data2 + data3; }
        public void CopyInformation(int data)
        { this.data = data; }
        public  void Time(int data)
        {
            if (data == 100)
            {
                time = 3;
                Console.WriteLine("время для копирования {0}", time);
            }
            else if (data == 200)
            {    time = 5;
             Console.WriteLine("время для копирования {0}",time );
            }
            
            else if (data < 200)
            { time = 6;
                Console.WriteLine("время для копирования {0}", time);
            }
            
        }
        public void CalculationofCarriers(int data)
        {
            DVD dvd = new DVD();
            HDD hdd = new HDD();
            Flash flash = new Flash();
            int count=0;
            int memory=dvd.data, memory1=hdd.data, memory2=flash.data;
            if (data<memory)
            {
                count++;
            }
            else if(data<memory1)
            {
                count++;
            }
            else if(data<memory2)
            {
                count++;
            }
            else
            {
                Console.WriteLine("данные не поместится");
            }   
        }
    }
}
