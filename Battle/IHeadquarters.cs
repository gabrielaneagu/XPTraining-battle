﻿using System;

namespace Battle
{
    public interface IHeadquarters
    {
        int NumberOfVictories { get; }

        Guid ReportEnlistment(string soldierName);

        void ReportCasualty(Guid soldierId);

        void ReportVictory(int remainingNumberOfSoldiers);
    }

}
