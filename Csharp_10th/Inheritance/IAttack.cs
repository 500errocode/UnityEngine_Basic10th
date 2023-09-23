using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal interface IAttack
    {
        float attackPower { get; }
        float criticalRatio { get; }
        float criticalGain { get; }

        void Attack(IHp target, bool isCritical);
    }
}
