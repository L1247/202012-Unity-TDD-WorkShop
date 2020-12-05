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
        HpShouldBe(100);
    }

    [Test]
    public void Hp90WhenTakeDamage10()
    {
        _character.TakeDamage(10);
        HpShouldBe(90);
    }

    [Test]
    public void Hp0WhenTakeDamage200()
    {
        _character.TakeDamage(200);
        HpShouldBe(0);
    }

    [Test]
    public void Given_Hp90_When_Heal10_Then_Hp100()
    {
        _character.SetHp(90);
        _character.Heal(10);
        HpShouldBe(100);
    }

    private void HpShouldBe(int expected)
    {
        Assert.AreEqual(expected , _character.GetHp());
    }
}