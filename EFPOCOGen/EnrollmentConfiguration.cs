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

    // Enrollment
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class EnrollmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentConfiguration()
            : this("dbo")
        {
        }
 
        public EnrollmentConfiguration(string schema)
        {
            ToTable(schema + ".Enrollment");
            HasKey(x => x.EnrollmentId);

            Property(x => x.EnrollmentId).HasColumnName(@"EnrollmentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CourseId).HasColumnName(@"CourseID").IsRequired().HasColumnType("int");
            Property(x => x.StudentId).HasColumnName(@"StudentID").IsRequired().HasColumnType("int");
            Property(x => x.Grade).HasColumnName(@"Grade").IsOptional().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Course).WithMany(b => b.Enrollments).HasForeignKey(c => c.CourseId); // FK_dbo.Enrollment_dbo.Course_CourseID
            HasRequired(a => a.Person).WithMany(b => b.Enrollments).HasForeignKey(c => c.StudentId); // FK_dbo.Enrollment_dbo.Person_StudentID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>