using System.Collections.Generic;
using Core.UI.Elements;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Presenters
{
    public class CharacterPresenter : MonoBehaviour
    {
        [SerializeField]
        private Button buttonHurt;

        [SerializeField]
        private Button buttonHeal;

        [SerializeReference]
        private List<HealthBarComponent> _healthBarComponents = new List<HealthBarComponent>();

        private void Start()
        {
            var maxHp     = 100;
            var character = new Character.Character(maxHp);
            character.CurrentHp
                     .Subscribe(_ =>
                     {
                         _healthBarComponents
                             .ForEach(healthComp =>
                                          healthComp.DisplayHealth(character.GetHp() , maxHp));
                     });
            buttonHurt.OnClickAsObservable()
                      .Subscribe(_ => character.TakeDamage(10));
            buttonHeal.OnClickAsObservable()
                      .Subscribe(_ => character.Heal(10));
        }
    }
}