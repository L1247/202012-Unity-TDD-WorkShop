using System;
using UnityEngine;

namespace Core.UI.Elements
{
    public interface IHealthBarComponent
    {
    #region Public Variables

        float FillAmount { get; }

    #endregion

    #region Public Methods

        void  DisplayHealth(int   amount , int maxValue);

    #endregion
    }
}