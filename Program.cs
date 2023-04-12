using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        // 열거 형식 WEEKEND
        // 자동으로 숫자를 부여해주고 상수로 선언된다.

        // 열거형 내부 요소 또한 값을 가진다. 디폴트 값은 0으로 요소마다 1씩 증가한다.
        // 값은 임의로 지정이 가능하며, 별다른 지정이 없으면 요소마다 이전 요소보다 1만큼 증가된 값을 가진다.

        // 열거형을 참조하는 변수명의 값을 변경하면 요소와 같은 값을 가진 요소 이름으로 대체된다. ex) week = 101 = MON
        // 요소가 아닌 숫자의 값을 가진 변수는 숫자로 표기된다. ex) week = WEEKEND.MON++ = 102;

        enum WEEKEND
        {
            SUN = 100,
            MON,    // 101
            TUE = 1000,
            WEN, // 1001
            THU,
            FRI,
            SAT,
        }

        // string에 대한 주석
        // c++과 다르게 c#에서의 string은 배열의 크기를 지정해줄 필요가 없다. 문자열의 크기에 따라 자동으로 배열의 크기가 조정된다. 조정되는 형식 2를 곱하는 식으로 최대 2^31까지.
        // 또 C#에서의 모든 요소는 class형식을 띄고 있다.

        static void Main(string[] args)
        {
            #region //복습
            // 변수 : 특정 메모리에 데이터를 저장하는 공간
            // 자료형 (데이터 형식) 식별자 (변수명)
            // 변수를 선언하다
            int x;
            x = 100;

            // 변수를 선언함과 동시에 초기화 한다.
            int y = 0;
            #endregion

            #region // 값 (Value) 형식 / 참조(Reference) 형식
            // 1. 메모리 공간은 크게 스택과 힙으로 나뉜다.
            // 2. 데이터의 형식 또한 이를 따라 '기본 데이터 형식'과 '복합 데이터 형식'이 주어진다.

            // 값 타입 (스택 메모리)
            // = 차례대로 스택 메모리에 쌓였다가 코드 블록이 끝나면 스택에서 사라진다. (= 휘발성)

            // 참조 타입 (힙 메모리)
            // = 데이터를 스스로 제거하지 않는다. CLR의 가비지 컬렉터(GC)라는 시스템이 필요없다고 판단되면 수거한다.
            // 코드 블록이 끝나는 시점과 상관 없이 데이터를 유지하고 싶을 때 사용할 수 있다.
            object aa = 10;
            #endregion

            #region// 기본 데이터 형식 (대부분이 값 타입)
            // = C#에서 제공하는 기본 데이터 형식은 15종류이다.

            // 숫자 데이터 형식(Numeric Type)
            // 정수 계열
            byte a1 = 0; // 부호 없는 정수 (0~255)
            sbyte a2 = 0; // 부호 있는 정수 (-128~127)
            short a3 = 0; // 2byte 정수
            ushort a4 = 0; // 부호 없는 2byte 정수
            int a5 = 0; // 4byte 정수
            uint a6 = 0; // 부호 없는 4byte 정수
            long a7 = 0; // 8byte 정수
            ulong a8 = 0; // 부호 없는 8byte 정수 (0 ~ 18,446,744,073,709,551,615 = 2^64)

            // 부동 소수점 형식 (Floating Point Type)
            float b1 = 0.0f; // 4byte이며 소수점 7자리까지 다룰 수 있다.
            double b2 = 0.0; // 8byte이며 소수점 15~16자리까지 다룰 수 있다.
            decimal b3 = 0.0m; // 16byte이며 소수점 29자리까지 다룰 수 있다.

            // 문자, 문자열 형식
            char c1 = 'a'; // 1byte이며 한 글자를 대입할 수 있다.
            string c2 = "abcd"; // 문자 여러개를 대입할 수 있다.

            // 논리 형식
            bool isTrue = false; // 1byte이며 참과 거짓을 대입할 수 있다.


            // 오브젝트 형식 (참조 타입)
            // = 모든 자료형의 조상(= 상속하고 있다)이다. c#의 모든 데이터를 담을 수 있다.
            object abc = 10;
            abc = 10.4f;
            abc = 'a';
            abc = "abcd";
            abc = false;
            

            // 박싱 (boxing), 언박싱(un-boxing)
            // = object형식은 모든 데이터를 담기위해 박싱이라는 기능을 제공한다.
            //  데이터를 박싱한 후 힙 메모리에 올린 뒤 해당 메모리의 주소를 자신이 가지고 있다.
            object abc1 = 100;
            // int abc2 = abc1; 모든 자료형을 수용해도 다른 자료형태에 대입은 불가능하다.
            #endregion

            #region // 자료형 변환

            int abc2 = (int)abc1; // 데이터 자료형 변환으로 대입을 시킬수 있다.

            // 데이터 자료형이 다른 값을 대입할 경우에는 형변환이 필요하다.
            byte d1 = 100;
            int d2 = (byte)d1;

            int d3 = 9999;
            byte d4 = (byte)d3; // 오버플로우 한 값을 제외한 15로 출력된다.
            #endregion

            #region// 문자형식
            // => 문자 또한 숫자로 저장되어있다. 다만 화면에 그려질 때 '아스키코드'표에 의거해 문자로 표현한다.
            char word = (char)65; // A의 아스키 코드 번호
            Console.WriteLine(word); // char형 변수는 값을 '숫자'로 들고있지만 표현 할 때에는 문자로 표현하는 자료형이다.

            char word2 = 'A';
            Console.WriteLine((int)word2); // 문자형을 숫자로 형변환했기 때문에 숫자로 표현된다.
            Console.WriteLine();

            // 문자열을 숫자로, 숫자를 문자열로
            string str = "1234";
            // int num1 = (int)str; 문자열은 기본 데이터형과 다르게 복합적으로 이루어져있다.
            
            int num1 = int.Parse(str); // 문자열을 숫자형 바꾸는 기능
            
            int num2 = 3456;
            string str2 = num2.ToString(); // num2의 값을 문자열로 바꾸는 기능 3456 -> "3456"
            


            // Q 정수, 실수형 데이터를 하나씩 선언한 뒤 문자형으로 바꿔 출력해보자.
            // Q 이후 다시 문자형을 정수, 실수형으로 바꿔 출력해보자

            int number1 = 56;
            float number2 = 2.5f;
            string text1;
            string text2;
            
            text1 = number1.ToString();
            text2 = number2.ToString();

            Console.WriteLine(text1);
            Console.WriteLine(text2);

            number1 = 0;
            number2 = 0;

            number1 = int.Parse(text1);
            number2 = float.Parse(text2);

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            
            number1 = (int)number2;
            Console.WriteLine("실수의 값을 대입한 정수는 " + number1); // int는 정수만 표현 가능하기 때문에 소수점 이하의 숫자는 버려진다.

            Console.WriteLine();
            #endregion

            #region// 상수 + 열거형식
            // = 변하지 않는 수. 선언한 값 외의 대입이 불가능하다. 때문에 최초 선언 단계에서 반드시 값을 넣어 초기화 해야한다.
            const int score = 100;
            // score = 200; 상수이기 때문에 값의 변환이 불가능하다.

            const int MIN_BYTE = 0;
            const int MAX_BYTE = 255;

            Console.WriteLine($"바이트의 최소 값은 : {MIN_BYTE}, 최대 값은 : {MAX_BYTE}");

            Console.WriteLine();

            // 열거 형식 (Main 밖에 위치)
            // = 상수의 나열이다.

            // 요일 (0:일 ~ 6:토)
            const int WEEK_SUN = 0;
            const int WEEL_MON = 1; // 원시적인 방법



            int month = 4;
            int day = 12;
            WEEKEND week = WEEKEND.MON;

            week++;

            Console.WriteLine($"요일 : {week}, 숫자로 : {(int)week}");
            
            Console.WriteLine($"오늘의 날짜는 {month}월 {day}일 {week}");
            #endregion

            // 위의 형식 모두 기본 자료형이며 자료형은 인위적으로 만들어낼수 있다.


            // 복합 데이터 형식 (대부분이 참조 타입)

        }
    }
}