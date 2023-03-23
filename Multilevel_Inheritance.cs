// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        StudentAcademics s1 = new StudentAcademics();
        s1.setBasicInfo();
        s1.setContactDetails();
        s1.setAcademicDetails();
        
        Console.WriteLine("\n\n~~~~~Student Details~~~~\n");
        s1.BasicInfo();
        s1.ContactDetails();
        s1.AcademicDetails();

    }
    
    public class StudentBasic
    {
        public string name;
        public int rollNo;
        
        public void setBasicInfo(){
            Console.WriteLine("Enter Basic Details: \n");
            Console.WriteLine("Enter Your Name- ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Roll No- ");
            rollNo = Convert.ToInt32(Console.ReadLine());
        }
        
        public void BasicInfo(){
            Console.WriteLine("*> Basic Details-\nName="+name+"\n"+"Roll No="+rollNo+"\n");
        }
    }
    
    public class StudentContact : StudentBasic
    {
        public string Email;
        public ulong PhoneNo;
        public string Address;
        
        public void setContactDetails(){
            Console.WriteLine("\nEnter Contact Details: \n");
            Console.WriteLine("Enter You Email- ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNo- ");
            PhoneNo = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Address- ");
            Address = Console.ReadLine();
        }
        
        public void ContactDetails(){
            Console.WriteLine("*> Contact Details\nEmail="+Email+"\n"+"PhoneNo="+PhoneNo+"\n"+"Address="+Address+"\n");
        }
        
    }
    
    public class StudentAcademics : StudentContact
    {
        public double CGPA;
        public int Attendence;
        
        public void setAcademicDetails(){
            Console.WriteLine("\nEnter Academic Details: \n");
            Console.WriteLine("Enter CGPA- ");
            CGPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Attendence- ");
            Attendence = Convert.ToInt32(Console.ReadLine());
        }
        
        public void AcademicDetails(){
            Console.WriteLine("*> Academic Details\nCGPA= "+CGPA+"\n"+"Attendence= "+Attendence+"\n");
        }
    }
       
}
