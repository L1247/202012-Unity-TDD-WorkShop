using UnityEngine;

public class Character
{
    private int _currentHp;

    public Character(int initHp)
    {
        _currentHp = initHp;
    }

    public int GetHp()
    {
        return _currentHp;
    }

    public void TakeDamage(int damage)
    {
        var calculatedHp = _currentHp - damage;
        _currentHp = Mathf.Clamp(calculatedHp , 0 , 100);
    }

    public void Heal(int hp)
    {
        _currentHp += hp;
    }

    public void SetHp(int hp)
    {
        _currentHp = hp;
    }
}