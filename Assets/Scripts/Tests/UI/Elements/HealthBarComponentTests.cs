#region

using Core.UI.Elements;
using NUnit.Framework;
using UnityEngine;

#endregion

namespace Tests.UI.Elements
{
    public class HealthBarComponentTests
    {
    #region Private Variables

        private GameObject         _gameObject;
        private HealthBarComponent _healthBarComponent;
        private int                _max;

    #endregion

    #region Setup/Teardown Methods

        [SetUp]
        public void SetUp()
        {
            _max                = 100;
            _gameObject         = new GameObject();
            _healthBarComponent = _gameObject.AddComponent<HealthBarComponent>();
        }

    #endregion

    #region Test Methods

        [Test]
        public void GetMax()
        {
            _healthBarComponent.SetMax(_max);
            var healthBarMax = _healthBarComponent.GetMax();
            Assert.AreEqual(_max , healthBarMax);
        }

        [Test]
        public void GetFillAmount()
        {
            _healthBarComponent.SetMax(_max);
            _healthBarComponent.SetCurrentValue(50);
            var amount = _healthBarComponent.GetAmount();
            Assert.AreEqual(0.5f , amount);
        }

    #endregion
    }
}