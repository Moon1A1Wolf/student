using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private string lastName;
    private string firstName;
    private string middleName;

    private DateTime dateOfBirth;

    private Address homeAddress;
    
    private string phoneNumber;
    
    private List<int> gradesForTests;
    private List<int> gradesForHomeworks;
    private List<int> gradesForExams;

    public Student(string lastName, string firstName, string middleName, DateTime dateOfBirth,
                   Address homeAddress, string phoneNumber)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.dateOfBirth = dateOfBirth;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.gradesForTests = new List<int>();
        this.gradesForHomeworks = new List<int>();
        this.gradesForExams = new List<int>();
    }

    public Student(string lastName, string firstName, string middleName, DateTime dateOfBirth,
                   Address homeAddress, string phoneNumber,
                   List<int> gradesForTests, List<int> gradesForHomeworks, List<int> gradesForExams)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.dateOfBirth = dateOfBirth;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.gradesForTests = gradesForTests;
        this.gradesForHomeworks = gradesForHomeworks;
        this.gradesForExams = gradesForExams;
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string MiddleName
    {
        get { return middleName; }
        set { middleName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public Address HomeAddress
    {
        get { return homeAddress; }
        set { homeAddress = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public List<int> GradesForTests
    {
        get { return gradesForTests; }
        set { gradesForTests = value; }
    }

    public List<int> GradesForHomeworks
    {
        get { return gradesForHomeworks; }
        set { gradesForHomeworks = value; }
    }

    public List<int> GradesForExams
    {
        get { return gradesForExams; }
        set { gradesForExams = value; }
    }

    public string ToString()
    {
        return $"Name: {LastName} {FirstName} {MiddleName}\n" +
               $"Date of Birth: {DateOfBirth}\n" +
               $"Home Address: {HomeAddress.ToString()}\n" +
               $"Phone Number: {PhoneNumber}\n" +
               $"Grades for Tests: {string.Join(", ", GradesForTests)}\n" +
               $"Grades for Homeworks: {string.Join(", ", GradesForHomeworks)}\n" +
               $"Grades for Exams: {string.Join(", ", GradesForExams)}\n";
    }


    static void Main()
    {
        Address address = new Address("Украина", "Одесса", "Космонавтов", 56, 49);

        Student student = new Student("Голикова", "Анастасия", "Павловна", new DateTime(2005, 12, 15), address, "+380 xxx xxxx");

        student.GradesForTests = new List<int> { 10, 9, 11 };
        student.GradesForHomeworks = new List<int> { 9, 8, 10 };
        student.GradesForExams = new List<int> { 10, 9, 10 };

        Console.WriteLine(student.ToString());
    }
}

public class Address
{
    private string country;
    private string city;
    private string street;
    private int houseNumber;
    private int apartmentNumber;

    public Address(string country, string city, string street, int houseNumber, int apartmentNumber)
    {
        this.country = country;
        this.city = city;
        this.street = street;
        this.houseNumber = houseNumber;
        this.apartmentNumber = apartmentNumber;
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public int HouseNumber
    {
        get { return houseNumber; }
        set { houseNumber = value; }
    }

    public int ApartmentNumber
    {
        get { return apartmentNumber; }
        set { apartmentNumber = value; }
    }

    public override string ToString()
    {
        return $"{Country}, {City}, {Street}, {HouseNumber}, {ApartmentNumber}";
    }
}
