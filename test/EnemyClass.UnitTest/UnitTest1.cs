
using Player.Domain;

namespace EnemyClass.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Enemy_ShouldStartAtLevelOne()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);

            Assert.Equal(1, enemy1.Level);
        }

        [Fact]
        
        public void Enemy_ShouldStartWithZeroExperience()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Equal(0, enemy1.Experience);
        }

        [Fact]

        public void Enemy_ShouldStartWithFullHealth()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Equal(100, enemy1.Health);
        }

        [Fact]

        public void Enemy_ShouldHaveMaxHealthEqualToHealth()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Equal(enemy1.MaxHealth, enemy1.Health);
        }

        [Fact]

        public void Enemy_ShouldBeAliveAtStart()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.True(enemy1.IsAlive);
        }

        [Fact]

        public void Enemy_ShouldStartWithZeroGold()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Equal(0, enemy1.Gold);
        }

        [Fact]

        public void Enemy_ShouldLevelUpAfterGainingEnoughExperience()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.Addexperience(150);
            Assert.Equal(2, enemy1.Level);
            Assert.Equal(50, enemy1.Experience);
        }

        [Fact]

        public void Enemy_ShouldTakeDamageAndDie()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.TakeDamage(150);
            Assert.Equal(0, enemy1.Health);
            Assert.False(enemy1.IsAlive);
        }

        [Fact]

        public void Enemy_ShouldHealAndNotExceedMaxHealth()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.TakeDamage(50);
            enemy1.Heal(30);
            Assert.Equal(80, enemy1.Health);
            enemy1.Heal(50);
            Assert.Equal(100, enemy1.Health); // Should not exceed MaxHealth
        }

        [Fact]

        public void Enemy_ShouldAddGold()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.AddGold(50);
            Assert.Equal(50, enemy1.Gold);
        }

        [Fact]

        public void Enemy_ShouldResetHealth()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.TakeDamage(50);
            enemy1.resetHealth();
            Assert.Equal(100, enemy1.Health);
            Assert.True(enemy1.IsAlive);
        }

        [Fact]

        public void Enemy_ShouldResetExperience()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.Addexperience(150);
            enemy1.ResetExperience();
            Assert.Equal(0, enemy1.Experience);
        }

        [Fact]

        public void Enemy_ShouldThrowExceptionForNegativeDamage()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => enemy1.TakeDamage(-10));
        }

        [Fact]

        public void Enemy_ShouldThrowExceptionForNegativeHeal()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => enemy1.Heal(-10));
        }

        [Fact]

        public void Enemy_ShouldThrowExceptionForNegativeGold()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => enemy1.AddGold(-10));
        }

        [Fact]

        public void Enemy_ShouldLevelUpMultipleTimes()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.Addexperience(250);
            Assert.Equal(3, enemy1.Level);
            Assert.Equal(50, enemy1.Experience);
        }

        [Fact]

        public void Enemy_ShouldNotExceedMaxHealthWhenHealing()
        {
            Enemy enemy1 = new Enemy("Goblin", 1, 0, 100, 100, true, 0);
            enemy1.Heal(50); // Healing when at full health
            Assert.Equal(100, enemy1.Health); // Should still be at MaxHealth
        }
    }
}
