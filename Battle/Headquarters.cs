using System;
using System.Collections.Generic;

namespace Battle
{
    public class Headquarters : IHeadquarters
    {
        private int _numberOfVictories;

        public int NumberOfVictories => _numberOfVictories;

        private readonly List<Guid> _deadSoldiers = new List<Guid>();
 
        public Guid ReportEnlistment(string soldierName)
        {
            return Guid.NewGuid();
        }

        public void ReportCasualty(Guid soldierId)
        {
            _deadSoldiers.Add(soldierId);
        }

        public void ReportVictory(int remainingNumberOfSoldiers)
        {
            _numberOfVictories++;
        }
    }
}
