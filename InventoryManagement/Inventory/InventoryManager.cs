using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Inventory Management
/// </summary>
namespace InventoryManagement.Inventory
{
    class InventoryManager:IManager
    {
        //Adding a details to RiceList
        public List<InventoryUtility.Rice> AddInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter name of rice : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            utility.Type = Console.ReadLine();
            riceList.Add(utility);
            return riceList;
        }
        //Adding a details to PulseList
        public List<InventoryUtility.Pulse> AddInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter name of pulse : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of pulse : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in pulse  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of pulse : ");
            utility.Type = Console.ReadLine();
            pulseList.Add(utility);
            return pulseList;
        }
        //Adding a details to WheatList
        public List<InventoryUtility.Wheat> AddInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter name of wheat : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of wheat : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in wheat  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of wheat : ");
            utility.Type = Console.ReadLine();
            wheatList.Add(utility);
            return wheatList;
        }
        //Updation Process-RiceList
        public List<InventoryUtility.Rice> UpdateInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
          
            Console.WriteLine("Enter name of rice to be update");
            string Name = Console.ReadLine();

            riceList.Remove(riceList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            utility.Type = Console.ReadLine();
            riceList.Add(utility);
            return riceList;
        }
        //Updation Process-PulseList
        public List<InventoryUtility.Pulse> UpdateInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();

            Console.WriteLine("Enter name of pulse to be update");
            string Name = Console.ReadLine();

            pulseList.Remove(pulseList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            utility.Price = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter weight of kg in rice  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            utility.Type = Console.ReadLine();
            pulseList.Add(utility);
            return pulseList;
        }
        //Updation Process-WheatList
        public List<InventoryUtility.Wheat> UpdateInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter name of wheat to be update");
            string Name = Console.ReadLine();

            wheatList.Remove(wheatList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            utility.Type = Console.ReadLine();
            wheatList.Add(utility);
            return wheatList;
        }
        //Removing the details from RiceList
        public List<InventoryUtility.Rice> RemoveInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter name of rice to be deleted");
            string Name = Console.ReadLine();

            riceList.Remove(riceList.Find(ut => ut.Name.Equals(Name)));
            return riceList;
        }
        //Removing the details from PulseList
        public List<InventoryUtility.Pulse> RemoveInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter name of pulse to be deleted");
            string Name = Console.ReadLine();

            pulseList.Remove(pulseList.Find(ut => ut.Name.Equals(Name)));
            return pulseList;
        }
        //Removing the details from WheatList
        public List<InventoryUtility.Wheat> RemoveInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter name of wheat to be deleted");
            string Name = Console.ReadLine();

            wheatList.Remove(wheatList.Find(ut => ut.Name.Equals(Name)));
            return wheatList;
        }
        //   Displaying the details of ricelist,pulselist,wheatlist

        public void DisplayInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.WriteLine("**************Rice Inventory***********");
            //string riceString = " ";
            int totalInventoryRice = 0;
            foreach(InventoryUtility.Rice i in riceList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
            }
            Console.WriteLine("\n Total Inventory Rice cost :"+totalInventoryRice);
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulseList)
        {
            Console.WriteLine("**************Pulse Inventory***********");
           // string pulseString = " ";
            int totalInventoryPulse = 0;
            foreach (InventoryUtility.Pulse i in pulseList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryPulse += ManageInventory(i.Kg, i.Price);
            }
            Console.WriteLine("\n Total Inventory Pulse cost :"+totalInventoryPulse);
        }
        public void DisplayInventory(List<InventoryUtility.Wheat> wheatList)
        {
            Console.WriteLine("**************Wheat Inventory***********");
           // string wheatString = " ";
            int totalInventoryWheat = 0;
            foreach (InventoryUtility.Wheat i in wheatList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryWheat += ManageInventory(i.Kg,i.Price);
               // Console.WriteLine("each type of inventory cost ",totalInventoryWheat);
            }
            Console.WriteLine("\n Total Inventory Wheat cost :"+totalInventoryWheat);
        }
        //calculating the total price
        public int ManageInventory(int Kg,int Price)
        {
            
            return Kg * Price;
        }
    }
}


