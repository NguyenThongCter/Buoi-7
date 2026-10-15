using System;

namespace WinFormsApp4
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Grade}";
        }
    }
}