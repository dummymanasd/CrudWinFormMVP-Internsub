using System;
using System.Windows.Forms;

namespace CRUDWinFormMVP.Views
{
    public interface IProductView
    {
        //properties - Fields
        int PID { get; set; }
        string IName { get; set; }
        string Dessign { get; set; }
        string Colours { get; set; }
        DateTime upDateTime { get; set; }
        DateTime insertDateTime { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool isSucessful { get; set; }
        
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        
        
        //methods
        void SetProductBindingSource(BindingSource productList);
        void Show(); // Optional
    }
}