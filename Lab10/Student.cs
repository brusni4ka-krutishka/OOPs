namespace Lab10
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public byte AverageScore { get; set; }

        public Student(string name, string last_name, byte age, byte average_score) 
            => (Name, LastName, Age, AverageScore) = (name, last_name, age, average_score);

        public override string ToString()=> $"{Name} {LastName} ({Age} лет, средний балл: {AverageScore})";

    }
}
