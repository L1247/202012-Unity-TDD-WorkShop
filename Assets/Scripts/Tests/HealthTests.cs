#region

using Core.Character;
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
        TakeDamage(10);
        HpShouldBe(90);
    }

    [Test]
    public void Hp0WhenTakeDamage200()
    {
        TakeDamage(200);
        HpShouldBe(0);
    }

    [Test]
    public void Given_Hp90_When_Heal10_Then_Hp100()
    {
        SetHp(90);
        Heal(10);
        HpShouldBe(100);
    }

    [Test]
    public void Given_Hp90_When_Heal100_Then_Hp100()
    {
        SetHp(90);
        Heal(100);
        HpShouldBe(100);
    }

    private void TakeDamage(int damage) => _character.TakeDamage(damage);

    private void Heal(int hp) => _character.Heal(hp);

    private void SetHp(int hp) => _character.SetHp(hp);

    private void HpShouldBe(int expected) => Assert.AreEqual(expected , _character.GetHp());
}