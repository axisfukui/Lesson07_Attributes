using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LessonTask01_LIB;

namespace LessonTask01
{
    //Part1
    //Создайте библиотеку, в которой:
    //Создайте перечисление LevelOfResponsibility с такими уровнями – Undetermined, Highest, Average, Low.
    //Создайте класс-атрибут OfficerAttribut, работающий только с классами.В теле OfficerAttribut создайте автосвойство Responsibility типа 
    //LevelOfResponsibility.Создайте абстрактный класс Officer.Создайте конкретные классы General, Major, Lieutenant, наследующиеся от 
    //Officer.Декорируйте все созданные классы соответствующими атрибутами. 
    //В другом проекте в методе Main создайте экземпляры всех классов, наследников Officer. Выведите на экран их атрибуты.

    //Part2
    //К коду из первого задания добавьте методы.В подключаемой библиотеке создайте класс-атрибут OfficerManageAttribut, работающий со всеми стереотипами, с именным 
    //параметром Responsibility типа LevelOfResponsibility.
    //В класс Officer добавьте абстрактный метод Manage(), который ничего не возвращает. Реализуйте метод в производных классах.Декорируйте методы атрибутом
    //OfficerManageAttribut. 
    //В методе Main создайте экземпляры всех классов – наследников Officer. Добавьте все эти экземпляры в одну коллекцию.Обратившись к элементам коллекции выведите на
    //экран все атрибуты (классов и методов).

    class Program
    {
        static void Main(string[] args)
        {
            Lieutenant lieutenant = new Lieutenant();
            Major major = new Major();
            General general = new General();

            List<Officer> officers = new List<Officer> { lieutenant, major, general };

            foreach (var officer in officers)
            {
                Type officerType = officer.GetType();//Get Officer Type
                object[] attributes = officerType.GetCustomAttributes(typeof(OfficerAttribut), false); //Boxing officer Attributes
                MethodInfo methodInfo = officerType.GetMethod("Manage"); //Get Officers Method info
                object[] methodAttr = methodInfo.GetCustomAttributes(typeof(OfficerManageAttribut), false); //Boxing Method Attributes
                
                //After unboxing show Officers Attributes
                foreach (OfficerAttribut attribute in attributes)
                {
                    Console.WriteLine($"{officerType.Name} has attribute {attribute.Responsibility}");
                }
                //After unboxing show Officers Method Attributes
                foreach (OfficerManageAttribut manageAttribut in methodAttr)
                {
                    Console.WriteLine($"\t{officerType.Name} Method \"{methodInfo.Name}\" has attribute {manageAttribut.Responsibility}");
                }
            }
        }
    }
}
