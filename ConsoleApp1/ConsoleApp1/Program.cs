using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		//Camel Case (이름 설정 규칙중 하나)
		//class,function namespace 등은 대문자로 설정한다.
		//변수는 소문자로 시작한다.
		//단어가 바꿜때는 첫 문자는 대문자로 한다.
		//줄임말은 되도록 사용하지 않는다.
		//이름을 보았을때, 어떤 기능, 목적인지 알 수 있도록 작성한다.
		//애매한 부분이 있으면 주석을 달아준다.

			
	}
	class Person
	{
		int age; //나이
		float height; //키
		bool isFemale; //여자인지
		char genderChar;
		string name;

		void SatAllInfo()
		{
			SayAge();
			SayHeight();
			SayFemale();
			Saygender();
		}

		void SayAge()
		{
			Console.WriteLine($"나이 : {age}");
		}
		void SayHeight()
		{
			Console.WriteLine($"키 : {height}");
		}
		void SayFemale()
		{
			Console.WriteLine($"여자인가? : {isFemale}");
		}
		void Saygender()
		{
			Console.WriteLine($"성별 : {genderChar}");
		}
		void SatAge()
		{
			Console.WriteLine($"이름 : {name}");
		}
	}
}
