using TMPro;
using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarPercent : HealthBarComponent
    {
        [SerializeField]
        private TMP_Text _tmpTextPercent;

        [SerializeField]
        private TMP_Text _tmpTextCount;


        public override void DisplayHealth(int amount , int maxValue)
        {
            base.DisplayHealth(amount , maxValue);
            var percent = (float)amount / maxValue * 100;
            var count   = amount                   / 100;
            _tmpTextCount.text   = $"X {count}";
            _tmpTextPercent.text = $"{percent}%";
        }
    }
}