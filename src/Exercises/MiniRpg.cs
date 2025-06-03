namespace Exercises;
public class MiniRpg
{
    public class Character
    {
        private readonly string name;
        private int health;
        private readonly int attack;

        public Character(string name, int health, int attack)
        {
            // TODO
            throw new NotImplementedException();
        }
        public bool IsAlive() => health > 0;
        public void Attack(Character target)
        {
            // TODO
            throw new NotImplementedException();
        }
        public int GetHealth() => health;
        public string GetName() => name;
    }

    /// <summary>Conducts battle until one character is defeated. Returns the winner's name.</summary>
    public static string Battle(Character a, Character b)
    {
        // TODO
        throw new NotImplementedException();
    }
} 