using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    internal class Wizard : PlayableCharacter
    {
        // override : 재정의 키워드
        // 기반타입의 멤버를 제정의 할때 사용하는 키워드
        public override void Move()
        {
            Console.WriteLine("Move");
        }
        public void Fireball()
        {
            Console.WriteLine("Fireball");
        }
    }
}
