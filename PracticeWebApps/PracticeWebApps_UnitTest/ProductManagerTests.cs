using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_UnitTest.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest
{
    [TestClass]
    public class ProductManagerTests
    {
        private ProductManager _productManager;

        [TestInitialize]
        public void Setup()
        {
            _productManager = new ProductManager(new FakeProductDAL());
        }
        [TestMethod]
        public void LoadProducts_ReturnsProductArrayAndNotNull()
        {
            Product[] products = _productManager.LoadObjects();

            Assert.IsNotNull(products);
            Assert.AreEqual(3, products.Length);
        }
        [TestMethod]
        public void CreateMovie_ValidMovie_ReturnsTrue()
        {
            Product product = new Movie("ValidName", "validDescription", Rating.R, Genre.Documentary, 115, "validPicturePath");
            bool created = _productManager.CreateObject(product);

            Assert.IsTrue(created);
        }
        [TestMethod]
        public void GetMovie_ValidMovie_ReturnsNotNull()
        {
            Product product = (Movie)_productManager.GetObject("Transformers 4");

            Assert.IsNotNull(product);
        }
        [TestMethod]
        public void EditMovie_ValidMovie_ReturnsTrue()
        {
            Product newProduct = new Movie("NewValidName", "newValidDescription", Rating.PG, Genre.Comedy, 155, "newValidPicturePath");

            bool edited = _productManager.EditObject(newProduct, "Transformers 4");

            Assert.IsTrue(edited);
        }
        [TestMethod]
        public void CreateSerie_ValidSerie_ReturnsTrue()
        {
            Product product = new Serie("ValidName", "validDescription", Rating.R, Genre.Documentary, 115, "validPicturePath", 4, 8);
            bool created = _productManager.CreateObject(product);

            Assert.IsTrue(created);
        }
        [TestMethod]
        public void GetSerie_ValidSerie_ReturnsNotNullAndIsInstanceOfType()
        {
            Product serie = (Serie)_productManager.GetObject("The Witcher");

            Assert.IsNotNull(serie);
            Assert.IsInstanceOfType(serie, typeof(Serie));
        }
        [TestMethod]
        public void GetSerie_InvalidSerie_ReturnsNotNulAndNotInstanceOfTypel()
        {
            Product serie = _productManager.GetObject("Transformers 4");

            Assert.IsNotNull(serie);
            Assert.IsNotInstanceOfType(serie, typeof(Serie));

        }
        [TestMethod]
        public void EditSerie_ValidSerie_ReturnsTrue()
        {
            Product newProduct = new Serie("NewValidName", "newValidDescription", Rating.PG, Genre.Comedy, 155, "newValidPicturePath",3,9);

            bool edited = _productManager.EditObject(newProduct, "The Witcher");

            Assert.IsTrue(edited);
        }

    }
}
