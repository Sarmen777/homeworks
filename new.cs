using System;

namespace Translation
{
    abstract class Translator
    {
        protected readonly string[] Words = { "Apple" , "Banana" , "Orange" , "Mango"};
        public abstract string Translate(string word);
    }
    class Russian : Translator
    {
        private readonly string[] Translations = {"Яблоко" , "Банан" , "Апельсин" , "Манго"};

        public override string Translate(string word)
        {
            for (int i = 0 ; i < Translations.Length ; i++)
            {
                if (Words[i] == word) return Translations[i];
            }
            return "Not found";
        }
    }
    class Spanish : Translator
    {
        private static readonly string[] Translations = { "Manzana", "Platano", "Naranja" , "Mango" };

        public override string Translate(string word)
        {
            for (int i = 0 ; i < Translations.Length ; i++)
            {
                if (Words[i] == word) return Translations[i];
            }
            return "La palabra no se encuentra";
        }
    }
    class French : Translator
    {
         private static readonly string[] Translations = { "Pomme", "Banane", "Orange", "Mangue" };

        public override string Translate(string word)
        {
            for (int i = 0 ; i < Translations.Length ; i++)
            {
                if (Words[i] == word) return Translations[i];
            }
            return "Traduction non trouvee";   
        }
    }
}

/**************************************************************/

abstract class Shape
{
    abstract public int GetSurface();
    abstract public void Draw();

    public void Print()
    {
        Console.WriteLine($"{GetType().Name} , Surface = {GetSurface()}");
        Draw();
    }
}
class Square : Shape
{
    private int Side;
    public Square(int Side)
    {
        this.Side = Side;
    }
    public override int GetSurface() => Side * Side;

    public override void Draw()
    {
        for (int i = 0 ; i < Side ; i++)
        {
            for (int j = 0 ; j < Side ; j++)
            {
                Console.Write("+ ");
            }
            Console.WriteLine();
        }
    }
   
}
class Rectangle : Shape
{
    private int Length;

    private int Width;

    public Rectangle(int Length, int Width)
    {
        this.Length = Length;
        this.Width = Width;
    }
    public override int GetSurface() => Length * Width;

    public override void Draw()
    {
        for (int i = 0 ; i < Width ; i++)
        {
            for (int j = 0 ; j < Length ; j++)
            {
                Console.Write("+ ");
            }
            Console.WriteLine();
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle(3,2);
        Square s = new Square(3);
        r.Print();

    }
}