namespace LinQ_Console
{
    public class Employee { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee { Id = 1,Name="Yaswa",Dept="Automobile",},
                new Employee { Id = 2,Name="Varun",Dept="Maths",},
                new Employee { Id = 3,Name="Bhupesh",Dept="CSE",},
                new Employee { Id = 4,Name="Saran",Dept="CSE",}
            };

            var query = list.Where(emp =>
            {
                return emp.Id == 2 || emp.Dept=="CSE";
            }
            );
            foreach(var emp in query)
            {
               // Console.WriteLine( emp.Name ); 
            }
            

            List<object> objList = new List<object>()
            {
                1,"one",2,"two","abc"
            };

            //var objQuery = objList.OfType<string>().ToList();

            //var objQuery = (from a in objList where a is int select a).ToList();

            var objQuery = (from a in objList 
                            where a is string 
                            orderby a ascending 
                            select a).ToList();

            foreach(var obj in objQuery)
            {
                Console.WriteLine( obj );
            }

        }
    }
}