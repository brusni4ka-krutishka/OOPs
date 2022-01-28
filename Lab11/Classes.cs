using System;

namespace Lab11
{
    class Abiturient //класс partial
    {
        private string name;
        private string lastname;
        private byte[] marks = new byte[4] { 1, 1, 1, 1 };
        public Abiturient( string lastname, string name, byte[] marks)
        {
            this.name = name;
            this.lastname = lastname;
            this.marks = marks;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public byte[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public float Average_score()
        {
            int score = 0;
            for (byte i = 0; i < marks.Length; i++)
            {
                score += marks[i];
            }
            return (score / marks.Length);
        }
        public byte Sum()
        {
            byte score = 0;
            for (byte i = 0; i < marks.Length; i++)
            {
                score += marks[i];
            }
            return score;
        }
        public byte Min()
        {
            Array.Sort(marks);
            return marks[0];
        }
        public byte Max()
        {
            Array.Sort(marks);
            return marks[^ 1];
        }
        public byte Math()
        {
            return marks[0];
        }
    }
    class Citizen
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}