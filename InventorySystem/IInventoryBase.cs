using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    /// <summary>
    /// Every vessel will inherit from the IInventory Base.  
    /// Depending on the type of vessel, they will only be able to carry certain objects.  
    /// ie: A house can carry a bed, while a backpack can carry flowers.
    /// </summary>
    interface IInventoryBase
    {
        int Size { get; set; }

        List<object> contents { get; set; }

        void RemoveItem();
        void AddItem();

        void TestMethod();

        void TestMethod2();
    }
}
