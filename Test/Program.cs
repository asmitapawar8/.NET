using Membership;
using HR;
 
 Console.WriteLine("---Amazon---");
Console.WriteLine("Welcome to Amazon!!");
Console.WriteLine("Email:  ");
string email=Console.ReadLine();
Console.WriteLine("Password:  ");
string pwd=Console.ReadLine();

if(AuthUser.ValidateUser(email,pwd))
{
Console.WriteLine("Welcome to your Amazon Store!!");
Console.WriteLine("Give complete details:int id,string fname,string lname,string contact,string location,DateTime dob,float da,float hra,float basicsal,float target,float salesDone ");
Employee emp=new SalesEmployee(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),DateTime.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()));
emp.DoWork();
Console.WriteLine(emp);
float salary=emp.ComputePay();
Console.WriteLine("Salary earned: "+salary);

}
else{
     Console.WriteLine("Invalid User");
}

Console.WriteLine("Thank you for visiting Amazon");