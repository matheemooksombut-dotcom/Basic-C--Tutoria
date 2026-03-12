using System.Text.RegularExpressions;

namespace BasicPrograming
{
     class Program
    {
       static  void Main(string[] args)
        {   

            Console.WriteLine("_________________");
            Console.WriteLine("Infomation");
            // Test Console WriteLine & \n
            Console.WriteLine("Hello From Test C# \n Firstname : {0} \n Lastname : {1} \n age : {2}","Mathhe" , "Mooksombut" , 22);
   
           
            Console.WriteLine("_________________");
            Console.WriteLine("Varidation");
            // variable (ตัวแปร)
            const  int x = 10; 
            const   int y = 20 ; 
            const  string text = "x+y";
            const int sum = x + y ; 
            Console.WriteLine(text+" = "+sum);  


            

            // Chang to ASCII
            Console.WriteLine("_________________");
            Console.WriteLine("Chang to ASCII");
            Console.Write("Input = ");
            
            char result  = Console.ReadKey().KeyChar;
            Console.WriteLine("\nThis is ASCII = "+(int)result);



            // Prefix Oredering
            Console.WriteLine("_________________");
            Console.WriteLine("Prefix Oredering");
             int a = 5 ;
            
            // after Pre
            Console.WriteLine("Prefix : {0}",++a);
            Console.WriteLine("Last A  : {0}",a);

            
            // Postfix Oredering
            Console.WriteLine("_________________");
            Console.WriteLine("Postfix Oredering");
             
            // after Post
            Console.WriteLine("Postfix : {0}",a++);
            Console.WriteLine("Last A : {0}",a);
            
            // Pase Fromat ** Formath จาก String เท่านั้น ื
            Console.WriteLine("_________________");
            Console.WriteLine("Fromat Validation");

            string s1 = "100" ;
            int s2 = 100 ; 
            int format  = int.Parse(s1);
            float format2 = float.Parse(s1);

            
            // string + string
            Console.WriteLine("Before Pase");
            Console.WriteLine("This is a string : {0}",s1+s2);

            // Num + Num 
            Console.WriteLine("Affter Pase num + num"); 
            Console.WriteLine("This is a string : {0}",format+s2);

            //  Float + Num 
            Console.WriteLine("Affter Pase Float + num"); 
            Console.WriteLine("This is a string : {0}",format2+s2);

            // ASSIGMENT 
            Console.WriteLine("_________________");
            Console.WriteLine("ASSIGMENT-1");

             double  Weight,height; 

            // INPUT
            Console.Write("Input Weight (kg) :"); 
            double.TryParse(Console.ReadLine(),out Weight);
            Console.Write("Input Height (cm) :"); 
            double.TryParse(Console.ReadLine(),out height);
           
            // PROCESS
            // bmi = weight/height*2
            double bmi = Weight/ Math.Pow(height,2);

            // OUT
            Console.Write("This is Your BMI : {0} \n",bmi);



            // Condition
            Console.WriteLine("_________________");
            Console.WriteLine("ASSIGMENT-2");

            // Input
            Console.Write("Input Score : "); 
            int.TryParse(Console.ReadLine(),out int score);

            if (score>=0 && score<=49)
            {
                Console.WriteLine("F");

            }else if (score>=50 && score<=60)
            {
                Console.WriteLine("D");

            }else if (score>=61 && score<=70)
            {
                Console.WriteLine("C");

            }else if (score>=71 && score<=80)
            {
                Console.WriteLine("B");

            }else if (score>=81 && score<=100)
            {
                Console.WriteLine("A");

            }

            // Check Age 
            Console.WriteLine("_________________");
            Console.WriteLine("ASSIGMENT-3");
            Console.Write("Input Age : "); 
            // Input
            int.TryParse(Console.ReadLine(),out int age);
            // Out Put
            if (age>20 && age<25)
            {
                Console.WriteLine("You're Teen Age");
            }else {
                Console.WriteLine("You're Not Teen Age");
            }


            // Condition  Check User / Admin
            Console.WriteLine("_________________");
            Console.WriteLine("ASSIGMENT-4");


            Console.Write("Please Enter Userename :"  ); 
            String Username = Console.ReadLine()!;

            if (Username=="admin")
            {
                Console.WriteLine("Hello Admin");
            }
            else {
                Console.WriteLine("Hello User");
            }
            



            
        }
    
}
}