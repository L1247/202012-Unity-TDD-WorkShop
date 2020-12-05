#region

using NUnit.Framework;

#endregion

public class HealthTests
{
    private Character _character;

    [SetUp]
    public void SetUp()
    {
        _character = new Character();
    }

    [Test]
    public void Hp100WhenCharacterNew()
    {
        Assert.AreEqual(100 , _character.GetHp());
    }
}