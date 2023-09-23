using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal interface IHp
    {
        float hpValue { get; }
        float hpMax { get; }
        float hpMin { get; }

        void RecoverHp(object subject, float amount);
        void DepleteHp(object subject, float amount);
    }
}
