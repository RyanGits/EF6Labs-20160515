using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class DeptCourseCount
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public int CourseCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContosoUniversityEntities())
            {
                //EF基本操作練習(db);

                //取得物件實體狀態(db);

                var c = db.Course.First();
                c.Title = "TEST 123";
                //c.ModifiedOn = DateTime.Now;
                if (db.Entry(c).State == System.Data.Entity.EntityState.Modified)
                {
                    var ce = db.Entry(c);
                    
                    var v1 = ce.CurrentValues.GetValue<string>("Title");
                    v1 = c.Title;
                    v1 = ce.Entity.Title;

                    var v2 = ce.OriginalValues.GetValue<string>("Title");

                    foreach (var prop in ce.OriginalValues.PropertyNames)
                    {
                        //ce.OriginalValues.GetValue<string>(prop);
                    }

                    Console.WriteLine("New Value: " + v1 + "\r\nOld Value: " + v2);


                    ce.CurrentValues.SetValues(new
                    {
                        ModifiedOn = DateTime.Now
                    });
                }






            }
        }

        private static void 取得物件實體狀態(ContosoUniversityEntities db)
        {

            db.Database.Log = Console.WriteLine;

            var c = db.Course.ToList().LastOrDefault();
            Console.WriteLine(c.Title + "\t" + db.Entry(c).State);

            c.Credits += 1;
            Console.WriteLine(c.Title + "\t" + db.Entry(c).State);
            //db.SaveChanges();

            db.Course.Remove(c);
            Console.WriteLine(c.Title + "\t" + db.Entry(c).State);
            //db.SaveChanges();

            //db.Entry(c).State = System.Data.Entity.EntityState.Deleted;
            //db.SaveChanges();

            //db.Entry(c).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            //db.Entry(c).State = System.Data.Entity.EntityState.Added;
            //db.SaveChanges();
        }

        private static void EF基本操作練習(ContosoUniversityEntities db)
        {
            db.Configuration.ProxyCreationEnabled = false;

            // 讀取所有 dbo.Course 中的資料
            foreach (var item in db.Course)
            {
                Console.WriteLine(item.Title);
            }

            // 用 LINQ 篩選資料
            //var data = from p in db.Course
            //           where p.Title != Guid.NewGuid().ToString()
            //           select p;
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //// 新增 Course 資料
            //var c = new Course()
            //{
            //    Title = "Git Test 2",
            //    Credits = 4,
            //    DepartmentID = 1
            //};
            ////c.Department = db.Department.Find(2);
            //db.Course.Add(c);

            // 取得 Inserted ID
            //Console.WriteLine(c.CourseID);
            //db.SaveChanges();
            //Console.WriteLine(c.CourseID);
            //Console.ReadLine();

            // 刪除一筆資料
            //db.Course.Remove(db.Course.Find(12));

            //// 批次更新資料
            //foreach (var item in db.Course)
            //{
            //    item.Credits += 1;
            //}
            //db.SaveChanges();



            //var one = db.Course.Include("Department").FirstOrDefault(p => p.CourseID == 1);
            //Console.WriteLine(one.Title + "\t" + one.Department.Name);


            //foreach (var dept in db.Department)
            //{
            //    Console.WriteLine(dept.Name);

            //    foreach (var course in dept.Course)
            //    {
            //        Console.WriteLine("\t" + course.Title);
            //    }
            //}

            //                var sql = @"SELECT Department.DepartmentID, Department.Name, 
            //                            (SELECT COUNT(*) FROM dbo.Course) as CourseCount
            //                            FROM Department";
            //                var data = db.Database.SqlQuery<DeptCourseCount>(sql);

            //var data = db.vwDeptCourseCount;

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Name + "\t" + item.CourseCount);
            //}

            //db.Course.Where(p => p.CourseID == 1);


            // AutoMapper
            //var c = db.Course.Create();
            //c.DepartmentID = 1;
            //c.Title = "123123123";
            //db.Course.Add(c);
            //db.SaveChanges();



            //var data = db.Course.AsNoTracking();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Title);
            //}

        }
    }
}
