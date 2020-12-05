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
        _currentHp -= damage;
    }
}