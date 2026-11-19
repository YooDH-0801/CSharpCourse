using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg.Models
{
    public class Health
    {
        private int _maxHealth;
        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        private int _curHealth;
        public int CurHealth 
        {
            get => _curHealth;
            set 
            {
                if (value < 0)
                    _curHealth = 0;
                else if (value > MaxHealth)
                    _curHealth = MaxHealth;
                else
                    _curHealth = value;
            }
        }

        public Health(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurHealth = maxHealth;
        }
    }
}
