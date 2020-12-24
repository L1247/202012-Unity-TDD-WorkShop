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
        [TestCase(100,100,1f)]
        [TestCase(100,200,0.5f)]
        [TestCase(0,200,0f)]
        public void DisplayHealth(int amount , int maxValue , float expected)
        {
            _healthBarComponent.DisplayHealth(amount,maxValue);
            FillAmountShouldBe(expected);
        }

        private void FillAmountShouldBe(float expected)
        {
            Assert.AreEqual(expected , _healthBarComponent.FillAmount);
        }

    #endregion
    }
}