using System;

namespace tellmeyourname
{  
    //How to declare a struct 
    struct Book {
        public string Author ; 
        public string Title ; 
        public DateTime PublicationDate ; 
        public string ISBN;
    } 

    //How to declare an enum 
    enum Colors { Blue , Red , Green , Orange , Violet} ; 
    

    //Working with an Interface 
    // interface IShapeMethods {
    //     double ComputeArea(){}
    // } 

    //Working with a class 

    public class Shape { 
        protected double Width ; 
        protected double Height ; 
        public Shape(double width , double height){
            this.Width = width ; 
            this.Height = height ; 
        } 
        public Shape(double size){
            this.Width = size ; 
            this.Height = size ; 
        }

        public virtual double ComputeArea(){ 
            try {
                if (this.Width > 0 && this.Height > 0){
                    return Math.Round(this.Width*this.Height , 2) ; 
                }else {
                    throw new Exception("Invalid Parameters provided for shape") ;
                }
            }catch(Exception e){
                return 0.0 ; 
            }
        }
    }

    
    public class Square:Shape { 
        public Square(double size) : base(size){} 
        public override double  ComputeArea(){
            return Math.Round((this.Width*this.Height) , 2) ;   
        }

        public void displayArea(){
            Console.WriteLine($"The area of the square is {this.ComputeArea()}") ; 
        }

    }

    class Program{
        static void Main(string[] args){ 
            Console.WriteLine("Welcome to Tell Me About Yourself. Please enter your name and your age below") ; 
            try {
                YourName femi = new YourName() ; 
                femi.DescribeSelf() ; 
            }catch(ArithmeticException e){
                Console.WriteLine(e.Message) ;
                return ;
            }catch(Exception e){
                Console.WriteLine(e.Message) ; 
            }
            //Using Struct without a constructor
            Book myBook  ; 
            myBook.Author = "Fuad Femi"  ; 
            myBook.Title = "Learning how to code in C#" ; 
            myBook.PublicationDate = DateTime.Now ;  
            myBook.ISBN = "12090939398AHSG" ; 

            //Instantiating an instance of our class 
            Square square = new Square(4.5) ; 
            square.displayArea() ; 

            Console.WriteLine(@$"Working with enums /'s {Colors.Red} is at {(int) Colors.Red}") ; 
            Console.WriteLine($"My book\'s title is {myBook.Title}") ; 
        }
    }
}
