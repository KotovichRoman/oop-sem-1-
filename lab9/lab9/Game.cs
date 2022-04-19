using System.Runtime.Intrinsics.X86;

namespace lab9
{
    public class Game
    {   
        public delegate void HealthHandler(string message);
        public delegate int Health(int x);

        public event HealthHandler Notify;
        
        public string Name { get; private set; }
        public int HealthPoints { get; private set; }
        public Game(string name, int healthPoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
        }

        public void Attack(int healthPoints)
        {
            if (Name == "Monster")
            {
                Health health = (healthPoints) => HealthPoints - healthPoints;
                Notify?.Invoke($"Нанесено {healthPoints}урона\nХП: {health}");
            }
            else
            {
                Notify?.Invoke($"Нельзя атаковать\nХП: {HealthPoints}");
            }
        }

        public void Heal(int healthPoints)
        {
            if (Name != "Monster")
            {
                Health health = (healthPoints) => HealthPoints + healthPoints;
                Notify?.Invoke($"Восстановлено {healthPoints}ХП\nХП: {health}");
            }
            else
            {
                Notify?.Invoke($"Нельзя восстановить ХП\nХП: {HealthPoints}");
            }
        }
        
    }
    
}