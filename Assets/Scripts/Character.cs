using UnityEngine;

public class Character
{
    private int _currentHp;

    public Character(int initHp) => _currentHp = initHp;

    public int GetHp() => _currentHp;

    public void TakeDamage(int damage) => ClampHpMin0Max100(_currentHp - damage);

    public void Heal(int hp) => ClampHpMin0Max100(_currentHp + hp);

    private void ClampHpMin0Max100(int calculatedHp)
    {
        _currentHp = Mathf.Clamp(calculatedHp , 0 , 100);
    }

    public void SetHp(int hp) => _currentHp = hp;
}