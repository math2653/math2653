using System;

namespace unitylesson3
{
    class Program
    {
        static void Main(string[] args)
        {
			Person person1 = new Person();
			//.점 연산자
			//클래스의 멤베에 접근할 때 사용 namespace 안에 클래스에 접근할 때도 사용
			//객체의 멤버에 접근할때도 사용
			person1.name = "김아무개";
			person1.age = 13;
			person1.height = 152.41f;
			person1.isFemale = false;
			person1.genderChar ='남';

			Person person2 = new Person();
			person2.name = "이아무개";
			person2.age = 11;
			person2.height = 148.74f;
			person2.isFemale = true;
			person2.genderChar = '여';

			person1.SayAge();
			person2.SayAge();

		}
		
	}
	public class Person
	{
		//public, private, protected
		//public : 다른 클래스가 접근할 수 있다.
		//private : 다른 클래스가 접근 할 수 없다.
		//protected : 상속자만 접근할 수 있다.
		public int age; //나이
		public float height; //키
		public bool isFemale; //여자인지
		public char genderChar; //성별 문자
		public string name; //이름

		public void SayAllInfo()
		{
			SayAge();
			SayHeight();
			SayFemale();
			Saygender();
		}

		public void SayAge()
		{
			Console.WriteLine($"나이 : {age}");
		}
		public void SayHeight()
		{
			Console.WriteLine($"키 : {height}");
		}
		public void SayFemale()
		{
			Console.WriteLine($"여자인가? : {isFemale}");
		}
		public void Saygender()
		{
			Console.WriteLine($"성별 : {genderChar}");
		}
		
	}
}
