using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask01_LIB
{
    public abstract class Officer
    {
        public abstract void Manage();
    }

    [OfficerAttribut(Responsibility = LevelOfResponsibility.Highest)]
    public class General : Officer
    {
        [OfficerManageAttribut(Responsibility = LevelOfResponsibility.Highest)]
        public override void Manage()
        {
            throw new System.NotImplementedException();
        }
    }

    [OfficerAttribut(Responsibility = LevelOfResponsibility.Average)]
    public class Major : Officer
    {
        [OfficerManageAttribut(Responsibility = LevelOfResponsibility.Average)]
        public override void Manage()
        {
            throw new System.NotImplementedException();
        }
    }

    [OfficerAttribut(Responsibility = LevelOfResponsibility.Low)]
    public class Lieutenant : Officer
    {
        [OfficerManageAttribut(Responsibility = LevelOfResponsibility.Low)]
        public override void Manage()
        {
            throw new System.NotImplementedException();
        }
    }
}
