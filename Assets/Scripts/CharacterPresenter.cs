using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPresenter : MonoBehaviour
{
    [SerializeField]
    private Image _imageHealthBar;

    [SerializeField]
    private Image _imageCircleHealthBar;

    [SerializeField]
    private Button _buttonHurt;

    [SerializeField]
    private Button _buttonHeal;


    private void Start()
    {
        var maxHp    = 100;
        var character = new Character(maxHp);
        character.CurrentHp
                 .Subscribe(_ =>
                 {
                     _imageHealthBar.fillAmount = (float)character.GetHp() / maxHp;
                     _imageCircleHealthBar.fillAmount = (float)character.GetHp() / maxHp;
                 });
        _buttonHurt.OnClickAsObservable()
                   .Subscribe(_ => character.TakeDamage(10));
        _buttonHeal.OnClickAsObservable()
                   .Subscribe(_ => character.Heal(10));
        
    }
}