using System;

namespace Battle
{
    public class Headquarters : IHeadquarters
    {
        public Guid ReportEnlistment(string soldierName)
        {

            throw new NotImplementedException();
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
