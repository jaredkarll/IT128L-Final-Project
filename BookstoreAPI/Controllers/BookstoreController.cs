using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;


namespace BookstoreAPI.Controllers
{
    public class BookstoreController
    {
        private const string ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = BookStoreDB; Integrated Security = True;";


        
        //Displays all data from the Database 
        [HttpGet]
        [Route("/api/[controller]/getitems")]
        public IEnumerable<Item> GetItems()
        {
            var items = new List<Item>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Items";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Item
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Code = reader.GetInt32(2),
                                Brand = reader.GetString(3),
                                Price = reader.GetInt32(4),
                                Quantity = reader.GetDecimal(5)
                            };

                            items.Add(item);
                        }
                    }
                }
            }

            return items;
        }


        //GET data from Database according to Id of the Item
        [HttpGet]
        [Route("/api/[controller]/getitems/{id}")]
        public Item GetItemById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Items WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var item = new Item
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Code = reader.GetInt32(2),
                                Brand = reader.GetString(3),
                                Price = reader.GetInt32(4),
                                Quantity = reader.GetDecimal(5)
                            };

                            return item;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }


        //Posts new Item then inserted to the database
        [HttpPost]
        [Route("/api/[controller]/additems")]
        public void AddItem(AddItem additem)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "INSERT INTO Items (Name, Code, Brand, Price, Quantity) VALUES (@Name, @Code, @Brand, @Price, @Quantity)";

                

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", additem.Name);
                    command.Parameters.AddWithValue("@Code", additem.Code);
                    command.Parameters.AddWithValue("@Brand", additem.Brand);
                    command.Parameters.AddWithValue("@Price", additem.Price);
                    command.Parameters.AddWithValue("@Quantity", additem.Quantity);

                    connection.Open();

                    command.ExecuteNonQuery();
                    
                }
                
            }
            
        }


        //Updates an Item based on Id
        [HttpPut]
        [Route("/api/[controller]/updateitem/{id}")]
        public void UpdateItem(int id, UpdateItem Update)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "UPDATE Items SET Name = @Name, Code = @Code, Brand = @Brand, Price = @Price, Quantity = @Quantity WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();


                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", Update.Name);
                    command.Parameters.AddWithValue("@Code", Update.Code);
                    command.Parameters.AddWithValue("@Brand", Update.Brand);
                    command.Parameters.AddWithValue("@Price", Update.Price);
                    command.Parameters.AddWithValue("@Quantity", Update.Quantity);

                    command.ExecuteNonQuery();
                    connection.Close();
                    //return Ok("Item updated successfully.");

                }
            }
        }


    }
}

