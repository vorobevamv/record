namespace Namespace
{
    class RecordLesson
    {
        static void Main() 
        {
            // object
            //Класс object является исходным базовым классом для всех классов .NET и корнем иерархии типов.
            //View -> Object Browser

            #region type conversion

            #region явное приведение типов

            /*byte byte1 = 10; //byte: min = 0; max = 255
            int int1 = 1000;
            byte byte2 = (byte)(int1+byte1);

            Console.WriteLine(byte2);
            Console.ReadLine();*/

            /*object objE = new();
            int intE = (int)objE;*/

            #endregion

            #region неявное приведение типов

            /*byte byte0 = 25;
            int int0 = byte0;

            Person personTC = new("Bob", 15, true);
            object obj0 = personTC;

            personTC.Name = "Bill";
            ((Person)obj0).Name = "Bill";*/

            #endregion

            #region is

            #region is type

            /*int intI = 5;
            string strI = "boo";
            Person personI = new("Eva", 17, true);
            object objI = new();

            Console.WriteLine("intI is int - " + (intI is int));
            Console.WriteLine("intI is string - " + (intI is string));
            Console.WriteLine("strI is string - " + (strI is string));
            Console.WriteLine("personI is Person - " + (personI is Person));
            Console.WriteLine("intI is object - " + (intI is object));
            Console.WriteLine("strI is object - " + (strI is object));
            Console.WriteLine("personI is object - " + (personI is object));
            Console.WriteLine("objI is int - " + (objI is int));
            Console.WriteLine("objI is string - " + (objI is string));
            Console.WriteLine("objI is Person - " + (objI is Person));
            Console.ReadLine();*/
            #endregion

            #region is null

            //bool isNow = null;

            /*while (true)
            {
                Console.WriteLine("Input your number");
                int number = Int32.TryParse(Console.ReadLine(), out int res) ? res : 1;
                Text.Print(Text.CreateText(number));
                Console.WriteLine();
            }*/

            #endregion

            #region is pattern compare

            /*Person personIE = new("Eva", 17, true);

            if (personIE is { Age: > 18, IsStudent: true })
            {
                Console.WriteLine($"{personIE.Name}, welcome to student party");
            }
            else
            {
                Console.WriteLine($"{personIE.Name}, sorry, you can't be here");
            }
            Console.ReadLine();*/

            #endregion

            #endregion

            #region as
            //только для ссылочных

            /*object objA = "abracadabra";
            //Person personA = (Person)objA;

            string strA = objA as string;
            Person personA = objA as Person;

            Console.WriteLine(personA);  */      //breakpoint!!

            #endregion

            #region Parse

            /*while (true)
            {
               Console.WriteLine("Введите число: ");
               string string0 = Console.ReadLine();

               //int intP = Int32.Parse(string0);                  //так не надо
               int intP = Convert.ToInt32(string0);             //так тоже не надо
               Console.WriteLine(intP + 10);
            }*/

            /*string stringN = null;
            //int intN = Int32.Parse(stringN);
            //int intN = Convert.ToInt32(stringN);
            Console.WriteLine(intN);
            Console.ReadLine();*/

            /*while (true)
            {
                Console.WriteLine("Введите число: ");
                string string1 = Console.ReadLine();

                bool canParse = Int32.TryParse(string1, out int result);

                if (canParse)
                {
                    Console.WriteLine(result + 10);
                }
                else
                {
                    Console.WriteLine("Это не число.");
                }
            }*/
            // =>
            // Console.WriteLine(Int32.TryParse(Console.ReadLine(), out int result) ? result + 10 : "Это не число.");
            #endregion

            #endregion

            #region GetType()
            //возвращает ссылку на класс-тип

            /*int intGT = 54;
            long longGT = 1000;
            string strGT = "blablabla";
            Person personGT = new("George", 12, true);

            Console.WriteLine("intGT.GetType - " + intGT.GetType());
            Console.WriteLine("longGT.GetType - " + longGT.GetType());
            Console.WriteLine("strGT.GetType - " + strGT.GetType());
            Console.WriteLine("personGT.GetType - " + personGT.GetType());
            Console.WriteLine();
            Console.WriteLine("ReferenceEquals(intGT.GetType(), longGT.GetType()) - \n" 
                + Object.ReferenceEquals(intGT.GetType(), longGT.GetType()));

            Console.ReadLine();*/

            #endregion

            #region ToString()

            /*char charTS = 'a';
            string stringTS1 = charTS.ToString();

            bool boolTS = false;
            Person personTS = new("Petya",45,false);

            string stringTS3 = boolTS.ToString();
            string stringTS4 = personTS.ToString();

            int intTS = 49;
            Console.WriteLine(intTS);
            Console.WriteLine(personTS);
            Console.ReadLine();*/

            /*Person a = null;
            string b = a.ToString();*/

            //override
            /*Person personTS = new("Petya", 45, false);
             Console.WriteLine(personTS);
             Console.ReadLine();*/

            #endregion

            #region GetHashCode()

            /*int intHC1 = 5;
            int intHC2 = 5;
            int intHC3 = 500;
            int intHC4 = 999;

            long longHC1 = 1234567891234567890;
            long longHC2 = 1234567891234567890;
            long longHC3 = 1231231231231231231;

            string strHC1 = "boo";
            string strHC2 = "boo";
            string strHC3 = "abracadabra";

            Person personHC1 = new("Cris", 27, false);
            Person personHC2 = new("Cris", 27, false);
            Person personHC3 = new("Cris", 48, true);

            Console.WriteLine("HashCode for \n"
                + "int intHC1 = 5 is " + intHC1.GetHashCode()
                + "\nint intHC2 = 5 is " + intHC2.GetHashCode()
                + "\nint intHC3 = 500 is " + intHC3.GetHashCode()
                + "\nint intHC4 = 999 is " + intHC4.GetHashCode()
                + "\n\nlong longHC1 = 1234567891234567890 is " + longHC1.GetHashCode()
                + "\nlong longHC2 = 1234567891234567890 is " + longHC2.GetHashCode()
                + "\nlong longHC3 = 1231231231231231231 is " + longHC3.GetHashCode()
                + "\n\nstring strHC1 = \"boo\" is " + strHC1.GetHashCode()
                + "\nstring strHC2 = \"boo\" is " + strHC2.GetHashCode()
                + "\nstring strHC3 = \"abracadabra\" is " + strHC3.GetHashCode()
                + "\n\nPerson personHC1 = \"Cris+27+false\" is " + personHC1.GetHashCode()
                + "\nPerson personHC2 = \"Cris+27+false\" is " + personHC2.GetHashCode()
                + "\nPerson personHC3 = \"Cris+48+true\" is " + personHC3.GetHashCode()
                );

            Console.ReadLine();*/

            #endregion

            #region Equals

            /*int num1 = 5;
            int num2 = 5;
            int num3 = 10;
            int num4 = num1;

            Console.WriteLine("num1.Equals(num2) - " + num1.Equals(num2));
            Console.WriteLine("num1.Equals(num3) - " + num1.Equals(num3));
            Console.WriteLine("num1.Equals(num4) - " + num1.Equals(num4));
            Console.ReadLine();*/


            /*string a = "boo";
            string b = "boo";
            string c = "abrakadabra";
            string d = a;

            Console.WriteLine("a.Equals(b) - " + a.Equals(b));
            Console.WriteLine("a.Equals(c) - " + a.Equals(c));
            Console.WriteLine("a.Equals(d) - " + a.Equals(d));
            Console.ReadLine();*/

            /*int num1 = 5;
            long num2 = 5;            //byte,long

            Console.WriteLine("(num1 == num2) - " + (num1 == num2));
            Console.WriteLine("num1.Equals(num2) - " + num1.Equals(num2));
            Console.WriteLine("ReferenceEquals(num1,num2) - " + ReferenceEquals(num1,num2));
            Console.ReadLine();*/


            /*string a = "boo";                   //null
            string b = "boo";                   //null

            Console.WriteLine("(a == b) - " + (a == b));
            Console.WriteLine("a.Equals(b) - " + a.Equals(b));
            Console.WriteLine("ReferenceEquals(a,b) - " + ReferenceEquals(a, b));
            Console.ReadLine();*/


            /*Person person1 = new("Vasya", 20, true);
            Person person2 = new("Vasya", 20, true);
            Person person3 = person1;

            Console.WriteLine("person1 == person2 - " + (person1 == person2));
            Console.WriteLine("person1.Equals(person2) - " + person1.Equals(person2));
            Console.WriteLine("ReferenceEquals(person1, person2) - " + ReferenceEquals(person1, person2) + "\n");

            Console.WriteLine("person1 == person3 - " + (person1 == person3));
            Console.WriteLine("person1.Equals(person3) - " + person1.Equals(person3));
            Console.WriteLine("ReferenceEquals(person1, person3) - " + ReferenceEquals(person1, person3));
            Console.ReadLine();*/

            #endregion

            #region record

            #region record vs class

            /*Person person1 = new("Vasya", 20, true);
            Person person2 = new("Vasya", 20, true);

            Console.WriteLine("person1.Equals(person2) - " + person1.Equals(person2));
            Console.WriteLine("ReferenceEquals(person1, person2) - " + ReferenceEquals(person1, person2));*/

           /* bool areTheSame =
                person1.Name.Equals(person2.Name)
                && person1.Age.Equals(person2.Age)
                && person1.IsStudent.Equals(person2.IsStudent);

            Console.WriteLine("Are the same - " + areTheSame);
            Console.ReadLine();*/

            #endregion

            #region record's specificity

            //Student student = new("Petya", 19);
            //student.Age = 25;


            /*student = student with
            {
                Age = 25
            };/*

            /*Person person = new("Gosha", 30, true);

            Console.WriteLine(person);
            Console.WriteLine(student);
            Console.ReadLine();*/

            /*var (studentName, studentAge) = student;
            Console.WriteLine($"{studentName} {studentAge}");
            Console.ReadLine();*/

            #endregion

            #endregion
        }
    }
}


