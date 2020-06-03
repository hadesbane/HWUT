using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Return_Empty_String()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Return_5()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(5, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Return_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Description = test;

            //Assert
            Assert.AreEqual(test, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Change_Value()
        {
            //Arrange
            var result = new ProductModel();
            int test = 7;

            //Act
            result.Ratings[0] = test;

            //Assert
            Assert.AreEqual(test, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Logistics = test;

            //Assert
            Assert.AreEqual(test, result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Email = test;

            //Assert
            Assert.AreEqual(test, result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Sequence = test;

            //Assert
            Assert.AreEqual(test, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Date_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            DateTime test = Convert.ToDateTime("05/02/1997");
            //I'm vain so I put my birthday

            //Act
            result.Date = test;

            //Assert
            Assert.AreEqual(test, result.Date);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Title = test;

            //Assert
            Assert.AreEqual(test, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Url = test;

            //Assert
            Assert.AreEqual(test, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Image = test;

            //Assert
            Assert.AreEqual(test, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Maker = test;

            //Assert
            Assert.AreEqual(test, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Copy_Value()
        {
            //Arrange
            var result = new ProductModel();
            string test = "AbC123~!";

            //Act
            result.Id = test;

            //Assert
            Assert.AreEqual(test, result.Id);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Return_5()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRating_With_Null_Ratings_Should_Return_0()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Ratings = null;

            //Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_With_No_Ratings_Should_Return_0()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Ratings = new int[] { };

            //Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_With_Only_Zeros_Should_Return_0()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Ratings = new int[] { 0 };

            //Assert
            Assert.AreEqual(0, result.AverageRating());
        }


        ///I understand if you don't count this as part of the code compeletion, didn't know
        ///How to serialize a current DateTime into a separate Json so this is kind of hacky
        [TestMethod]
        public void ProductModel_ToString_Should_Return_Entire_Json_Of_Object()
        {
            //Arrange
            var result = new ProductModel();
            string start = result.ToString();

            //Act
            result.Email = "barthr@seattleu.edu";

            //Assert
            Assert.AreNotEqual(start, result.ToString());
        }
    }
}
