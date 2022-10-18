
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
//int high_student_grades = 0;
//int low_student_grades = 0;
//int avg_grades_in_israel;
//Console.WriteLine("Please input the average of grades in israel: ");
//avg_grades_in_israel = int.Parse(Console.ReadLine());
//for (int i = 0; i < 8; i++)
//{
//    Console.WriteLine("Please input a grade: ");
//    int studentgrade = int.Parse(Console.ReadLine());
//    if (studentgrade > avg_grades_in_israel)
//    {
//        high_student_grades++;
//    } else if (studentgrade < avg_grades_in_israel)
//    {
//        low_student_grades++;
//    }
//}
//Console.WriteLine($"The amount of students that are below the average is: {low_student_grades}");
//Console.WriteLine($"The amount of students that are above the average is: {high_student_grades}");




// Assignment 7
//int amount_of_people_who_were_tested;
//Console.WriteLine("Please input the amount of people who were tested: ");
//amount_of_people_who_were_tested = int.Parse(Console.ReadLine());
//int amount_of_people_who_failed = 0;
//int amount_of_people_who_passed = 0;

//for (int i = 0; i < amount_of_people_who_were_tested; i++)
//{
//    Console.WriteLine("Please input the amount of mistakes: ");
//    int amount_of_mistakes = int.Parse(Console.ReadLine());
//    if (amount_of_mistakes > 3)
//    {
//        amount_of_people_who_failed++;
//    } else if (amount_of_mistakes < 3)
//    {
//        amount_of_people_who_passed++;
//    }

//}
//Console.WriteLine($"The amount of people who passed is: {amount_of_people_who_passed}");
//Console.WriteLine($"The amount of people who failed is: {amount_of_people_who_failed}");


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
//static int pairs_checker(int firstpair, int secondpair)
//{
//    if (firstpair % secondpair == 0)
//    {
//        Console.WriteLine("This pair is even"); ;
//    }
//    else if (firstpair % secondpair != 0)
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
//int firstpair = int.Parse(Console.ReadLine());
//Console.WriteLine("please input second number: ");
//int secondpair = int.Parse(Console.ReadLine());

//pairs_checker(firstpair, secondpair);


// Assingment 11
//static int group_calc(int amount_of_kids)
//{

//    int group_of_children = 0;
//    int group_of_teenagers = 0;
//    int guide_for_children = 0;
//    int guide_for_adult = 0;
//    for (int i = 0; i < amount_of_kids; i++)
//    {
//        Console.WriteLine("Please enter an age: ");
//        int age = int.Parse(Console.ReadLine());
//        if ((age >= 8) && (age <= 11))
//        {
//            group_of_children++;
//        }
//        else if ((age >= 12) && (age <= 15))
//        {
//            group_of_teenagers++;
//        }
//    }
//    guide_for_children = group_of_children / 4;
//    guide_for_adult = group_of_teenagers / 7;

//    int req_guide_for_children = 150 / 4;
//    int req_guide_for_adult = 150 / 7;
//    Console.WriteLine($"There are {group_of_children} kids in the age range of: 8-11");
//    Console.WriteLine($"{group_of_teenagers} kids in the age range of: 12-15");
//    Console.WriteLine($"{req_guide_for_children - guide_for_children} guides required for children");
//    Console.WriteLine($"{req_guide_for_adult - guide_for_adult} guides required for adults");
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











