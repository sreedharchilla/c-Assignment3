﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Student
    {
        int rollno;
        string name;
        string stdclass;
        string semister;
        string branch;

        public void displayresult()
        {
            int[] marks = new int[5];
            marks[0] = 30;
            marks[1] = 50;
            marks[2] = 42;
            marks[3] = 47;
            marks[4] = 69;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            double average = marks.Average();
            Console.WriteLine("The total subject of average : " + average);

            for (int i = 0; i < marks.Length; i++)
            {

                if (marks[i] < 35)
                {
                    Console.WriteLine(marks[i] + "  The subject is a failed");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine(" The student is  failed");
                }
                else if (average > 50)
                {
                    Console.WriteLine(" The student is passed ");
                }
                else
                {
                    Console.WriteLine(" The Enter the  valid details");
                }
            }

        }

        public Student(int rollno, String name, string stdclass, string semister, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.stdclass = stdclass;
            this.semister = semister;
            this.branch = branch;
            Console.WriteLine($"rollno is:{rollno}, name is:{name},student class is:{stdclass},semister is:{semister},branch is :{branch}");

        }
        public void displaydata()
        {
            Console.WriteLine("The result is ");
        }
    }
}
