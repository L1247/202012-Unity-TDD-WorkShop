using System;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI.Elements
{
    [Serializable]
    public class HealthBarComponent : MonoBehaviour , IHealthBarComponent
    {
    #region Public Variables

        public float FillAmount { get; protected set; }

    #endregion

    #region Private Variables

        [SerializeField]
        protected Image _image;

    #endregion

    #region Public Methods

        public virtual void DisplayHealth(int amount , int maxValue)
        {
            FillAmount        = (float)amount / (float)maxValue;
            _image.fillAmount = FillAmount;
        }

    #endregion
    }
}