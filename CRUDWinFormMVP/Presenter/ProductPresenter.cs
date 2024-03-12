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
        private readonly object _modelDataValidation;

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
           
            
            // Set product bindind source
            this._view.SetProductBindingSource(productBindingSource);
            // Load product list view
            LoadAllProductList();
            // Show _view
            this._view.Show();
        }

       

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            var model = new ProductModels();
            model.ProductId = Convert.ToInt32(_view.PID);
            model.ItemName = _view.IName;
            model.Design = _view.Dessign;
            model.Color = _view.Colours;
            model.InsertedDate = _view.insertDateTime;
            try
            {
                // new Common.ModelDataValidation().Validate(model); this is showing error 
              
                if(_view.IsEdit)//Edit model
                {
                    _repository.Edit(model);
                    // _view.Message = "Pet edited successfuly";
                }
                else //Add new model
                {
                    _repository.Add(model);
                    // _view.Message = "Pet added sucessfully";
                }
                _view.isSucessful = true;
                LoadAllProductList();

            }
            catch (Exception ex)
            {
                _view.isSucessful = false;
              
            }
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
        
        
        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModels)productBindingSource.Current;
                _repository.Delete(product.ProductId);
                _view.isSucessful = true;
                
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                _view.isSucessful = false;
                // _view.Message = "An error ocurred, could not delete product";
            }
        }   
        
        }
    }
