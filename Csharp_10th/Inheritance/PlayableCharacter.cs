using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class PlayableCharacter : IHp, IAttack
    {
        public float hpValue
        {
            get
            {
                return _hp;
            }
            private set
            {
                if (value == _hp)
                    return;

                if (value > hpMax)
                    value = hpMax;
                else if (value < hpMin)
                    value = hpMin;

                _hp = value;
            }
        }

        public float hpMax
        {
            get
            {
                return hpMax;
            }
        }

        public float hpMin
        {
            get
            {
                return hpMin;
            }
        }

        public float attackPower
        {
            get
            {
                return attackPower;
            }
        }

        public float criticalRatio
        {
            get
            {
                return criticalRatio;
            }
        }

        public float criticalGain
        {
            get
            {
                return criticalGain;
            }
        }

        private float _hp;
        private float _hpMax;
        private float _attackPower;
        private float _criticalGain;

        public virtual void Breath()
        {

        }

        public abstract void Move();

        public void Attack(IHp target, bool isCritical)
        {
                target.DepleteHp(this, isCritical ? _attackPower * _criticalGain : _attackPower);

            if (target is PlayableCharacter)
            {
                ((PlayableCharacter)target).DepleteHp<PlayableCharacter>(this, isCritical ? _attackPower * _criticalGain :
                    _attackPower);
            }
        }

        //generic 타입
        public void DepleteHp<T>(T subject, float amount)
        {
            hpValue -= amount;
        }
        
        public void DepleteHp(object subject, float amount)
        {
            hpValue -= amount;
        }
        
        public void RecoverHp(object subject, float amount)
        {
            hpValue += amount;
        }

        public static implicit operator PlayableCharacter(IntermidiateWizard v)
        {
            throw new NotImplementedException();
        }
    }
}
