using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormMVP.Views;

namespace CRUDWinFormMVP
{
    public partial class Form1 : Form, IProductView
    {
        public Form1()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        
        private void AssociateAndRaiseViewEvents()
        {
            searchBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            pIDtbox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }


        //Properties
        public int PID
        {
            get { return Convert.ToInt32(pIDtbox.Text);}
            set { pIDtbox.Text = value.ToString(); }
        }

        public string IName
        {
            get { return itemNametbox.Text; }
            set { itemNametbox.Text = value; }
        }

        public string Dessign
        {
            get { return designtbox.Text;}
            set { designtbox.Text = value; }
        }
        public string Colours
        {
            get { return colorCombobox.Text;}
            set { colorCombobox.Text = value; }
        }
        public DateTime upDateTime
        {
            get { return Convert.ToDateTime(dateTimePicker1.Text);}
            set { dateTimePicker1.Text = value.ToString(); }
        }
        public DateTime insertDateTime { 
            get { return Convert.ToDateTime(dateTimePicker1.Text);}
            set { dateTimePicker1.Text = value.ToString(); } }

        public string SearchValue
        {
            get { return pIDtbox.Text;}
            set { pIDtbox.Text = value; }
        }
        
        public bool IsEdit { get; set; }

        public bool isSucessful
        {
            get { return isSucessful;}
            set { isSucessful = value; }
        }
        
        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        
        
        //Methods
        public void SetProductBindingSource(BindingSource productList)
        {
            dataGridView1.DataSource = productList;
        }

        
        
        
        
        
        
        

        private void insertbtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}