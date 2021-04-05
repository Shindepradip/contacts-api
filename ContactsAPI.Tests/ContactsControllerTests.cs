using ContactsAPI.Controllers;
using ContactsAPI.Model;
using ContactsAPI.Services;
using Moq;
using NUnit.Framework;

namespace ContactsAPI.Tests
{
    [TestFixture]
    public class ContactsControllerTests
    {
        private MockRepository _mockRepository;

        private Mock<IContactService> _contactServiceMock;

        [SetUp]
        public void Setup()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _contactServiceMock = new Mock<IContactService>();
        }

        [Test]
        public void Get_Contacts_Return_OK_Result()
        {
            var controller = new ContactsController(_contactServiceMock.Object);

            var data = controller.GetContacts();

            Assert.IsNotNull(data);
        }


        [Test]
        public void Get_ContactByID_Return_OK_Result()
        {
            var controller = new ContactsController(_contactServiceMock.Object);

            var data = controller.GetContacts(1);

            Assert.IsNotNull(data);
        }

        [Test]
        public void Post_Valid_Model_OK_Result()
        {
            var controller = new ContactsController(_contactServiceMock.Object);

            var data = controller.AddContact(new ContactsModel { FirstName = "Pradip", Email = "p.shinde86@gmail.com", LastName = "Shinde", PhoneNumber = "9923888554", Status = true });

            Assert.IsNotNull(data);
        }
    }
}