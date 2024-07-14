using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace assignment3
{
    internal class person

    {
        public string Fristname;
        public string lastname;
        public string Emailaddress;
        public DataType Dateofbrith;


        public person(string fristname, string lastname, string Emaliaddress)
        {
            this.Fristname = fristname;
            this.lastname = lastname;
            this.Emailaddress = Emaliaddress;

            Console.WriteLine($"details : {fristname}, {lastname}, {Emaliaddress}");
        }

       public person(string fristname, string lastname, DateTime Dateofbrith)
        {
            this.Fristname = fristname;
            this.lastname = lastname;
            this.Dateofbrith = DataType.Date;
            Console.WriteLine($"details : {fristname}, {lastname}, {Dateofbrith}");
        }
        public static void Main()
        {
            person p = new person("sudheer", "varma", DateTime.Parse("05-09-2000"));
            person p1= new person("sudheer", "varma", " sudheervarma987654@gmali.com");

        }


    }



}



