using System;

namespace static11
{
    class Program
{
    static void Main(string[] args)
    {
		Person person3 = new Person();
		person3.name = " 김아무개";
		Person person4 = new Person();
		person4.name = " 김아무개";
		Person.typeName = "사람 타입";
		orc.typeName = "오크 타입";
			Person.SayTypeName();
		
	}
}
static class orc
		//static으로 정의된 클래스는 객체생성 불가, 인스턴스화 불가.
    {
		static public string typeName;
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

	static public string typeName;

		static public void SayTypeName()
        {
			Console.WriteLine($"타입 : {typeName}");

		}

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