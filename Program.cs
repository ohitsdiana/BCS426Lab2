/* Lab 2 Questions 1 & 2
 * 
 * Diana Guerrero
 * Professor Aydin
 * BCS 426 
 * 2/17/21
 * 
 * Partner(s): Patrick Adams
 * Resource(s): 
 * 1. https://blog.aspose.com/2020/01/08/csharp-word-automation-create-edit-process-word-documents/
 * 2. https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
 */

using System;

namespace BCS426Lab2
{
   /* public class Document
    {
        // Name (string) Property
        private string Name;

        // NumberOfPages (int) Property 
        private int NumberOfPages;

        // CreatedOn (DateTime) Readonly Property
        private readonly DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get => _CreatedOn;
        }

        // Getters & Setters for Name
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        // Getters & Setters for NumberOfPages
        public int numberOfPages
        {
            get
            {
                return NumberOfPages;
            }
            set
            {
                NumberOfPages = value;
            }
        }

        // CreatedOn is a readonly property so only a getter
        public DateTime createdOn
        {
            get
            {
                return CreatedOn;
            }
        }

        // Contructor to allow initialization of the 3 values name, numberOfPages, and createdOn
        public Document(string name, int numberOfPages)
        {
            Name = name;
            NumberOfPages = numberOfPages;

            // DateTime CreatedOn Struct (giving me an error in the line below line 74)
            //createdOn = new DateTime();
        }

        // ToString Method
        public override string ToString()
        {
            return "Name: " + Name + "\nNumber of Pages: " + NumberOfPages + "\nCreated On: " + CreatedOn;
        }

        static void Main()
        {
            // Create Document 1 with name "PhoneNumbers.txt" & 3 pages
            Document Document1 = new Document("PhoneNumbers.txt", 3 );
            Console.WriteLine(Document1.ToString());

            // Create Document 2 wit name "Report.docx" & 30 pages
            Document Document2 = new Document("Report.docx", 30);
            Console.WriteLine(Document2.ToString());

            // Demo Can't Change the CreatedOn Property on Document1 (Errors with line 94 because it's readonly)
            //Document1.CreatedOn = new DateTime();

            // Demo Can't Change the CreatedOn Property on Document2 (Errors with line 97 because it's readonly)
            //Document2.CreatedOn = new DateTime();
        }
    } */

    public class Employee
    {
        // Static Constructor to initialize random number 1-9999
        static Random randomID = new Random();
        private static int nextAvailableID = randomID.Next(1,9999);

        // First Name Field
        private string firstName;

        // Last Name Field
        private string lastName;

        // Readonly Int ID
        private readonly int _ID;
        public int ID
        {
            get => _ID;
        }

        // Getter & Setter for First Name
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // Getter & Setter for Last Name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Constructor to allow setting properties first name and last name
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            //Readonly giving me an error in the line below line 154)
            //ID = Employee.nextAvailableID++;
        }

        // ToString Method
        public override string ToString()
        {
            return "Employee is " + firstName + " " + lastName + " " + ID;
        }

        static void Main()
        {
            // Create 4 Employee Objects w/ References e1, e2, e3 by providing first and last name of each employee
            // Display full name & id of each employee
            Employee e1 = new Employee("Diana", "Guerrero");
            Employee e2 = new Employee("Dylan", "O'Brien");
            Employee e3 = new Employee("Logan", "Lerman");

            Console.WriteLine("1st " + e1);
            Console.WriteLine("2nd " + e2);
            Console.WriteLine("3rd " + e3);
        }
    }
}