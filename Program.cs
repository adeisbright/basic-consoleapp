using System ; 
namespace Hello {
    class Program {
        static void Main(string[] args){
           Console.WriteLine("Hello ,                  World") ; 
           char userGender = 'm' ; 
           Console.WriteLine(userGender) ; 

           string message = "Hello , World" ; 
           Console.WriteLine("My message is " + message) ; 
           
           int userAge = 21 ; 
           Console.WriteLine("This user is " + userAge + "years old") ; 
           
           double businessProfit = 3000.20 ;
           Console.WriteLine("My business generated this amount of profile  " + businessProfit) ; 

           bool isUserSick = false ; 
           Console.WriteLine(isUserSick) ; 
           // A comment is a non-executable text that provides more information on a program
           // It is used by those who read the code and not by the compiler 
           // It will not be executed 
           // This is a single line comment 

           /*
           This is a multi-line comment. 
           We use it for documenting methods and classes 
           */ 

           /* This is a comment */ 
            // Arithmetic Operators 
            int a = 3 ; 
            int b = 2 ; 
            int c = a + b ; 
            Console.WriteLine(c) ; // 5
            c = a - b ; 
            Console.WriteLine(c) ; // 1 
            double d = (double) a/b ; // 1.5
            Console.WriteLine(d) ; 
            c = a*b ; // 6
            Console.WriteLine(c) ;
            c = a%b ; // 1
            Console.WriteLine(c) ;

            // Comparison Operator 
            int x = 4 ; 
            int y = 6 ; 
            bool z = x > y ; //false 
            Console.WriteLine(z) ; 
            z = x < y ; 
            Console.WriteLine(z) ; 
            z = x <= y ; 
            Console.WriteLine(z) ; 
            z = x >= y ; 
            Console.WriteLine(z) ; 
            z = x == y ; 
            Console.WriteLine(z) ; 
            z = x != y ; 
            Console.WriteLine(z) ; 
            z = !(x < y && x > 2) ; 
            Console.WriteLine(z) ; 
            z = x < y || x > 2 ; 
            Console.WriteLine(z) ; 
            z =  x < y && x > 10 ; 
            Console.WriteLine(z) ; 
            int m = 3 ;
            m += 5 ; //8  
            Console.WriteLine(m) ; 
            m -= 2  ; // 6 
            m *= 2  ; // 12 
            m /= 3  ; // 4 ;
            m %= 3  ; // 1 
            Console.WriteLine(m) ; 

            //Conditionals 
            if (2 > 6){
                Console.WriteLine("2 is greater than 6") ; 
            }else if (2 > 5 ){
                Console.WriteLine("2 is equal 2") ; 
            }else {
                Console.WriteLine("2 is less than  5 and 6") ;
            }

            //Repetition 

            // int num = 20 ; // Crate the loop control variable 
            //  // Loop control variable 
            // while( num >= 0) {
            //     Console.WriteLine(num) ; //Code to execute 
            //     num-- ; //Increment or decrement  ++ Increment operator , -- decrement operator 
            // }
            // Console.WriteLine("Loop ends") ; 

            // A simple program to test odd and even numbers 
            int i = 1 ; 
            while (i <= 30) { 
                if (i%2 == 0 && i != 0){
                    Console.WriteLine(i + "  is even") ; 
                }else{
                    Console.WriteLine(i + "  is odd") ; 
                }
                i++ ; 
            }
        }
    }
} 
