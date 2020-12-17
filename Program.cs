namespace extension
{  
    public static class StudentHelper  
    {  
        public static string GetUpperName(this Student student) 
        {  
            return student.name.ToUpper();  
        }  
    }  
    public class Student  
    {  
        public string name = "sowmya";  
        public string GetName()  
        {  
            return this.name;  
        }  
    }  
    public class ExtensionMethodExample  
    {  
        static void Main(string[] args)  
        {  
            Student student = new Student();  
            Console.WriteLine(student.GetName());  
            Console.WriteLine(student.GetUpperName());  
        }  
    }  
} 
