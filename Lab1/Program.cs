using System;
class Program
{
 static void Main() 
 //Step1: 
 {
    Console.WriteLine("Michael Lautner, IT-1050 - Lab 1");
    /* Michael Lautner 
    IT-1050 - Lab 1*/
    //Step 3: Declaring various variables
    int favNum = 13;
    string favLang = "Python";
    double numProg = 2.0;
    bool experience = true;
    //Step 4 Using variables
    Console.WriteLine("My favorite number is " + favNum);
    Console.WriteLine("My favorite programming language is " + favLang);
    Console.WriteLine("I have written " + numProg + " programs before this class");
    Console.WriteLine("Do I have programming experience? - > " + experience);
    // Step 5 Using a constant
    const string mySchool = "TriC";
    Console.WriteLine(mySchool);
 }
}