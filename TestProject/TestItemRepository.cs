using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ItemService.Models;
using ItemService.Repositories;

namespace TestProject
{
    [TestFixture]
    public class TestItemRepository
    {
        ItemRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRepository(new ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(result.Count, 4);
        }
        [Test]
        public void TestGetById()
        {
            var result = _repo.GetById("I0001");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddItem()
        {
            _repo.AddItem(new Items()
            {
                Itemid = "I0007",
                Name = "ABC",
                Price = 100,
                Stock = 98
            });
            var result = _repo.GetById("I0007");
            Assert.NotNull(result);
        }
        [Test]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("I0007");
            var result = _repo.GetById("I0007");
            Assert.Null(result);
        }
        [Test]
        public void TestUpdate()
        {
            Items item = _repo.GetById("I0001");
            item.Price = 800;
            _repo.UpdateItem(item);
            Items item1 = _repo.GetById("I0001");
            Assert.AreSame(item, item1);
        }
    }
}
