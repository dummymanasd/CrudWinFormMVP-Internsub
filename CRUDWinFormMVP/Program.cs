using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormMVP.Model;
using CRUDWinFormMVP.Presenter;
using CRUDWinFormMVP.Repository;
using CRUDWinFormMVP.Views;



namespace CRUDWinFormMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // to do this we have to add reference to the project from app.config. but we cannot do this directly in rider so, right click in the project 
            // then go the edit and add reference then you will see many this but add this
            /*<ItemGroup>
             <Reference Include="System.Configuration" />
                <!-- Other references -->
                </ItemGroup> */
            // string sqlConnectionString = "Data Source=LAPTOP-KJLEI0QR\\\\SQLEXPRESS;Initial Catalog=ProjectIntern;Integrated Security=True";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IProductView view = new Form1();
            IproductRepository repo = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repo);
            Application.Run(new Form1());
            //can also do this = Application.Run((Form1)view)
        }
    }
}