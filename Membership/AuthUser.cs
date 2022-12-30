namespace Membership;
public static class AuthUser{

public static bool ValidateUser(string email,string pwd)
{
    bool status=false;
    if(email=="asmita.23pawar@gmail.com" && pwd=="hiasmita")
    {
        status=true;
    }
    return status;
}

public static bool RegisterUser(string firstname,string lastname,string mobile,string email,string city)
{
bool status=false;
try
{
User newuser=new User();
newuser.firstname=firstname;
newuser.lastname=lastname;
newuser.mobile=mobile;
newuser.email=email;
newuser.city=city;
status=true;
}    
catch(Exception e)
{
    Console.WriteLine("Registration Failed!! Please try again ");
}

return status;
}


}