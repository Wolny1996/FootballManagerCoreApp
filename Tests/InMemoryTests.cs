using FootballManagerApp3_1.Data;
using FootballManagerApp3_1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class InMemoryTests
    {
        [TestMethod]
        public void CanInsertClubIntoDatabase()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("CanInsertClub");
            using (var context = new FootballManagerContext(builder.Options))
            {
                var club = new Club();
                context.Clubs.Add(club);
                Assert.AreEqual(EntityState.Added, context.Entry(club).State);
            }
        }
    }
}