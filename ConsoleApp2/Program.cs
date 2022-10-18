
// Assignment 3
////Console.WriteLine("The Odd numbers between 10-40 are:");
////for (int i = 10; i < 40; i++)
////{
////    if (i % 2 != 0)
////    {
////        Console.WriteLine(i);
////    }
////}
////Console.WriteLine("The Even numbers between 60-90 are: ");
////for (int i = 60; i < 90; i++)
////{
////    if (i % 2 == 0)
////    {
////        Console.WriteLine(i);
////    }
////}


// Assignment 4
//Console.WriteLine("Please input a number: ");
//int usernum = int.Parse(Console.ReadLine());
//for (int i = 1; i <= usernum; i++)
//{
//    if (usernum % i == 0)
//    {
//        Console.WriteLine(i);
//    }
//}



// Assignment5
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine("Please input a number: ");
//    int num = int.Parse(Console.ReadLine());
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("The number is Even");
//    } else if (num % 2 != 0)
//    {
//        Console.WriteLine("The number is Odd");
//    } else if ((num % 2 != 0) && (num % 2 == 0))
//    {
//        Console.WriteLine("Other");
//    }
//}

// Assignment 6
//int HighStudentGrades = 0;
//int LowStudentGrades = 0;
//int AvgGradesInIsrael;
//Console.WriteLine("Please input the average of grades in israel: ");
//AvgGradesInIsrael = int.Parse(Console.ReadLine());
//for (int i = 0; i < 8; i++)
//{
//    Console.WriteLine("Please input a grade: ");
//    int StudentGrade = int.Parse(Console.ReadLine());
//    if (studentgrade > AvgGradesInIsrael)
//    {
//        HighStudentGrades++;
//    } else if (StudentGrade < AvgGradesInIsrael)
//    {
//        LowStudentGrades++;
//    }
//}
//Console.WriteLine($"The amount of students that are below the average is: {LowStudentGrades}");
//Console.WriteLine($"The amount of students that are above the average is: {HighStudentGrades}");




// Assignment 7
//int amountOfPeopleWhoWereTested;
//Console.WriteLine("Please input the amount of people who were tested: ");
//amountOfPeopleWhoWereTested = int.Parse(Console.ReadLine());
//int amountOfPeopleWhoFailed = 0;
//int amountOfPeopleWhoPassed = 0;

//for (int i = 0; i < amountOfPeopleWhoWereTested; i++)
//{
//    Console.WriteLine("Please input the amount of mistakes: ");
//    int amountOfMistakes = int.Parse(Console.ReadLine());
//    if (amountOfMistakes > 3)
//    {
//        amountoOfPeopleWhoFailed++;
//    } else if (AmountOfMistakes < 3)
//    {
//        amountOfPeopleWhoPassed++;
//    }

//}
//Console.WriteLine($"The amount of people who passed is: {AmoudntOfPeopleWhoPassed}");
//Console.WriteLine($"The amount of people who failed is: {AmountOfPeopleWhoFailed}");


////Assignment 8
//static int multiplier(int x, int y)
//{
//    int z = x;
//    for (int i = 1; i < y; i++)
//    {
//        z = z + x;
//    }
//    Console.WriteLine(z);
//    return z;

//}

//Console.WriteLine("please input a number: ");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input a second number: ");
//int y = int.Parse(Console.ReadLine());
//multiplier(x, y);

////Assignment 9

//Console.WriteLine("Please input a number: ");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input a second number: ");
//int y = int.Parse(Console.ReadLine());
//int z = x;
//for (int i = 1; i < y; i++)
//{
//    z = z * x;
//}
//Console.WriteLine(z);

//Assignment 10
//static int PairsChecker(int firstPair, int secondPair)
//{
//    if (firstPair % secondPair == 0)
//    {
//        Console.WriteLine("This pair is even"); ;
//    }
//    else if (firstPair % secondPair != 0)
//    {
//        Console.WriteLine("This pair is odd");
//    }
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("please input first number: ");
//        int pair1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("please input second number: ");
//        int pair2 = int.Parse(Console.ReadLine());

//        if (pair1 % pair2 == 0)
//        {
//            Console.WriteLine("This pair is even"); ;
//        }
//        else if (pair1 % pair2 != 0)
//        {
//            Console.WriteLine("This pair is odd");
//        }
//    }


//    return 0;
//}

//Console.WriteLine("please input first number: ");
//int firstPair = int.Parse(Console.ReadLine());
//Console.WriteLine("please input second number: ");
//int SecondPair = int.Parse(Console.ReadLine());

//PairsChecker(firstPair, SecondPair);


// Assingment 11
//static int GroupCalc(int AmountOfKids)
//{

//    int groupOfChildren = 0;
//    int groupOfTeenagers = 0;
//    int guideForChildren = 0;
//    int guideForAdult = 0;
//    for (int i = 0; i < amountOfKids; i++)
//    {
//        Console.WriteLine("Please enter an age: ");
//        int age = int.Parse(Console.ReadLine());
//        if ((age >= 8) && (age <= 11))
//        {
//            groupOfChildren++;
//        }
//        else if ((age >= 12) && (age <= 15))
//        {
//            groupOfTeenagers++;
//        }
//    }
//    guideForChildren = groupOfChildren / 4;
//    guideForAdult = groupOfTeenagers / 7;

//    int reqGuideForChildren = 150 / 4;
//    int reqGuideForAdult = 150 / 7;
//    Console.WriteLine($"There are {groupOfChildren} kids in the age range of: 8-11");
//    Console.WriteLine($"{groupOfTeenagers} kids in the age range of: 12-15");
//    Console.WriteLine($"{reqGuideForChildren - guideForChildren} guides required for children");
//    Console.WriteLine($"{reqGuideForAdult - guideForAdult} guides required for adults");
//    return 0;
//}

//Console.WriteLine("Please input the amount of kids");
//int num = int.Parse(Console.ReadLine());
//group_calc(num);


////Assignment 12
//int usernum = int.Parse(Console.ReadLine());
//int x = usernum;
//for (int i = 1; i < usernum; i++)
//{
//    x = x * i;
//}
//Console.WriteLine(x);











