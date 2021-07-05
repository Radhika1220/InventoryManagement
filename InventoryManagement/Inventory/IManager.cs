using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Inventory
{
    interface IManager
    {
        //
        public List<InventoryUtility.Rice> AddInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> AddInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> AddInventory(List<InventoryUtility.Wheat> wheatList);
        public List<InventoryUtility.Rice> UpdateInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> UpdateInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> UpdateInventory(List<InventoryUtility.Wheat> wheatList);
        public List<InventoryUtility.Rice> RemoveInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> RemoveInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> RemoveInventory(List<InventoryUtility.Wheat> wheatList);
        public void DisplayInventory(List<InventoryUtility.Rice> riceList);
        public void DisplayInventory(List<InventoryUtility.Pulse> pulseList);
        public void DisplayInventory(List<InventoryUtility.Wheat> wheatList);
        public int ManageInventory(int Kg, int Price);
    }
}
