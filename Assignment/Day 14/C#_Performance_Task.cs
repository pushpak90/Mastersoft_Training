using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day_14_test
{
    //class 1 contain basic info 
    class basic_d
    {
        public string g_name, g_city, g_state, g_cast, g_mobile, g_country;
        public void input(string d_name, string d_city, string d_state, string d_cast,
            string d_mobile, string d_country)
        {
            g_name = d_name;
            g_city = d_city;
            g_state = d_state;
            g_cast = d_cast;
            g_mobile = d_mobile;
            g_country = d_country;
        }
    }
    //class 2 contain qualification info 
    class edu_d : basic_d
    {
        public string g_c_name, g_branch, g_sub, g_sem, g_e_c_city;
        public void edu_input(string e_c_name, string e_branch, string e_sub, string e_sem, string e_c_city)
        {
            g_c_name = e_c_name;
            g_branch = e_branch;
            g_sub = e_sub;
            g_sem = e_sem;
            g_e_c_city = e_c_city;
        }
    }
    //class 3 contain Marks
    class mark_d : edu_d
    {
        public int g_total;
        public SortedList<string, int> g_mark;
        public void mark_total(SortedList<string, int> mark)
        {
            int total = 0;
            foreach (var i in mark.Keys)
            {
                total = total + mark[i];
            }
            g_total = total;
            g_mark = mark;
        }
    }
    //class 4 grade logic and printing info
    class display_d : mark_d
    {
        public string g_garde;
        public void display()
        {
            Console.WriteLine("\nYour Name is : " + g_name +
                "\nCollege Name : " + g_c_name +
                "\nTotal is : " + g_total
                ); ;
            if (g_total > 250)
            {
                g_garde = "Grade A";
                Console.WriteLine("\nGrade A");
            }
            else if (g_total > 150 && g_total < 250)
            {
                g_garde = "Grade B";
                Console.WriteLine("\nGrade B");
            }
            else if (g_total > 100 && g_total < 150)
            {
                g_garde = "Grade C";
                Console.WriteLine("\nGrade C");
            }
            else
            {
                g_garde = "Fail";
                Console.WriteLine("\nFail");
            }
        }
    }
    //class 5 - printing marksheet 
    class marksheet_d : display_d
    {
        public void display_marksheet()
        {
            Console.Write("\nName : " + g_name +
                "\nCollege : " + g_c_name +
                "\nSubject : " + g_mobile +
                "\nBranch : " + g_branch
            );
            int sno = 1;
            Console.WriteLine("\n\nSno\t|\tSubject Name\t|\tMarks");
            foreach (var ii in g_mark.Keys)
            {
                Console.WriteLine(sno + "\t|\t" + ii + "\t\t|\t" + g_mark[ii]);
                sno++;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Total is : " + g_total);
            Console.WriteLine("Grade is : " + g_garde);
            Console.WriteLine("Develped by : Pushpak Fasate");
        }
    }
    class Program
    {
        //this contain only basic info variable
        struct basic
        {
            public string name;
            public string city;
            public string state;
            public string cast;
            public string mobile;
            public string country;
        };
        //this contain only education variable
        struct education
        {
            public string college;
            public string branch;
            public string subject;
            public string sem;
            public string c_city;
        };
        static void Main(string[] args)
        {
            basic b;
            education e;
            marksheet_d dis = new marksheet_d();
            bool val = true;
            Console.WriteLine("COLLEGE STUDENT MARK SYSTEM ");
            Console.WriteLine("==============================");
            //To run this loop up till user give input 6 
            while (val)
            {
                //Giveing option to user
                Console.Write("\n[1] Basic Details \n[2] Education Details \n[3] Subject Details" +
               "\n[4] Display Total and Grade \n[5] Display Marksheet\n[6]Press 6 for Exit\n\nEnter Your Choice : ");
                int ch = int.Parse(Console.ReadLine());
                //suppose user give ch value 6 then loop get exit
                if (ch == 6)
                {
                    val = false;
                }
                else
                {
                    //according to the user the swtich case will run
                    switch (ch)
                    {
                        case 1:
                            //For the Screen - 1
                            Console.WriteLine("\nBasic Details : ");
                            Console.Write("Enter Name : ");
                            b.name = Console.ReadLine();
                            Console.Write("Enter City : ");
                            b.city = Console.ReadLine();
                            Console.Write("Enter State : ");
                            b.state = Console.ReadLine();
                            Console.Write("Enter Cast : ");
                            b.cast = Console.ReadLine();
                            Console.Write("Enter Mobile : ");
                            b.mobile = Console.ReadLine();
                            Console.Write("Enter Country : ");
                            b.country = Console.ReadLine();
                            //data can not be null or empty
                            try
                            {
                                if (string.IsNullOrEmpty(b.name) || string.IsNullOrEmpty(b.city) || string.IsNullOrEmpty(b.state)
                                    || string.IsNullOrEmpty(b.cast) || string.IsNullOrEmpty(b.mobile) || string.IsNullOrEmpty(b.country))
                                {
                                    throw new Exception("All Field are require");
                                }
                            }
                            catch (Exception bas)
                            {
                                Console.WriteLine(bas);
                            }
                            dis.input(b.name, b.city, b.state, b.cast, b.mobile, b.country);

                            break;

                        case 2:
                            //For the Screen - 2
                            Console.WriteLine("\nEducation Details : ");
                            Console.Write("Enter College Name : ");
                            e.college = Console.ReadLine();
                            Console.Write("Enter Branch Name : ");
                            e.branch = Console.ReadLine();
                            Console.Write("Enter Subject Name : ");
                            e.subject = Console.ReadLine();
                            Console.Write("Enter Semester : ");
                            e.sem = Console.ReadLine();
                            Console.Write("College City : ");
                            e.c_city = Console.ReadLine();
                            //data can not be null or empty
                            try
                            {
                                if (string.IsNullOrEmpty(e.college) || string.IsNullOrEmpty(e.branch) || string.IsNullOrEmpty(e.subject)
                                    || string.IsNullOrEmpty(e.sem) || string.IsNullOrEmpty(e.c_city))
                                {
                                    throw new Exception("All Field are require");
                                }
                            }
                            catch (Exception bas)
                            {
                                Console.WriteLine(bas);
                            }

                            dis.edu_input(e.college, e.branch, e.subject, e.sem, e.c_city);

                            break;

                        case 3:
                            //For the Screen - 3
                            Console.WriteLine("\nSubject Details : ");
                            SortedList<string, int> allmark = new SortedList<string, int>(5);
                            int i3 = 1;
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Enter Subject-" + i3 + " : ");
                                allmark.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                                i3++;
                            }
                            //marks can not be in negative value 
                            try
                            {
                                foreach (var i in allmark.Keys)
                                {
                                    if (allmark[i] < 0)
                                    {
                                        throw new Exception("Mark can not be negative");
                                    }
                                }
                            }
                            catch (Exception bas)
                            {
                                Console.WriteLine(bas);
                            }

                            dis.mark_total(allmark);
                            break;
                        case 4:
                            //For the Screen - 4
                            dis.display();
                            break;
                        case 5:
                            //For the Screen - 5
                            dis.display_marksheet();
                            break;
                        case 6:
                            //For exit
                            break;

                        default:
                            Console.Write("\n\nInvalid\n\n");
                            break;
                    }
                }
            }
            Console.Write("Thank You !");
            Console.ReadKey();
        }
    }
}
