using FootballManager.Data;
using FootballManager.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CanInsertSamuraiIntoDatabase()
        {
            using (var context = new FootballManagerContext())
            {
                context.Database.EnsureCreated();
                var club = new Club();
                context.Clubs.Add(club);
                Debug.WriteLine($"Before save: {club.Id}");

                context.SaveChanges();
                Debug.WriteLine($"After save: {club.Id}");

                Assert.AreNotEqual(0, club.Id);
            }
        }
    }
}