using CustomerManagement;

namespace TestProject
{
    public class Tests
    {
        private App app;

        [OneTimeSetUp]
        public void Setup()
        {
            app = new App();
        }

        [Test]
        [Order(1)]
        public void AddCustomerShouldSuccess()
        {
            var res = app.AddCustomer(new Customer() { CustomerId = 1, Name = "John", Email = "John@gmail.com", City = "New Delhi", Age = 25 });
            Assert.IsTrue(res);
        }

        [Test]
        [Order(2)]
        public void GetCustomersShouldSuccess() 
        { 
            var res = app.GetAllCustomers();
            Assert.GreaterOrEqual(1, res.Count());
            Assert.IsAssignableFrom<List<Customer>>(res);
        }

        [Test]
        [Order(3)]
        public void GetCustomerByIdShouldSuccess()
        {
            var res = app.GetCustomer(1);
            Assert.IsAssignableFrom<Customer>(res);
            Assert.AreEqual("John", res.Name);
        }

        [Test]
        [Order(4)]
        public void DeleteCustomerShouldFail()
        {
            var res = app.RemoveCustomer(2);
            Assert.IsFalse(res);
        }

        [Test]
        [Order(5)]
        public void DeleteCustomerShouldSuccess()
        {
            var res = app.RemoveCustomer(1);
            Assert.IsTrue(res);
        }
    }
}