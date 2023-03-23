using System;

   class Demo {
       
      //student class
      class Student {
          public string name;
          public int RollNo;
          
          public void SetData(){
              this.name = Console.ReadLine();
              this.RollNo = Convert.ToInt32(Console.ReadLine());
          }
          
         public void GetData() {
            Console.WriteLine("Name= "+this.name+"\nRoll No= "+this.RollNo+"\n");
         }
      }
      
      //result class
      class Result : Student {
          
          
          public void SetMarks(){
              
          }
          
         public void DisplayResult() {
            Console.WriteLine("\n\n_____RESULTS____\n");
            GetData();
            Console.WriteLine("You Passed");
         }
         
      }
      
        //main
        static void Main(string[] args) {
          
         // student class
         Student s = new Student();
         
         // result class
         Result r = new Result();
          r.SetData();
          r.SetMarks();
         r.GetData();
         r.DisplayResult();

      }
   }
