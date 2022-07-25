namespace Namespace
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }

        public Person(string name, int age, bool isStudent)
        {
            Name = name;
            Age = age;
            IsStudent = isStudent;
        }

        #region override ToString
        /* public override string ToString()
         { 
             return Name;
         }*/
        #endregion
    }
}
