/*Create a reference type called Person. Populate the Personclass with the following properties to store the
 * following information:
   First name 
   Last name 
   Email address 
   Date of birth 
   Add constructors that accept the following parameter lists:
   All four parameters First, Last, Email First, Last, Date of birthAdd read-only properties that return the following computed information:Adult -whether or not the person is over 18 Sun sign -the traditional western sun sign of this person Chinese sign -the chinese astrological sign (animal) of this person Birthday -whether or not today is the person's birthday Screen name -a default screen name that you might see 
 * being offered to a first time user of AOL or Yahoo (e.g. John Doe born on Feburary 25th, 1980 might be jdoe225or johndoe022580)*/

using System;

namespace mock_test
{
    class Person
    {
        /*class to enter details of person*/

	private String FirstName;
        private string LastName;
        private string Email;
        private DateTime Dob;

        /*returns first name*/
        public string SetfirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;


            }

        }

        /*returns last name*/
        public string SetLastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;


            }


        }

        /*setting email*/
        public string email
        {
           
            set

            {
                Email = value;

                // make sure there's just one @ in it:
                string[] items = value.Split('@'); 
                if (items.Length != 2) 
                {
                    throw new ArgumentException("Invalid email address");
                }
               
            }
        }
        /*set date of birth*/

        public DateTime SetDob
        {


            set
            {
                Dob = value;


            }


        }


        public Person(String First, String Last, String email, DateTime DOfB)
        {
            FirstName = First;
            LastName = Last;
            Email = email;
            Dob = DOfB;
        }


        public Person(String First, String Last, String email)
        {
            FirstName = First;
            LastName = Last;
            Email = email;


        }
        public Person(String First, String Last, DateTime DOfB)
        {
            FirstName = First;
            LastName = Last;
            Dob = DOfB;
        }

        /* to calculate age*/
        public int age(DateTime DOB)
        {
          
            TimeSpan ts = DateTime.Now.Subtract(DOB);
            int years = ts.Days / 365;
            return years;


        }

        /*to find zodiac sign*/
        public string Zodiac(DateTime DateOfBirth)
        {
            string returnString = string.Empty;
            string[] dateAndMonth = DateOfBirth.ToLongDateString().Split(new char[] { ',' });
            string[] ckhString = dateAndMonth[1].ToString().Split(new char[] { ' ' });
            if (ckhString[1].ToString() == "March")
            {
                if (Convert.ToInt32(ckhString[2]) <= 20) { returnString = "Pisces"; } else { returnString = "Aries"; }
            }
            else if (ckhString[1].ToString() == "April") { if (Convert.ToInt32(ckhString[2]) <= 19) { returnString = "Aries"; } else { returnString = "Taurus"; } } else if (ckhString[1].ToString() == "May") { if (Convert.ToInt32(ckhString[2]) <= 20) { returnString = "Taurus"; } else { returnString = "Gemini"; } } else if (ckhString[1].ToString() == "June") { if (Convert.ToInt32(ckhString[2]) <= 20) { returnString = "Gemini"; } else { returnString = "Cancer"; } } else if (ckhString[1].ToString() == "July") { if (Convert.ToInt32(ckhString[2]) <= 22) { returnString = "Cancer"; } else { returnString = "Leo"; } } else if (ckhString[1].ToString() == "August") { if (Convert.ToInt32(ckhString[2]) <= 22) { returnString = "Leo"; } else { returnString = "Virgo"; } } else if (ckhString[1].ToString() == "September") { if (Convert.ToInt32(ckhString[2]) <= 22) { returnString = "Virgo"; } else { returnString = "Libra"; } } else if (ckhString[1].ToString() == "October") { if (Convert.ToInt32(ckhString[2]) <= 22) { returnString = "Libra"; } else { returnString = "Scorpio"; } } else if (ckhString[1].ToString() == "November") { if (Convert.ToInt32(ckhString[2]) <= 21) { returnString = "Scorpio"; } else { returnString = "Sagittarius"; } } else if (ckhString[1].ToString() == "December") { if (Convert.ToInt32(ckhString[2]) <= 21) { returnString = "Sagittarius"; } else { returnString = "Capricorn"; } } else if (ckhString[1].ToString() == "January") { if (Convert.ToInt32(ckhString[2]) <= 19) { returnString = "Capricorn"; } else { returnString = "Aquarius"; } } else if (ckhString[1].ToString() == "February") { if (Convert.ToInt32(ckhString[2]) <= 18) { returnString = "Aquarius"; } else { returnString = "Pisces"; } }
            return returnString;
        }

        /*to check if person is adult*/
        public bool IsAdult
        {
            get
            {
                if (age(this.Dob) >= 18)
                {


                    return true;
                }
                else
                {


                    return false;
                }


            }
        }

        /*to check birthday is today*/
        public bool isBirthdayToday
        {
            get
            {
                if ((this.Dob.Day == DateTime.Now.Day) && (this.Dob.Month == DateTime.Now.Month))
                {


                    return true;


                }
                else
                {


                    return false;
                }
            }
        }



        /*to get sun sign*/
        public string GetSunSign
        {
            get
            {
                return (Zodiac(this.Dob));


            }
        }
    }

    /*to diplay if person is adult*/
    class Program
    {
        private String getAdultString(Person obj)
        {
            if (obj.IsAdult)
            {


                return obj.SetfirstName  + " "+obj.SetLastName + "  Is Adult";
            }


            else
            {
                return obj.SetfirstName + " " + obj.SetLastName +  "  Is not Adult";


            }


        }



        /* to display if person birthday is today*/
        private String getBdayString(Person obj)
        {
            if (obj.isBirthdayToday)
            {


                return "Today Is   " + obj.SetfirstName + " " + obj.SetLastName+"'s Birthdayday";
            }


            else
            {
                return "Today Is not " + obj.SetfirstName + " " + obj.SetLastName+ "'s Birthdayday";


            }


        }

        /*to display sun sign of person*/
        private String getSunSignString(Person obj)
        {
            return obj.SetfirstName + " " + obj.SetLastName+  "'s Sun sign is " + obj.GetSunSign;


        }
        class Test
        {
            static void Main()
            {
                Console.WriteLine("Enter details for a person in code itself\n");
                
               
               Program objProgram = new Program(); 

                /*enter information of person here*/

                Person m = new Person("Vani", "Desai", new DateTime(2000, 03, 17));
               
                Console.WriteLine(objProgram.getAdultString(m));
                Console.WriteLine(objProgram.getBdayString(m));
                Console.WriteLine(objProgram.getSunSignString(m));
                Console.WriteLine();
              

            }
        }
    }
}