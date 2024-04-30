using Demo.DemoCBIA.Models;


namespace Demo.DemoCBIA.Pages;

public partial class CoursesPage : ContentPage
{
    public List<Course> Courses {  get; set; }

    public CoursesPage()
    {
        InitializeComponent();

        Courses = new List<Course>
        {
            new Course { Title = "Introduction to Programming", Description = "Learn the basics of programming.", KeyDates = "Jan 10, Mar 15" , Events = "Midterm Exam, Final Exam", Agreements =  "Student Handbook,Code of Conduct"  },
            new Course { Title = "Advanced Algorithms", Description = "Explore complex algorithms and data structures.", KeyDates =  "Feb 28, May 10", Events = "Project Due, Final Presentation" , Agreements = "Course Syllabus, Academic Integrity Policy" },
        };

        BindingContext = this;

    }
    
}