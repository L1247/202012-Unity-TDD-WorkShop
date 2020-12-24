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

        [SerializeField]
        private int _maxHp = 100;

        private void Start()
        {
            var character = new Character.Character(_maxHp);
            character.CurrentHp
                     .Subscribe(_ =>
                     {
                         _healthBarComponents
                             .ForEach(healthComp =>
                                          healthComp.DisplayHealth(character.GetHp() , _maxHp));
                     });
            buttonHurt.OnClickAsObservable()
                      .Subscribe(_ => character.TakeDamage(10));
            buttonHeal.OnClickAsObservable()
                      .Subscribe(_ => character.Heal(10));
        }
    }
}