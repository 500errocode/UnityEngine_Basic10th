using System;

namespace EnumType
{
    // enum사용자 정의 자료형
    // 정수값에 대한 목록을 작성할 수 있음
    enum State
    {
        None,
        Idle,
        Move,
        Jump,
        Fall,
        Attack = 20
    }

    // 열거형으로 Bit Flags 를 정의하는 방법
    public enum LayerMask
    {
        Default = 0 << 0, // 0 // 00000000
        Ground  = 1 << 0, // 1 // 00000001
        Player  = 1 << 1, // 2 // 00000010
        Enemy   = 1 << 2, // 4 // 00000100

    }

    class Player
    {
        //const 상수 키워드
        //해당변수를 상수로서 사용하겠다고 명시하는 키워드
        //상수치급이므로 런타임중에 값을 대입할수 없다.
        public const int STATE_JUMP = 3;

        //1: Idle
        //2: Move
        //3: Jump
        //4: Fall
        public State state;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //player.state = 3;
            //player.state = Player.STATE_JUMP;
            player.state = State.Jump;

            //Enum 클래스 : 열거형 타입에 대한 편의 기능을 제공하는 클래스
            //Type 클래스 : 어떤 타입을 대표하는 정보를 가질수 있는 클래스
            Array array = Enum.GetValues(typeof(State));

            //in 뒤의있는거를 차례대로 순회하면서 현재 순회중인 아이템을 반환하는 구문 인거 같은..데?
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //switch case 구문
            /*
            switch (변수)
            {
                case 값1:
                case 값2:
                    {
                        변수가 값1 또는 값2 이때 실행할 내용
                    }
                default:
                    {
                        그외
                    }
                    break;
            }
            */
            switch (player.state)
            {
                case State.None:
                    break;
                case State.Idle:
                    {
                        //something to do when player is Idle 
                    }
                    break;
                case State.Move:
                    break;
                case State.Jump:
                case State.Fall:
                    {
                        //something to do when player is Jump | Fall
                    }
                    break;
                case State.Attack:
                    break;
                default:
                    break;
            }

            string names = string.Empty;
            switch (names)
            {
                case "철수":
                    break;
                case "영희":
                    break;
                default:
                    break;
            }

            int colliderLayer = 3;
            int colliderMask = 1 << 1 | 1 << 2;
            if ((1 << colliderLayer & colliderMask) > 0)
            {

            }

            LayerMask mask = LayerMask.Player | LayerMask.Enemy;
            if ((1 << colliderLayer & (uint)mask) > 0)
            {

            }
        }
    }
}