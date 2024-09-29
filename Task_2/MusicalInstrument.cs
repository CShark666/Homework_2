using System;

namespace Task_2
{
    internal class MusicalInstrument
    {
        private string _name;
        private string _description;
        private string _history;

        public MusicalInstrument(string name, string description, string history)
        {
            _name = name;
            _description = description;
            _history = history;
        }

        public void Sound()
        {
            Console.WriteLine($"*Makes a sound of {_name}*");
        }

        public void Show()
        {
            Console.WriteLine($"This is : {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description of {_name} : {_description}");
        }

        public void History()
        {
            Console.WriteLine($"History of {_name} : {_history}");
        }

    }

    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Violin", "Violin is a stringed musical instrument.", "It was created in the 16th century in Italy.")
        {
        }
    }
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone", "Trombone is a wind instrument.", "The first trombones were made in the fifteenth century.")
        {
        }
    }

    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele", "Ukulele is a small guitar from Hawaii" , "It appeared in the 1880s in Hawaii.")
        {
        }
    }

    internal class Cello : MusicalInstrument
    {
        public Cello() : base("Cello", "Cello is a stringed bowed instrument" , "Created in the 16th century in Italy.")
        {
        }
    }
}
