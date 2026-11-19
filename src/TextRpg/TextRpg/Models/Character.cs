

namespace TextRpg.Models
{
    public class Character
    {
        public Health Health { get; private set; }

        public Character(int maxHealth)
        {
            Health = new Health(maxHealth);
        }
    }
}
