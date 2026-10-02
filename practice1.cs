class Student
{
    public string Name;
    public int GroupNumber;
    public int[] Grades;

    public double GetAverage()
    {
        double sum = 0;
        for (int i = 0; i < Grades.Length; i++) sum += Grades[i];
        return sum / Grades.Length;
    }

    public int HasOnlyGoodGrades()
    {
        for (int i = 0; i < Grades.Length; i++)
        {
            if (Grades[i] != 4 && Grades[i] != 5) return 0;
        }
        return 1;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];

        students[0] = new Student { Name = "Алихан А.А.", GroupNumber = 101, Grades = new int[] { 4, 5, 4, 5, 5 } };
        students[1] = new Student { Name = "Арман А.Б.", GroupNumber = 101, Grades = new int[] { 3, 4, 5, 3, 4 } };
        students[2] = new Student { Name = "Нурлан Н.С.", GroupNumber = 102, Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[3] = new Student { Name = "Айдос А.К.", GroupNumber = 102, Grades = new int[] { 4, 4, 4, 4, 4 } };
        students[4] = new Student { Name = "Ерлан Е.М.", GroupNumber = 103, Grades = new int[] { 2, 3, 4, 5, 3 } };
        students[5] = new Student { Name = "Берик Б.Т.", GroupNumber = 103, Grades = new int[] { 4, 5, 5, 4, 5 } };
        students[6] = new Student { Name = "Данияр Д.С.", GroupNumber = 104, Grades = new int[] { 3, 3, 3, 4, 4 } };
        students[7] = new Student { Name = "Серик С.Р.", GroupNumber = 104, Grades = new int[] { 5, 4, 4, 5, 4 } };
        students[8] = new Student { Name = "Мурат М.А.", GroupNumber = 105, Grades = new int[] { 3, 4, 4, 4, 3 } };
        students[9] = new Student { Name = "Бауыржан Б.К.", GroupNumber = 105, Grades = new int[] { 5, 5, 4, 5, 5 } };

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].GetAverage() > students[j].GetAverage())
                {
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].HasOnlyGoodGrades() == 1)
            {
                System.Console.WriteLine(students[i].Name + " " + students[i].GroupNumber);
            }
        }
    }
}