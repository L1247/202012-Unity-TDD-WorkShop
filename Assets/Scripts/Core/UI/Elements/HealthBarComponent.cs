using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarComponent : MonoBehaviour , IHealthBarComponent
    {
    #region Private Variables

        public int MAX   { get; private set; }
        public int Value { get; private set; }

    #endregion

    #region Public Methods

        public float GetAmount() => Value / (float)MAX;

        public int GetMax() => MAX;

        public void SetCurrentValue(int value) => Value = value;

        public void SetMax(int amount) => MAX = amount;

    #endregion
    }
}