using UniRx;
using UnityEngine;

namespace Core.Character
{
    public class Character
    {
        public  IntReactiveProperty CurrentHp;
        private int                 _maxValue;

        public Character(int initHp)
        {
            SetMax(initHp);
            CurrentHp = new IntReactiveProperty(initHp);
        }

        public int GetHp() => CurrentHp.Value;

        public void TakeDamage(int damage) => ClampHpMin0Max100(CurrentHp.Value - damage);

        public void Heal(int hp) => ClampHpMin0Max100(CurrentHp.Value + hp);

        void SetMax(int value) => _maxValue = value;

        private void ClampHpMin0Max100(int calculatedHp)
        {
            CurrentHp.Value = Mathf.Clamp(calculatedHp , 0 , _maxValue);
        }

        public void SetHp(int hp) => CurrentHp.Value = hp;
    }
}