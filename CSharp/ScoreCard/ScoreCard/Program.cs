namespace ScoreCard
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public int Language { get; set; }
        public int SST { get; set; }
    }

    class ScoreCard
    {
        int n = 0;
        Student[] students;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt16(Console.ReadLine());
            students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Details for Student {i + 1}");
                Console.WriteLine("Enter Roll No");
                int rollno = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks for Maths");
                int maths = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for Science");
                int science = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for English");
                int english = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for Language");
                int lang = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for SST");
                int sst = Convert.ToInt16(Console.ReadLine());
                students[i] = new Student() { RollNo = rollno, Name = name, Math = maths, Science = science, English = english, Language = lang, SST = sst };
            }
        }

        public void ShowDetails()
        {
            int sum = 0;
            int max = 0;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Roll No: {students[i].RollNo} Name: {students[i].Name}");
                Console.WriteLine($"Math: {students[i].Math}, Science: {students[i].Science}, English: {students[i].English}, Language: {students[i].Language}, SST: {students[i].SST}");
                sum = students[i].Math + students[i].Science + students[i].English + students[i].Language + students[i].SST;
                Console.WriteLine($"Total Score is {sum}");
                if (sum > max)
                {
                    max = sum;
                }
                Console.WriteLine($"Maximum Score is {max}");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreCard card = new ScoreCard();
            card.AcceptDetails();
            card.ShowDetails();
        }
    }
}