using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Presenters
{
    public class CharacterPresenter : MonoBehaviour
    {
        [SerializeField]
        private Image imageHealthBar;

        [SerializeField]
        private Image imageCircleHealthBar;

        [SerializeField]
        private Button buttonHurt;

        [SerializeField]
        private Button buttonHeal;


        private void Start()
        {
            var maxHp     = 100;
            var character = new Character.Character(maxHp);
            character.CurrentHp
                     .Subscribe(_ =>
                     {
                         imageHealthBar.fillAmount       = (float)character.GetHp() / maxHp;
                         imageCircleHealthBar.fillAmount = (float)character.GetHp() / maxHp;
                     });
            buttonHurt.OnClickAsObservable()
                      .Subscribe(_ => character.TakeDamage(10));
            buttonHeal.OnClickAsObservable()
                      .Subscribe(_ => character.Heal(10));
        
        }
    }
}