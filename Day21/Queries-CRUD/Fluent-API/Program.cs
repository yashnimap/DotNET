using DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Queries

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===========ADDING OBJECTS===============
            var context = new PlutoContext();

            //var authors = context.Authors.ToList();
            //var author = context.Authors.Single(a => a.Id==1);
            //var course = new Course {
            //    Name = "New Course",
            //    Description = "New Description",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    Author = author,
            //};

            //var course = new Course { 
            //    Name = "Yash",
            //    Description = "jadhav",
            //    FullPrice = 12.9f,
            //    Level = 2,
            //    Author = new Author {Id = 6, Name="yash ajdhav"}
            //};

            //context.Courses.Add(course);
            //context.SaveChanges();

            //===========UPDATING OBJECTS===============
            //var courese = context.Courses.Find(1002);
            //courese.Name = "New name";
            //courese.AuthorId = 1;
            //context.SaveChanges();

            //===========REMOVE OBJECTS===============
            //var courses = context.Courses.Find(1002);
            //context.Courses.Remove(courses);
            //context.SaveChanges();

            //var authors = context.Authors.Find(1003);
            //context.Authors.Remove(authors);//this will give an error because author id is map with courses
            //context.SaveChanges();

            //we can explicitly delete the above record by using eager loading
            var author = context.Authors.Include(c =>c.Courses).Single(a => a.Id == 1003);
            context.Courses.RemoveRange(author.Courses);
            context.Authors.Remove(author);
            context.SaveChanges();

            //for single record
            //var author = context.Authors
            //                    .Include(a => a.Courses)
            //                    .Single(a => a.Id == 1003);

            //var course = author.Courses.Single(); // Assuming there's only one course per author

            //Remove the course associated with the author
            //context.Courses.Remove(course);

            //Remove the author
            //context.Authors.Remove(author);

            //Save changes to the database
            //context.SaveChanges();
        }
    }
    }

