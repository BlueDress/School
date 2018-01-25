using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ProductsShop.App
{
    public class Startup
    {
        public static void Main()
        {
            //var db = new ShopContext();
            //
            //using (db)
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();
            //}
            //
            //Console.WriteLine(ImportUsersFromJson());
            //Console.WriteLine(ImportCategoriesFromJson());
            //Console.WriteLine(ImportProductsFromJson());

            //SetCategories();

            //ProductsInRangeJson();
            //SuccessfullySoldProducts();
            //CategoriesByProductsCountJson();
            //UsersAndProductsJson();

            //Console.WriteLine(ImportUsersFromXml());
            //Console.WriteLine(ImportCategoriesFromXml());
            //Console.WriteLine(ImportProductsFromXml());

            //ProductsInRangeXml();
            SoldProducts();
            //CategoriesByProductsCountXml();
            //UsersAndProductsXml();
        }

        private static void UsersAndProductsXml()
        {
            var contex = new ShopContext();

            using (contex)
            {
                var users = contex.Users.Where(u => u.ProductsSold.Count > 0).OrderByDescending(u => u.ProductsSold.Count).ThenBy(u => u.LastName).Select(u => new
                {
                    FirstName = u.FirstName == null ? "" : u.FirstName,
                    u.LastName,
                    u.Age,
                    ProductsSold = u.ProductsSold.Select(p => new
                    {
                        p.Price,
                        p.Name
                    })
                });

                var xml = new XDocument(new XElement("users", new XAttribute("count", users.Count())));

                foreach (var user in users)
                {
                    foreach (var product in user.ProductsSold)
                    {
                        if (user.Age != null)
                        {
                            xml.Root.Add(new XElement("user", new XAttribute("first-name", user.FirstName), new XAttribute("last-name", user.LastName), new XAttribute("age", user.Age), new XElement("sold-products", new XAttribute("count", user.ProductsSold.Count()), new XElement("product", new XAttribute("name", product.Name), new XAttribute("price", product.Price)))));
                        }
                        else
                        {
                            xml.Root.Add(new XElement("user", new XAttribute("first-name", user.FirstName), new XAttribute("last-name", user.LastName), new XAttribute("age", "N/A"), new XElement("sold-products", new XAttribute("count", user.ProductsSold.Count()), new XElement("product", new XAttribute("name", product.Name), new XAttribute("price", product.Price)))));
                        }
                    }
                }

                var xmlString = xml.ToString();

                File.WriteAllText("users-and-products.xml", xmlString);
            }
        }

        private static void CategoriesByProductsCountXml()
        {
            var context = new ShopContext();

            using (context)
            {
                var categories = context.Categories.Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.Products.Count,
                    AveragePrice = c.Products.Select(cp => cp.Product.Price).Average(),
                    TotalRevenue = c.Products.Select(cp => cp.Product.Price).Sum(),
                }).OrderBy(c => c.ProductsCount).ToArray();

                var xml = new XDocument(new XElement("categories"));

                foreach (var category in categories)
                {
                    xml.Root.Add(new XElement("category", new XAttribute("name", category.Category), new XElement("products-count", category.ProductsCount), new XElement("average-price", category.AveragePrice), new XElement("total-revenue", category.TotalRevenue)));
                }

                var xmlString = xml.ToString();

                File.WriteAllText("categories-by-products.xml", xmlString);
            }
        }

        private static void SoldProducts()
        {
            var context = new ShopContext();

            using (context)
            {
                var users = context.Users.Where(u => u.ProductsSold.Count > 0).OrderBy(u => u.LastName).ThenBy(u => u.FirstName).Select(u => new
                {
                    FirstName = u.FirstName == null ? "" : u.FirstName,
                    u.LastName,
                    ProductsSold = u.ProductsSold.Select(p => new
                    {
                        Name = p.Name,
                        Price = p.Price
                    })
                });

                var xml = new XDocument(new XElement("users"));

                foreach (var user in users)
                {
                    foreach (var product in user.ProductsSold)
                    {
                        xml.Root.Add(new XElement("user", new XAttribute("first-name", user.FirstName), new XAttribute("last-name", user.LastName), new XElement("sold-products", new XElement("product", new XElement("name", product.Name), new XElement("price", product.Price)))));
                    }
                }

                var xmlString = xml.ToString();

                File.WriteAllText("users-sold-products.xml", xmlString);
            }
        }

        private static void ProductsInRangeXml()
        {
            var context = new ShopContext();

            using (context)
            {
                var products = context.Products.Where(p => p.BuyerId != null && (1000 <= p.Price && p.Price <= 2000)).Select(p => new
                {
                    p.Name,
                    p.Price,
                    BuyerName = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                }).OrderBy(p => p.Price);

                var xml = new XDocument(new XElement("products"));

                foreach (var product in products)
                {
                    xml.Root.Add(new XElement("product", new XAttribute("name", product.Name), new XAttribute("price", product.Price), new XAttribute("buyer", product.BuyerName)));
                }

                var xmlString = xml.ToString();

                File.WriteAllText("products-in-range.xml", xmlString);
            }
        }

        private static string ImportProductsFromXml()
        {
            var textFromXml = File.ReadAllText("Files/products.xml");

            var xmlDoc = XDocument.Parse(textFromXml);

            var elements = xmlDoc.Root.Elements();

            var random = new Random();

            var products = new HashSet<Product>();

            foreach (var element in elements)
            {
                var productName = element.Element("name").Value;
                var productPrice = decimal.Parse(element.Element("price").Value);
                var product = new Product { Name = productName, Price = productPrice };

                products.Add(product);
            }

            var context = new ShopContext();

            using (context)
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();

                foreach (var product in products)
                {
                    var sellerId = random.Next(0, userIds.Length);

                    product.SellerId = userIds[sellerId];

                    var buyerId = sellerId;

                    if (sellerId % 2 != 0)
                    {
                        while (true)
                        {
                            if (buyerId != sellerId)
                            {
                                break;
                            }

                            buyerId = random.Next(0, userIds.Length);
                        }

                        product.BuyerId = userIds[buyerId];
                    }
                }

                context.Products.AddRange(products);
                context.SaveChanges();
            }

            return $"{products.Count} products where imported";
        }

        private static string ImportCategoriesFromXml()
        {
            var textFromXml = File.ReadAllText("Files/categories.xml");

            var xmlDoc = XDocument.Parse(textFromXml);

            var elements = xmlDoc.Root.Elements();

            var categories = new HashSet<Category>();

            foreach (var element in elements)
            {
                var categoryName = element.Element("name").Value;
                var category = new Category { Name = categoryName };

                categories.Add(category);
            }

            var context = new ShopContext();

            using (context)
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            return $"{categories.Count} categories where imported";
        }

        private static string ImportUsersFromXml()
        {
            var textFromXml = File.ReadAllText("Files/users.xml");

            var xmlDoc = XDocument.Parse(textFromXml);
            var elements = xmlDoc.Root.Elements();

            var users = new HashSet<User>();

            foreach (var element in elements)
            {
                var firstName = element.Attribute("firstName")?.Value;
                var lastName = element.Attribute("lastName").Value;
                int? age = null;

                if (element.Attribute("age") != null)
                {
                    age = int.Parse(element.Attribute("age").Value);
                }

                var user = new User { FirstName = firstName, LastName = lastName, Age = age };

                users.Add(user);
            }

            var context = new ShopContext();

            using (context)
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            return $"{users.Count} users where imported";
        }

        private static void UsersAndProductsJson()
        {
            var contex = new ShopContext();

            using (contex)
            {
                var users = contex.Users.Where(u => u.ProductsSold.Count > 0).OrderByDescending(u => u.ProductsSold.Count).ThenBy(u => u.LastName).Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    u.Age,
                    ProductsSoldCount = u.ProductsSold.Count,
                    ProductsSold = u.ProductsSold.Select(p => new
                    {
                        p.Price,
                        p.Name
                    })
                });

                var parsedJson = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText("users-and-products.json", parsedJson);
            }
        }

        private static void CategoriesByProductsCountJson()
        {
            var context = new ShopContext();

            using (context)
            {
                var categories = context.Categories.Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.Products.Count,
                    AveragePrice = c.Products.Select(cp => cp.Product.Price).Average(),
                    TotalRevenue = c.Products.Select(cp => cp.Product.Price).Sum(),
                }).OrderBy(c => c.Category);

                var parsedJson = JsonConvert.SerializeObject(categories, Formatting.Indented);

                File.WriteAllText("categories-by-products.json", parsedJson);
            }
        }

        private static void SuccessfullySoldProducts()
        {
            var context = new ShopContext();

            using (context)
            {
                var users = context.Users.Where(u => u.ProductsSold.Count > 0).Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    ProductsSold = u.ProductsSold.Select(p => new
                    {
                        p.Name,
                        p.Price,
                        p.Buyer.FirstName,
                        p.Buyer.LastName
                    }).ToArray()
                }).OrderBy(u => u.LastName).ThenBy(u => u.FirstName);

                var parsedJson = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText("users-sold-products.json", parsedJson);
            }
        }

        private static void ProductsInRangeJson()
        {
            var context = new ShopContext();

            using (context)
            {
                var products = context.Products.Where(p => p.Price >= 500 && p.Price <= 1000).Select(p => new
                {
                    ProductName = p.Name,
                    Price = p.Price,
                    SellerName = $"{p.Seller.FirstName} {p.Seller.LastName}"
                }).OrderBy(p => p.Price);

                var parsedJson = JsonConvert.SerializeObject(products, Formatting.Indented);

                File.WriteAllText("products-in-range.json", parsedJson);
            }
        }

        private static void SetCategories()
        {
            var context = new ShopContext();

            using (context)
            {
                var productIds = context.Products.Select(p => p.Id).ToArray();
                var categoryIds = context.Categories.Select(c => c.Id).ToArray();

                var random = new Random();

                var categoryProducts = new HashSet<CategoryProduct>();

                foreach (var productId in productIds)
                {
                    var index = random.Next(0, categoryIds.Length);
                    var categoryId = categoryIds[index];
                    var categoryProduct = new CategoryProduct { ProductId = productId, CategoryId = categoryId };
                    categoryProducts.Add(categoryProduct);
                }

                context.CategoryProducts.AddRange(categoryProducts);
                context.SaveChanges();
            }
        }

        private static string ImportProductsFromJson()
        {
            var textFromJson = File.ReadAllText("Files/products.json");

            var random = new Random();

            var products = JsonConvert.DeserializeObject<Product[]>(textFromJson);

            var context = new ShopContext();

            using (context)
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();

                foreach (var product in products)
                {
                    var sellerId = random.Next(0, userIds.Length);

                    product.SellerId = userIds[sellerId];

                    var buyerId = sellerId;

                    if (sellerId % 2 == 0)
                    {
                        while (true)
                        {
                            if (buyerId != sellerId)
                            {
                                break;
                            }

                            buyerId = random.Next(0, userIds.Length);
                        }

                        product.BuyerId = userIds[buyerId];
                    }
                }

                context.Products.AddRange(products);
                context.SaveChanges();
            }

            return $"{products.Length} products where imported";
        }

        private static string ImportCategoriesFromJson()
        {
            var textFromJson = File.ReadAllText("Files/categories.json");

            var categories = JsonConvert.DeserializeObject<Category[]>(textFromJson);

            var context = new ShopContext();

            using (context)
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            return $"{categories.Length} categories where imported";
        }

        private static string ImportUsersFromJson()
        {
            var textFromJson = File.ReadAllText("Files/users.json");

            var users = JsonConvert.DeserializeObject<User[]>(textFromJson);

            var context = new ShopContext();

            using (context)
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            return $"{users.Length} users where imported";
        }
    }
}
