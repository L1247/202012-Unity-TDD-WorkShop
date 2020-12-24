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
            var pnum = amount % 100;
            if (pnum == 0 && amount > 0)
                pnum = 100;
            else if(amount == 0 && pnum >0)
                pnum = 0;

            FillAmount        = (float)pnum / 100;
            _image.fillAmount = FillAmount;
            var percent = (float)amount / maxValue * 100;
            var count   = amount                   / 100;

            _tmpTextCount.text   = $"X {count}";
            _tmpTextPercent.text = $"{percent}%";
        }
    }
}