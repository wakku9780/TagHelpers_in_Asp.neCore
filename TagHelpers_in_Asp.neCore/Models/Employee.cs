namespace TagHelpers_in_Asp.neCore.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender gender { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get;set; }

        public string Married { get; set; }

        public string Description { get; set; }

        public enum Gender
        {
               Male,Female   
        }
    }
}
