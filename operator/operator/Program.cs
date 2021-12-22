using System;

namespace lesson_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c;
            
            //산술연산 : 덧셈,뻴셈,곱셈,나눗셈,나머지 계산
            //=====================================================
            
            //덧셈
            c = a + b;
            c = FunctionsForoperator.Sum(a, b);
            Console.WriteLine(c);
            //뺄셈
            c = a - b;
            Console.WriteLine(c);
            //곱셈
            c = a * b;
            Console.WriteLine(c);
            //나눗셈
            c = a / b; //정수와 정수간의 연산 결과가 버림되어서 나온다
            Console.WriteLine(c);
            //나머지셈
            c = a % b;
            Console.WriteLine(c);
            
            //증감 연산
            //증가 연산자, 감소 연산자
            //====================================================
            
            //증가 연산자 : 1을 증가시킴
            c++;
            
            //감소 연산자 : 1을 감소시킴
            c--;
            
            //관계 연산
            //결과값은 논리현 (참, 거짓)
            //=====================================================
            
            //같음 비교
            bool d;
            d = a == b;
            //다름 비교
            Console.WriteLine(a != b);
            //큼 비교
            Console.WriteLine(a > b);
            //작음 비교
            Console.WriteLine(a < b);
            //작거나 같음 비교
            Console.WriteLine(a <= b);

            //대입 연산
            //오른쪽 변수의 값을 왼쪽 변수에 (그냥, 더해서, 빼서, 나누어서, 곱해서, 나머지를 구해서) 대입
            //일반적인 그냥 대입연산
            c = a;
            //더해서 대입
            c += a;
            Console.WriteLine(c);
            //빼서 대입
            c -= a;
            Console.WriteLine(c);
            //나누어서 대입
            c /= a;
            Console.WriteLine(c);
            //곱해서 대입
            c *= a;
            Console.WriteLine(c);
            //===================================================
            bool A = true;
            bool B = false;
            //OR

            //A와 B 둘중에 하나라도 true이면 true 반환, 나머지는 false 반환
            Console.WriteLine(A | B);
            //AND
            //A와 B 둘다 true이면 true 반환, 나머지는 false 반환
            Console.WriteLine(A & B);
            //A의 값을 반전. true이면 flase로, false면 true로
            Console.WriteLine(!A);
            //A와 B 둘중에 하나만 true이면 true 반환, 나머지는 false 반환
            Console.WriteLine(A ^ B);
            //조건부 논리연산
            //연산의 필요성에 대하여 판단을 한 후 연산이 필요 없으면 첫번째 결과를 반환한다.
            //연산이 필요하면 연산후의 결과를 반환함
            //조건부 OR 연산
            Console.WriteLine(A || B);
            //조건부 AND 연산
            Console.WriteLine(A && B);

            //EX)
            //if문 쓸때
            //if문의 조건을 계산할 때 시간이 걸림
            //if 문이 수백개다 -> 연산하는데 시간이 많이 걸려서 렉이 걸림

            //비트 연산
            //비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위해서
            //OR
            Console.WriteLine(a | b);
            //AND
            Console.WriteLine(a & b);
            //XOR
            Console.WriteLine(a ^ b);
            //NOT
            Console.WriteLine(~a);

            a = 14;
            int howManyBitsYouWantToShift = 3;
            //shift - left
            Console.WriteLine(a << howManyBitsYouWantToShift);
            //shift - right
            Console.WriteLine(a >> howManyBitsYouWantToShift);

            //FSM (Finits State Machine) 유한 상태 머신
            //클래스의 상태에 따라 다른 동작이나 조건을 특정해주기 위해서 사용함
            //EX)
            //그래서 사용자가 귀환을 눌렀는데 저런 특성상태 (피격중 \, 공격중 등등...)
            //귀환이 불가하도록 코딩한다
        }
    }

    public enum e_FSM
    {
        아무것도안하는상태 = 0,
        피격당한상태 = 1 << 0,
        공격중인상태 = 1 << 1,
        점프중인상태 = 1 << 2,
        달리기중인상태 = 1 << 3
    }
}
