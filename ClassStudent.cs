

class Student
{
    public string FirstName;
    public string LastName;
    public string Group;
    public double Point;
    public double StudyingYears;
    public bool isGraduated;

    public Student(string firstName, string lastName, string group, double point, double studyingyears)
    {
        this.FirstName = firstName;

        this.LastName = lastName;

        this.Group = group;

        this.Point = point;

        this.StudyingYears = studyingyears;

    }
        
      
      
    
    
    public void GetFullName()
    {
        Console.WriteLine( $"{this.FirstName} ,{this.LastName}");
    }

    public void GetFuLlInfo()
    {
        Console.WriteLine($"{this.FirstName},{this.LastName},{this.Group},{this.Point}");
        if (StudyingYears == 4)
        {
            isGraduated = true;
            Console.WriteLine("Mezun OLub");
        }
        else if (StudyingYears < 4 && StudyingYears > 0)
        {
            isGraduated = false;
            Console.WriteLine("Mezun OLmayib");
        }
        else
        {
            Console.WriteLine("Bu hec universitetde deyil");
        }

        if (StudyingYears < 4 && StudyingYears > 0 && Point > 80 && Point < 100)
        {
            Console.WriteLine("Ikinci imhatahana gire bilersen, malades");
        }
        
        else if (StudyingYears < 4 && StudyingYears > 0 && Point == 100)
        {
            Console.WriteLine("Ay deli, ikinci imtahan neyine lazim?! 100-nu almisan otur yerinde de");
        }



        else if (StudyingYears < 4 && StudyingYears > 0 && Point <= 80 && Point >= 0)
        {
            Console.WriteLine("Ikinci imtahana gire bilmersen, vaxtinda oxuyardin");
        }

        else if (StudyingYears == 4)
        {
            isGraduated = true;
            Console.WriteLine("Artiq mezun olub, imtahanlarin verib. Ne ikinci, ne de hec bele on besinci imtahana gerek yoxdur. El cekin usaqdan");
        }

    }    
    
    

}
