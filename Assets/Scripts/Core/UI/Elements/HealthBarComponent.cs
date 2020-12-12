using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarComponent : MonoBehaviour
    {
    #region Private Variables

        private int   _max;
        private int   _value;

    #endregion

    #region Public Methods

        public float GetAmount()
        {
            return _value /(float)_max;
        }

        public int GetMax()
        {
            return _max;
        }

        public void SetCurrentValue(int value)
        {
            _value = value;
        }

        public void SetMax(int amount)
        {
            _max = amount;
        }

    #endregion
    }
}