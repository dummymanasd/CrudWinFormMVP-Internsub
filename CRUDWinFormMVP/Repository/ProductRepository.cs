using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CRUDWinFormMVP.Model;

namespace CRUDWinFormMVP.Repository
{
    public class ProductRepository : BaseRepository, IproductRepository
    {
        //Constructor
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModels> GetAll()
        {
            var productList = new List<ProductModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from ProductInfo";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModels = new ProductModels();
                        productModels.ProductId = (int)reader[0];
                        productModels.ItemName = reader[1].ToString();
                        productModels.Design = reader[2].ToString();
                        productModels.Color = reader[3].ToString();
                        productModels.InsertedDate = Convert.ToDateTime(reader[4].ToString());
                        productModels.UpdatedDate = Convert.ToDateTime(reader[4].ToString());
                        productList.Add(productModels);
                    }
                }
            }

            return productList;
            // {
            //     
            // }
        }

        public IEnumerable<ProductModels> GetByValue(string viewSearchValue)
        {
            var productList = new List<ProductModels>();
            int productID = Int32.MaxValue;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from ProductInfo
                                    where ProductID=@id ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productID;


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModels();
                        productModel.ProductId = (int)reader[0];
                        productModel.ItemName = reader[1].ToString();
                        productModel.Design = reader[2].ToString();
                        productModel.Color = reader[3].ToString();
                        productModel.InsertedDate = Convert.ToDateTime(reader[4].ToString());
                        productModel.UpdatedDate = Convert.ToDateTime(reader[4].ToString());
                        productList.Add(productModel);
                    }
                }
            }

            return productList;
        }

        public void Add(ProductModels productModels)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into ProductInfo values (@id, @item, @design, @color,@insertdate)";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModels.ProductId;
                command.Parameters.Add("@item", SqlDbType.NVarChar).Value = productModels.ItemName;
                command.Parameters.Add("@design", SqlDbType.NVarChar).Value = productModels.Design;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = productModels.Color;
                command.Parameters.Add("@insertdate", SqlDbType.DateTime).Value = productModels.InsertedDate;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModels productModels)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update ProductInfo set ItemName=@item,Design= @desgin,Color= @color , UpdateDate = @udate
                                    where ProductID=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModels.ProductId;
                command.Parameters.Add("@item", SqlDbType.NVarChar).Value = productModels.ItemName;
                command.Parameters.Add("@design", SqlDbType.NVarChar).Value = productModels.Design;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = productModels.Color;
                command.Parameters.Add("@udate", SqlDbType.DateTime).Value = productModels.UpdatedDate;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(ProductModels productModels)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from ProductInfo where ProductID=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModels.ProductId;           
                command.ExecuteNonQuery();
            }
        }
    }
}