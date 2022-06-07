using System;
using System.IO;

namespace APBD11.Data
{
	public class Student
	{
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Studies { get; set; }
        public string AvatarUrl { get; set; }


        public Student()
		{
            AvatarUrl = "https://cdn4.iconfinder.com/data/icons/professions-1-2/151/8-512.png";

        }
	}
}

