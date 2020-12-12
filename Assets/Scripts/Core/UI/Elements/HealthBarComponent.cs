using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarComponent : MonoBehaviour , IHealthBarComponent
    {
    #region Private Variables

        private int _max;
        private int _value;

    #endregion

    #region Public Methods

        public float GetAmount() => _value / (float)_max;

        public int GetMax() => _max;

        public void SetCurrentValue(int value) => _value = value;

        public void SetMax(int amount) => _max = amount;

    #endregion
    }
}