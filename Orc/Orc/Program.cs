using System;

namespace Orc
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc Orc1 = new Orc();
            Orc1.name = "상급오크";
            Orc1.height = 240.4f;
            Orc1.weight = 200.0f;
            Orc1.age = 140;
            Orc1.gender = '남';
            Orc1.playing = false;
            Orc1.Jump();
            Orc Orc2 = new Orc();
            Orc2.name = "상급오크";
            Orc2.height = 140.4f;
            Orc2.weight = 120.0f;
            Orc2.age = 60;
            Orc2.gender = '남';
            Orc2.playing = true;
            Orc2.Smash();
        }
    }
    public class Orc
    {
        public string name; // = "상급오크";
        public float height; // = 240.2f;
        public float weight; // = 200.0f;
        public int age; // = 140;
        public char gender; // = '남';
        public bool playing; // = false;

        public void Smash()
        {
            Console.WriteLine("Orc use Smashing!");
        }
        public void Jump()
        {
            Console.WriteLine("Orc use Jumping!");
        }
    }
}
