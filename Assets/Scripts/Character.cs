using UniRx;
using UnityEngine;

public class Character
{
    private IntReactiveProperty CurrentHp;

    public Character(int initHp)
    {
        CurrentHp = new IntReactiveProperty(initHp);
    }

    public int GetHp() => CurrentHp.Value;

    public void TakeDamage(int damage) => ClampHpMin0Max100(CurrentHp.Value - damage);

    public void Heal(int hp) => ClampHpMin0Max100(CurrentHp.Value + hp);

    private void ClampHpMin0Max100(int calculatedHp)
    {
        CurrentHp.Value = Mathf.Clamp(calculatedHp , 0 , 100);
    }

    public void SetHp(int hp) => CurrentHp.Value = hp;
}