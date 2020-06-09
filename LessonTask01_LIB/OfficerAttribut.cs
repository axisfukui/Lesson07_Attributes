using System;

namespace LessonTask01_LIB
{
    public enum LevelOfResponsibility
    {
        Undetermined,
        Highest,
        Average,
        Low
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class OfficerAttribut : Attribute
    {
        public LevelOfResponsibility Responsibility { get; set; }
    }
    [AttributeUsage(AttributeTargets.All)]
    public class OfficerManageAttribut : Attribute
    {
        public LevelOfResponsibility Responsibility { get; set; }
    }
}
