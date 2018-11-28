using System;

namespace Battle
{
    public class Headquarters : IHeadquarters
    {
        private int _numberOfVictories;

        public int NumberOfVictories => _numberOfVictories;

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
            _numberOfVictories++;
        }
    }
}
