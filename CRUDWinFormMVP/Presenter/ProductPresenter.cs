using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUDWinFormMVP.Model;
using CRUDWinFormMVP.Views;

namespace CRUDWinFormMVP.Presenter
{
    public class ProductPresenter
    {
        private IProductView _view;
        private IproductRepository _repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModels> productList;

        public ProductPresenter(IProductView view, IproductRepository repository)
        {
            
            this.productBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchProduct;
            this._view.AddNewEvent += AddNewProduct;
            this._view.EditEvent += LoadSelectedProductToEdit;
            this._view.DeleteEvent += DeleteSelectedProduct;
            // this._view.SaveEvent += SaveProduct;
            // this._view.CancelEvent += CancelAction;
            
            // Set product bindind source
            this._view.SetProductBindingSource(productBindingSource);
            // Load product list view
            LoadAllProductList();
            // Show _view
            this._view.Show();
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
                productList = _repository.GetByValue(this._view.SearchValue);
            else productList = _repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void LoadAllProductList()
        {
            productList = _repository.GetAll();
            productBindingSource.DataSource = productList; // Setting dataSource
        }
    }
}