#region

using NUnit.Framework;

#endregion

public class HealthTests
{
    private Character _character;

    [SetUp]
    public void SetUp()
    {
        _character = new Character(100);
    }

    [Test]
    public void Hp100WhenCharacterNew()
    {
        Assert.AreEqual(100 , _character.GetHp());
    }

    [Test]
    public void Hp90WhenTakeDamage10()
    {
        _character.TakeDamage(10);
        Assert.AreEqual(90 , _character.GetHp());
    }
}