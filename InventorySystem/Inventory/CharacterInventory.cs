using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class CharacterInventory : IInventoryBase
    {
        #region Properties

        public int Size { get; set; }
        Dictionary<string, object> IInventoryBase.contents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Strength { get; set; }

        #endregion

        #region Methods

        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem()
        {
            throw new NotImplementedException();
        }

        public void DisplayInventory()
        {

        }

        public void AddItemToHotBox()
        {

        }

        public void TriggerItemUse()
        {

        }

        public bool TryPickUp()
        {
            bool success = false;

            //if able 
            success = true;

            return success;
        }
        #endregion

    }
}
