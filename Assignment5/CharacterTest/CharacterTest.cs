using Assignment5;
using NUnit.Framework;

namespace CharacterTest
{
    public class Tests
    {
        private Character character;

        [SetUp]
        public void Setup()
        {
            character = new Character("Me", RaceCategory.Human, 100);
        }

        [Test]
        public void TakeDamage()
        {
            character.Health = 50;
            character.TakeDamage(60);
            Assert.IsTrue(character.Health <= 0);
            Assert.IsFalse(character.IsAlive);
        }

        [Test]
        public void RestoreHealth()
        {
            character.Health = 50;
            character.RestoreHealth(10);
            Assert.AreEqual(character.Health, 60);

            character.RestoreHealth(50);
            Assert.AreEqual(character.Health, 100);

            character.Health = -5;
            character.IsAlive = false;
            character.RestoreHealth(50);
            Assert.IsTrue(character.IsAlive);
        }
    }
}