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

    // vwDeptCourseCount
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class VwDeptCourseCount
    {
        public int DepartmentId { get; set; } // DepartmentID
        public string Name { get; set; } // Name (length: 50)
        public int? CourseCount { get; set; } // CourseCount
        
        public VwDeptCourseCount()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>