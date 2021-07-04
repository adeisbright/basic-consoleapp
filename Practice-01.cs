            
            /*Question 1
            ----------
            Write a C# program to print Hello , and your name in seperate line
            */
            var authorName = "Adeleke Bright" ; 
            Console.WriteLine("Hello") ; 
            Console.WriteLine($"TMy name is {authorName}") ; 

            /*
            Question 2
            ----------
            Write a C# program to print the sum of two numbers , dividing two numbers 
            */
            Console.WriteLine(20 + 45.8) ; 
            Console.WriteLine(45.8/20) ; 
            /*
            Question 3
            ----------
            Translate the following to C#
            > -1+4+6
            > (35+5)%7
            > 14+-4*6/11
            */

            /*
            Question 4
            ----------
            Write a  C# to swap two numbers
            > Input first number as 5 
            > Input second number as 6
            > Output should release first as 6 while second as 5
            */
            int firstNumber = 5 ; 
            int secondNumber = 6 ; 
            int tempNumber = firstNumber ;

            firstNumber = secondNumber  ; 
            secondNumber = tempNumber ;
            Console.WriteLine($"first number:{firstNumber} while second :{secondNumber}"); 

            /*
            Question 5
            ----------
            Write a multiplication program for 10 counting from 0 to 15
            */

            const int k = 10 ; 
            for(var i = 0 ; i <= 15 ; i++){
                var result = k*i ; 
                Console.WriteLine($"{k}*{i} = {result}") ;
            }

            /*
            Question 6
            ----------
            Write a program that prints the first 100 members of the sequence 2, -3,4, -5, 6
            */
            for (int i = 2 ; i < 30 ; i++){
                if (i%2 == 0){
                    Console.WriteLine($"The number is {i}") ; 
                }else{
                    Console.WriteLine($"The number is {-i}") ; 
                }
            }

             /*
            Question 6
            ----------
            Write a program that generates this sequence 0 , 5 , 10 , 15 , 20 , 25 ,…… , 80
            */ 
            for (int i = 0 ; i <= 80 ; i += 5){
                Console.WriteLine($"Result : {i}") ; 
            }

            /*
            Create variables to store the following information about a user with the
            following detail :
            Gender : f ,
            Age : 35 ,
            State of origin : Rivers State ,
            Covid Patient : No
            Net worth: 250,000.50
            */
            char gender = 'f' ; 
            int age = 35 ; 
            string stateOfOrigin = "Rivers State" ; 
            bool isCovidPatient = false ; 
            double networth = 250000.50 ; 
            Console.WriteLine(isCovidPatient) ; 
            /*
            Compound Interest Example 
            Compute the interest on N1000.00 for 5 years at 10%
            */
            int duration  = 5 ;
            double rate = 0.10 ; 
            double principal = 1000 ; 
            double loan = 0; 
            for (int i = 0 ; i < duration ; i++){
                loan = principal*rate + principal ;
                principal = loan ; 
                Console.WriteLine(loan) ; 
            }
            Console.WriteLine(loan) ; 
            /*
            Write a program that grades a student using this grading system :
            Score Grade
            80 – 100 A
            60 – 79 B
            50 – 59 C
            35 – 49 D
            0 – 34 F 
            */
            double score = 74 ; 
            if (score >= 80){
                Console.WriteLine($"Your score is {score} , you got  A") ;
            }else if (score >= 60 && score <= 79) {
                Console.WriteLine($"Your score is {score} , you got  B") ;
            }else if (score >= 50 && score <= 59) {
                Console.WriteLine($"Your score is {score} , you got  C") ;
            }else if (score >= 35 && score <= 49) {
                Console.WriteLine($"Your score is {score} , you got  D") ;
            }else {
                Console.WriteLine($"Your score is {score} , you got  F") ;
            }
