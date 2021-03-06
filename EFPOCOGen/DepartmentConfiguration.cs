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

    // Department
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class DepartmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
            : this("dbo")
        {
        }
 
        public DepartmentConfiguration(string schema)
        {
            ToTable(schema + ".Department");
            HasKey(x => x.DepartmentId);

            Property(x => x.DepartmentId).HasColumnName(@"DepartmentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Budget).HasColumnName(@"Budget").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.StartDate).HasColumnName(@"StartDate").IsRequired().HasColumnType("datetime");
            Property(x => x.InstructorId).HasColumnName(@"InstructorID").IsOptional().HasColumnType("int");
            Property(x => x.RowVersion).HasColumnName(@"RowVersion").IsRequired().IsFixedLength().HasColumnType("timestamp").HasMaxLength(8).IsRowVersion().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            // Foreign keys
            HasOptional(a => a.Person).WithMany(b => b.Departments).HasForeignKey(c => c.InstructorId); // FK_dbo.Department_dbo.Instructor_InstructorID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
