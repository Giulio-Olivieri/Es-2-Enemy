using EnemyProject.Domain;
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
    }
}
