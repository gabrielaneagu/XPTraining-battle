using System;
using Xunit;

namespace Battle.Tests
{
    public class HeadquartersTest
    {
        [Fact]
        public void Army_ReportsNewSoldier()
        {
            var hq = new Headquarters();
            var army=new Army(hq);

            army.EnlistSoldier(new Soldier("Private Ryan"));

            Assert.NotEqual(default(Guid), army.FrontMan.Id);
        }
    }
}
