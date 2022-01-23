﻿namespace Luciferin.BusinessLayer.Configuration.Interfaces
{
    public interface IImportConfiguration
    {
        #region Properties

        int DaysToSync { get; }
        
        bool ExpendedNotes { get; }

        #endregion
    }
}