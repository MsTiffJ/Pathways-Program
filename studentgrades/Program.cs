/* 
Program description: This program calculates the final grade and average for each student

Programmer: Tiffany Jackson
Last update: July 21, 2023

Requirements:
(1) The beginning number of students from instructor
(2) The instructor to provide five homework grades, three quiz grades, and two exams
(3) Average the grades, quizzes, and exams
(4) Take that average and add in percent average for homework, quiz and exam
(5) Final grade calculated
(6) Calculated grade into letter grade
(7) Display each student's homework average, quiz average, exam average, final average, and final grade

Algorithm:
(1) Prompt the instructor to provide the number of students
    (1a)Obtain the number of students
    (1b)If number is not valid provide error
        (1ba)Instruct for valid number
    (1c)Start again if invalid number
(2) Prompt the instructor to provide 5 homework grades for each student
    (2a)Obtain the grades
        (2aa)Make sure grades are in between 0 and 100 inclusively
    (2b) Total grades together
    (2c) Average the total grades together
    (2d) Average homework total grade by 50%
(3) Prompt the instructor to provide 3 quiz grades for each student
    (3a)Obtain the quiz grades
        (3aa)Make sure each quiz grades are in between 0 and 100 inclusively
    (3b) Total quiz grades together
    (3c) Average the total quiz grades together
    (3d) Average quiz total grade by 30%
(4) Prompt the instructor to provide 2 exam grades for each student
    (4a)Obtain the exam grades
        (4aa)Make sure exam grades are in between 0 and 100 inclusively
    (4b) Total exam grades together
    (4c) Average the exam total grades together
    (4d) Average exam total grade by 20%
(5) Total all final grade averages
(6) Determine letter grade based on final grade number
(7) Continue to enter students and grades
*/

using System;

namespace studentgrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofstudents = 0;       //variable for number of students
            string? studentname;              //variable for student name
            int s = 0;                          //variable for student for loop
            int homeworkgradesttl = 0;      //variable for the homework grade total
                  
        
            //{
                    do
            {
                // (1) Prompt the instructor to provide the number of students
                Console.WriteLine("Enter the number of students");

                // (1a) Obtain the number of students
                numberofstudents = Convert.ToInt16(Console.ReadLine());

                // (1b)If number is not valid provide error
                if (numberofstudents < 1)

                // (1ba)Instruct for valid number
                {
                    Console.WriteLine(" Please enter at least 1 student ");
                }
                // (1c)Start again if invalid number
            }
            while (numberofstudents < 1);  

        for (s = 1; s <= numberofstudents; s++)   

        {      
                Console.WriteLine("Please enter student's name");

                studentname = Console.ReadLine();
             //reset variables for every student   
             homeworkgradesttl = 0;      //variable for the homework grade total
            int homeworkgradesavg = 0;      //variable for averaging the homework grade total
            double homeworkfinalavg = 0;       //variable for averaging the final homework grade total    
            int homework = 0;               //variable for obtaining homework grades
            int h = 0;                      //variable for the for homework loop
            int quizgradesttl = 0;          //variable for the quiz grade total
            int quizgradesavg = 0;          //variable for averaging the quiz grade total
            double quizfinalavg = 0;           //variable for averaging the final quiz grade total
            int quiz = 0;                   //variable for obtaining quiz grades
            int q = 0;                      //variable for the for quiz loop
            int examgradesttl = 0;          //variable for the exam grade total
            int examgradesavg = 0;          //variable for averaging the exam grade total
            double examfinalavg = 0;           //variable for averaging the final exam grade total
            int exam = 0;                   //variable for obtaining exam grades
            int e = 0;                      //variable for the for exam loop
            double finalgrade = 0;             //variable for the final grade

        for (h = 1; h <= 5; h++)

                // (2) Prompt the instructor to provide 5 homework grades of student

        {         

        do             
        {    

            Console.WriteLine("Please enter homework grade " + h );

                // (2a) Obtain the homework grades
                homework = Convert.ToInt16(Console.ReadLine()); 
                //Console.WriteLine(homework );                  //*used to test output//
                
                // (2aa)Make sure grades are in between 0 and 100 inclusively
        if (homework < 0 | homework > 100)

            {
                Console.WriteLine(" Please enter a valid grade ");
            }
        }

        while(homework < 0 | homework > 100);

                // (2b) Total grades together
                //homeworkgradesttl = homeworkgradesttl + homework;
                homeworkgradesttl += homework;
                //Console.WriteLine(homeworkgradesttl);         //*used to test output//

                // (2c) Average the total grades together                
                
        }
                homeworkgradesavg = homeworkgradesttl / 5;
                Console.WriteLine("The average of the grades entered is " + homeworkgradesavg);  

                // (2d) Average homework total grade by 50%
        
                homeworkfinalavg = homeworkgradesavg * .5;
                Console.WriteLine("The final average of the homework grades entered is " + homeworkfinalavg);

        for (q = 1; q <= 3; q++)

                // (3) Prompt the instructor to provide 3 quiz grades for each student

        {

        do
                 
        {    

            Console.WriteLine("Please enter quiz grade " + q );

                // (3b) Obtain the quiz grades
                quiz = Convert.ToInt16(Console.ReadLine()); 
                //Console.WriteLine(quiz );                  //*used to test output//

                //  (3aa)Make sure each quiz grades are in between 0 and 100 inclusively

        if (quiz < 0 | quiz > 100)

            {
                Console.WriteLine(" Please enter a valid grade ");
            }
        }

        while(quiz < 0 | quiz > 100);

                // (3b) Total quiz grades together
                //quizgradettl = quizgradettl + quiz;
                quizgradesttl += quiz;
                //Console.WriteLine(quizgradettl);         //*used to test output//

                // (3c) Average the total quiz grades together                
                
        }
                quizgradesavg = quizgradesttl / 3;
                Console.WriteLine("The average of the grades entered is " + quizgradesavg); 

                 // (3d) Average quiz total grade by 30%
        
                quizfinalavg = quizgradesavg * .3;
                Console.WriteLine("The final average of the quiz grades entered is " + quizfinalavg);
        
        for (e = 1; e <= 2; e++)

                // (4) Prompt the instructor to provide 2 exam grades for each student

        {

        do
        
        {    

            Console.WriteLine("Please enter exam grade " + e );

                // (4a) Obtain the exam grades
                exam = Convert.ToInt16(Console.ReadLine()); 
                //Console.WriteLine(exam );                  //*used to test output//

                //(4aa)Make sure exam grades are in between 0 and 100 inclusively

        if (exam < 0 | exam > 100)

            {
                Console.WriteLine(" Please enter a valid grade ");
            }
        }

        while(exam < 0 | exam > 100);

                // (4b) Total exam grades together
                //examgradettl = examgradettl + exam;
                examgradesttl += exam;
                //Console.WriteLine(examgradettl);         //*used to test output//

                // (4c) Average the total exam grades together                
                
        }
                examgradesavg = examgradesttl / 2;
                Console.WriteLine("The average of the grades entered is " + examgradesavg);  

                // (4d) Average exam total grade by 20%
        
                examfinalavg = examgradesavg * .2;
                Console.WriteLine("The final average of the exam grades entered is " + examfinalavg);

                //(5) Total all final grade averages

                        
                    //Console.WriteLine("Please enter student's name");

                    //studentname = Console.ReadLine();

                Console.WriteLine("Student name is " + studentname );
                finalgrade = homeworkfinalavg + quizfinalavg + examfinalavg; 

                Console.WriteLine("The final average for all homework grades entered is " + homeworkfinalavg);
                Console.WriteLine("The final average for all quiz grades entered is " + quizfinalavg);
                Console.WriteLine("The final average for all exam grades entered is " + examfinalavg);
                Console.WriteLine("The final average for all grades entered is " + finalgrade);
        
                //(6) Determine letter grade based on final grade number

        if (finalgrade >=90 && finalgrade <=100)
        {
           Console.WriteLine( "Your final grade in this class is A." ); 
        }
        else if (finalgrade >=80 && finalgrade <=89)
        {
           Console.WriteLine( "Your final grade in this class is B." );  
        }
        else if (finalgrade >=70 && finalgrade <=79)
        {
            Console.WriteLine( "Your final grade in this class is C." );
        }
        else if (finalgrade >=60 && finalgrade <=69)
        {
            Console.WriteLine( "Your final grade in this class is D." );
        }
        else 
        {
            Console.WriteLine( "Your final grade in this class is F." ); 
        }
   
        }
        }
    }
}