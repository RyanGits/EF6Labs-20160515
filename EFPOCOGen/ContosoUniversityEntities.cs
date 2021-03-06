// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace EFPOCOGen
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class ContosoUniversityEntities : System.Data.Entity.DbContext, IContosoUniversityEntities
    {
        public System.Data.Entity.DbSet<Course> Courses { get; set; } // Course
        public System.Data.Entity.DbSet<Department> Departments { get; set; } // Department
        public System.Data.Entity.DbSet<Enrollment> Enrollments { get; set; } // Enrollment
        public System.Data.Entity.DbSet<OfficeAssignment> OfficeAssignments { get; set; } // OfficeAssignment
        public System.Data.Entity.DbSet<Person> People { get; set; } // Person
        public System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public System.Data.Entity.DbSet<VwDept> VwDepts { get; set; } // vwDept
        public System.Data.Entity.DbSet<VwDeptCourseCount> VwDeptCourseCounts { get; set; } // vwDeptCourseCount
        
        static ContosoUniversityEntities()
        {
            System.Data.Entity.Database.SetInitializer<ContosoUniversityEntities>(null);
        }

        public ContosoUniversityEntities()
            : base("Name=ContosoUniversityEntities")
        {
            InitializePartial();
        }

        public ContosoUniversityEntities(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public ContosoUniversityEntities(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public ContosoUniversityEntities(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public ContosoUniversityEntities(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new EnrollmentConfiguration());
            modelBuilder.Configurations.Add(new OfficeAssignmentConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
            modelBuilder.Configurations.Add(new VwDeptConfiguration());
            modelBuilder.Configurations.Add(new VwDeptCourseCountConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration(schema));
            modelBuilder.Configurations.Add(new DepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new EnrollmentConfiguration(schema));
            modelBuilder.Configurations.Add(new OfficeAssignmentConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new VwDeptConfiguration(schema));
            modelBuilder.Configurations.Add(new VwDeptCourseCountConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
        
        // Stored Procedures
        public int DepartmentDelete(int? departmentId, byte[] rowVersionOriginal)
        {
            var departmentIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DepartmentID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = departmentId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!departmentId.HasValue)
                departmentIdParam.Value = System.DBNull.Value;

            var rowVersionOriginalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@RowVersion_Original", SqlDbType = System.Data.SqlDbType.Timestamp, Direction = System.Data.ParameterDirection.Input, Value = rowVersionOriginal };
            if (rowVersionOriginalParam.Value == null)
                rowVersionOriginalParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[Department_Delete] @DepartmentID, @RowVersion_Original", departmentIdParam, rowVersionOriginalParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public System.Collections.Generic.List<DepartmentInsertReturnModel> DepartmentInsert(string name, decimal? budget, System.DateTime? startDate, int? instructorId)
        {
            int procResult;
            return DepartmentInsert(name, budget, startDate, instructorId, out procResult);
        }

        public System.Collections.Generic.List<DepartmentInsertReturnModel> DepartmentInsert(string name, decimal? budget, System.DateTime? startDate, int? instructorId, out int procResult)
        {
            var nameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Name", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name, Size = 50 };
            if (nameParam.Value == null)
                nameParam.Value = System.DBNull.Value;

            var budgetParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Budget", SqlDbType = System.Data.SqlDbType.Money, Direction = System.Data.ParameterDirection.Input, Value = budget.GetValueOrDefault(), Precision = 19, Scale = 4 };
            if (!budget.HasValue)
                budgetParam.Value = System.DBNull.Value;

            var startDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@StartDate", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = startDate.GetValueOrDefault() };
            if (!startDate.HasValue)
                startDateParam.Value = System.DBNull.Value;

            var instructorIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@InstructorID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = instructorId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!instructorId.HasValue)
                instructorIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<DepartmentInsertReturnModel>("EXEC @procResult = [dbo].[Department_Insert] @Name, @Budget, @StartDate, @InstructorID", nameParam, budgetParam, startDateParam, instructorIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public System.Collections.Generic.List<DepartmentUpdateReturnModel> DepartmentUpdate(int? departmentId, string name, decimal? budget, System.DateTime? startDate, int? instructorId, byte[] rowVersionOriginal)
        {
            int procResult;
            return DepartmentUpdate(departmentId, name, budget, startDate, instructorId, rowVersionOriginal, out procResult);
        }

        public System.Collections.Generic.List<DepartmentUpdateReturnModel> DepartmentUpdate(int? departmentId, string name, decimal? budget, System.DateTime? startDate, int? instructorId, byte[] rowVersionOriginal, out int procResult)
        {
            var departmentIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DepartmentID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = departmentId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!departmentId.HasValue)
                departmentIdParam.Value = System.DBNull.Value;

            var nameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Name", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name, Size = 50 };
            if (nameParam.Value == null)
                nameParam.Value = System.DBNull.Value;

            var budgetParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Budget", SqlDbType = System.Data.SqlDbType.Money, Direction = System.Data.ParameterDirection.Input, Value = budget.GetValueOrDefault(), Precision = 19, Scale = 4 };
            if (!budget.HasValue)
                budgetParam.Value = System.DBNull.Value;

            var startDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@StartDate", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = startDate.GetValueOrDefault() };
            if (!startDate.HasValue)
                startDateParam.Value = System.DBNull.Value;

            var instructorIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@InstructorID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = instructorId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!instructorId.HasValue)
                instructorIdParam.Value = System.DBNull.Value;

            var rowVersionOriginalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@RowVersion_Original", SqlDbType = System.Data.SqlDbType.Timestamp, Direction = System.Data.ParameterDirection.Input, Value = rowVersionOriginal };
            if (rowVersionOriginalParam.Value == null)
                rowVersionOriginalParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<DepartmentUpdateReturnModel>("EXEC @procResult = [dbo].[Department_Update] @DepartmentID, @Name, @Budget, @StartDate, @InstructorID, @RowVersion_Original", departmentIdParam, nameParam, budgetParam, startDateParam, instructorIdParam, rowVersionOriginalParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public System.Collections.Generic.List<GetDeptReturnModel> GetDept(int? id)
        {
            int procResult;
            return GetDept(id, out procResult);
        }

        public System.Collections.Generic.List<GetDeptReturnModel> GetDept(int? id, out int procResult)
        {
            var idParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = id.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!id.HasValue)
                idParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<GetDeptReturnModel>("EXEC @procResult = [dbo].[GetDept] @id", idParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int InsertDept(string name, decimal? budget)
        {
            var nameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Name", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name, Size = 50 };
            if (nameParam.Value == null)
                nameParam.Value = System.DBNull.Value;

            var budgetParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Budget", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = budget.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!budget.HasValue)
                budgetParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[InsertDept] @Name, @Budget", nameParam, budgetParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

    }
}
// </auto-generated>
