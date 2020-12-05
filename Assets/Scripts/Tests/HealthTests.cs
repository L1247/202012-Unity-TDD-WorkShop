using NUnit.Framework;

public class HealthTests
{
    [Test]
    public void Hp100WhenCharacterNew()
    {
        var character = new Character();
        Assert.AreEqual( 100, character.GetHp());
    }
}