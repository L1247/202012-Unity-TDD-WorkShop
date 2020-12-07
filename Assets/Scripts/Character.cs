using UnityEngine;

public class Character
{
    private int _currentHp;

    // todo : use _currentHp = 100;
    public Character(int initHp)
    {
        _currentHp = initHp;
    }

    public int GetHp()
    {
        return _currentHp;
    }

    // todo : inline variable
    public void TakeDamage(int damage)
    {
        var calculatedHp = _currentHp - damage;
        ClampHpMin0Max100(calculatedHp);
    }

    public void Heal(int hp)
    {
        var calculatedHp = _currentHp + hp;
        ClampHpMin0Max100(calculatedHp);
    }

    private void ClampHpMin0Max100(int calculatedHp) => _currentHp = Mathf.Clamp(calculatedHp , 0 , 100);

    public void SetHp(int hp) => _currentHp = hp;
}