//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebsite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float GPA { get; set; }
        public string CompletedCourses { get; set; }
        public string EnrollDate { get; set; }
        public Nullable<int> School_ID { get; set; }
    
        public virtual School School { get; set; }
    }
}
