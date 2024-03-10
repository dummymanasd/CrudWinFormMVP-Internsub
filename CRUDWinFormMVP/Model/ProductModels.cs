using System;

namespace CRUDWinFormMVP.Model
{
    public class ProductModels
    {
        //Fields
        private int productID;
        private string itemName;
        private string design;
        private string color;
        private DateTime insertedDate;
        private DateTime updatedDate;

        public int ProductId
        {
            get => productID;
            set => productID = value;
        }

        public string ItemName
        {
            get => itemName;
            set => itemName = value;
        }

        public string Design
        {
            get => design;
            set => design = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public DateTime InsertedDate
        {
            get => insertedDate;
            set => insertedDate = value;
        }

        public DateTime UpdatedDate
        {
            get => updatedDate;
            set => updatedDate = value;
        }
    }
}