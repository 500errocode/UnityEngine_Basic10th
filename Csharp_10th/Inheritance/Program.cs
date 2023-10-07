using System;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            //PlayerbleCharacter playerbleCharacter = new PlayerbleCharacter();
            PlayableCharacter swordMan = new SwordMan();
            swordMan.Move();


            // 공변성 
            // 하위타입 객체를 기반타입으로 창조할수있는 성질.
            // 객체가 할당될때, 기반타입의 데이터로부터 차례대로 할당을 하기 때문에 가능함.
            PlayableCharacter swordMan1 = new SwordMan();
            PlayableCharacter wizard1 = new Wizard();
            PlayableCharacter inermidiateWizard1 = new IntermidiateWizard();
            swordMan.Move();
            swordMan1.Move();
            wizard1.Move();
            inermidiateWizard1.Move();


            // object 타입
            // C#의 모든 타입의 기반타입

            // object 타입 변수의 어떤 데이터를 대입하면
            // heap 메모리영역에 object 타입 객체를 생성하고,
            // 데이터의 타입 참조테이블 인덱스의 데이터를 씀.
            object int1 = 3;
            object str = "Zㅣ존검사";
            object wizard = new Wizard();

            // Unboxing :
            // object 객체에서 원래 데이터를 읽어오는 과정
            int a = (int)int1;
        }
    }
}
