﻿using System;
namespace FirstProject
{
    class 철수
    {
        uint 나이;
        int 돈;
    }

    //영희 객체 할당할 때 필요한 메모리 : 4 byte
    class 영희
    {
        float 키;
        //전역변수: 어디서나 접근 가능한 변수
        //클래스의 멤버변수도 전역변수임
        public int 나이 = 1;//변수 선언부분에 어떤값을 대입하겠다는 대입연산을 쓰면
                   // 해당값을 초기데이터로 쓰겠다는 명시(Data 영역에 할당)

        // 정적: 동적의 반대의미. 동적으로 할당할 수 없다. 런타임중에 메모리에 추가적인 할당이 불가능하다.
        static char 성별 = '여';

        //접근제한자 (Access Modifier)
        //외부에서의 멤버접근 가능여부를 제한하는 키워드
        //private - 이 클래스말고 다른 클래스는 해당 멤버에 접근 할 수 없다.
        //protected - 이 클래스를 상속받은 자식클래스만 해당 멤버에 접근할 수 있다.
        //internal - Assembly(코드조각 exe, dll 등) 단위로만 해당 멤버에 접근할 수 있다.
        //public - 

        //클래스는 캡슐화를 컨셉으로한 사용자정의자료형

        //클래스 생성자
        //힙메모리 영역에다가 클래스타입의 객체를 할당
        //멤버 변수의 초기화를 진행
        //생성된 객체의 주소를 반환.
        public 영희()
        {
        }

        //클래스 소멸자
        //해당 객체가 할당되 메모리 영역을 시스템에 반환하는 함수
        //가비지컬렉터가 알아서 소멸시키기때문에 직접 호출할일 없음
        ~영희()
        {
        }

        //void : 타입 정해지지않음 (반환타입x)

        void SayMyAge()
        {
            //todo -> 이름 출력
        }

        //지역변수 : { } 내에서 정의되어 해당 연산 중에만 메모리에 할당되는 변수
        //파라미터도 지역변수의 일종

        //인스턴스 멤버 함수는 데이터를 참조할 목표 객체에대한 참조 파라미터가 생략되어있음
        public bool 나이먹기(int 먹을나이)
        {
            int 예상나이 = 나이 + 먹을나이;
            //if구문 :
            //if(논리형 실행조건)
            /*
            {
                실행조건 참일때 실행
            }
            else
            {
                실행조건 거짓일때 실행
            }
             */

            //만약예상나이가 음수면 나이 못먹음
            if(예상나이 < 0)
            {
                return false;
            }
            else
            {
                나이 = 예상나이;
                return true;
            }

        }
        int x;
        uint z;
        float y;
        long o;
        ulong l;
        short h;
        ushort p;
        char g;
        double i;
        bool j;

        static void Main(string[] args)
        {
            //문자열형 string은 클래스타입이기때문에,
            //힙 영역에 객체를 만들고 해당 참조를 사용한다.
            //힙 영역에 할당하는 객체의 크기는 문자갯수x2byte + 1byte(null byte)
            //null byte가 붙는 이유는 문자열의 끝을 명시하기 위함.
            string string1 = "Something blabla"; //문자열 상수 표기는"" 로

            //멤버접근연산자
            Console.WriteLine("Hello, World!");

            //값 타입 vs 참조 타입
            //값 타입 : 데이터를 직접 메모리에 쓰고 읽는 타입
            //참조 타입 : 특정 메모리 주소를 통해 간접적으로 해당 메모리에 데이터를 쓰고 읽는 타입
            //포인터 타입 : 메모리 주소를 쓰고 읽는 타입으로 (C# 에서는 unsafe 코드작성 외에 쓰지않음)
            int a;
            //new : 동적할당 키워드 (메모리를 동적으로 할당하겠다고 명시하는 키워드)
            //객체주소 참조 변수
            영희 영희1 = new 영희();// 영희객체 만들고 영희가있는 주소를 영희1 이라는 변수에 저장
            영희 영희2 = new 영희();
            Console.WriteLine(영희1.나이먹기(1));
            Console.WriteLine(영희1.나이);
            Console.WriteLine(영희2.나이);

            string somethingToPrint = "영희의 나이는 " + 영희1.나이.ToString() + "살 입니다";
            Console.WriteLine(somethingToPrint);
            Console.WriteLine($"영희의 나이는 {영희1.나이}살 입니다");

            int int1 = 1;
            long long1 = int1; //암시적 캐스팅
            //변수의 Promotion(승격)
            //크기가 더 큰 자료형 레지스터로 작은 데이터를 읽었을때
            //읽는 과정에서 해당 데이터의 자료형이 바뀌는 효과

            long long2 = 2;
            int int2 = (int)long2; //명시적 캐스팅(형변환) 
        }
    }
}