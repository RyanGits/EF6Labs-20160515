using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContosoUniversityEntities())
            {
                //EF基本操作練習(db);
            }
        }

        private static void EF基本操作練習(ContosoUniversityEntities db)
        {
            // 讀取所有 dbo.Course 中的資料
            //foreach (var item in db.Course)
            //{
            //    Console.WriteLine(item.Title);
            //}

            // 用 LINQ 篩選資料
            //var data = from p in db.Course
            //           where p.Title != Guid.NewGuid().ToString()
            //           select p;
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Title);
            //}

            // 新增 Course 資料
            var c = new Course()
            {
                Title = "Git Test 2",
                Credits = 4,
                DepartmentID = 1
            };
            //c.Department = db.Department.Find(2);
            db.Course.Add(c);

            // 取得 Inserted ID
            //Console.WriteLine(c.CourseID);
            //db.SaveChanges();
            //Console.WriteLine(c.CourseID);
            //Console.ReadLine();

            // 刪除一筆資料
            db.Course.Remove(db.Course.Find(12));

            // 批次更新資料
            foreach (var item in db.Course)
            {
                item.Credits += 1;
            }
            db.SaveChanges();
        }
    }
}
