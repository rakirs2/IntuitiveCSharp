namespace Tests
{
    [TestClass]
    public class MyProgramTests
    {
        [TestMethod]
        public void HelloTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetLastNameTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TryCatch()
        {
            try
            {
                Assert.Fail();
            }
            catch
            {
                throw;
            }
            finally {
               // Yes
            }
        }

        //[TestMethod]
        //public void MyTest()
        //{

        //    string stringToReturn = "qqq";
        //    Mock<MyProgram> name = new Mock<MyProgram>();
        //    name.CallBase = true;
        //    name.Setup(x => x.GetLastName()).Returns(stringToReturn);

        //    var results = name.Object.hello(It.IsAny<string>(), It.IsAny<int>());

        //    string expected = string.Format("hello {0}", results);

        //    Assert.AreEqual(expected, results);
        //}
    }
}