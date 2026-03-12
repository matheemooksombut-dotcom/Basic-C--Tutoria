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

            Console.WriteLine("Prefix : {0}",++a);
            Console.WriteLine("Last A  : {0}",a);

            
            // Postfix Oredering
            Console.WriteLine("_________________");
            Console.WriteLine("Postfix Oredering");
             

            Console.WriteLine("Postfix : {0}",a++);
            Console.WriteLine("Last A : {0}",a);



            
            
           
        
        }
    
}
}