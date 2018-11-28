using System;

namespace Battle
{
    public class Headquarters : IHeadquarters
    {
        private int _numberOfVictories;

        public int NumberOfVictories => _numberOfVictories;

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
            _numberOfVictories++;
        }
    }
}
