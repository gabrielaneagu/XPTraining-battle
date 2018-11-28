using System;

namespace Battle
{
    public class Headquarters : IHeadquarters
    {
        public Guid ReportEnlistment(string soldierName)
        {
            return Guid.NewGuid();
        }

        public void ReportCasualty(Guid soldierId)
        {
            throw new NotImplementedException();
        }

        public void ReportVictory(int remainingNumberOfSoldiers)
        {
            throw new NotImplementedException();
        }
    }
}
