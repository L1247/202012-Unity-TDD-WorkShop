using TMPro;
using UnityEngine;

namespace Core.UI.Elements
{
    public class HealthBarWithTextComponent : HealthBarComponent
    {
        [SerializeField]
        private TMP_Text _tmpText;

        public override void DisplayHealth(int amount , int maxValue)
        {
            base.DisplayHealth(amount , maxValue);
            _tmpText.text = $"{amount}/{maxValue}";
        }
    }
}