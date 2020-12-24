using TMPro;
using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarPercent : HealthBarComponent
    {
        [SerializeField]
        private TMP_Text _tmpTextPercent;

        public override void DisplayHealth(int amount , int maxValue)
        {
            base.DisplayHealth(amount , maxValue);
            var percent = (float)amount / maxValue * 100;
            _tmpTextPercent.text = $"{percent}%";
        }
    }
}