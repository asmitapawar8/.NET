namespace HR;
public abstract class Employee{
    public int id{get;set;}
    public string firstName{get;set;}
    public string lastName{get;set;}
    public string contactNo{get;set;}
    public string location{get;set;}
    public DateTime birthDate{get;set;}
    public float DA{get;set;}
    public float HRA{get;set;}
    public float basicSal{get;set;}

    public Employee():this(10,"Asmita","Pawar","9004677910","Pune",new DateTime(1998,7,18),5000,6000,25000)
    {

    }
    public Employee(int id,string fname,string lname,string contact,string location,DateTime dob,float da,float hra,float basicsal)
    {
        this.id=id;
        this.firstName=fname;
        this.lastName=lname;
        this.location=location;
        this.birthDate=dob;
        this.DA=da;
        this.HRA=hra;
        this.basicSal=basicsal;
    }
    public abstract void DoWork();
    public virtual float ComputePay()
    {
        float pay=(DA*25)+basicSal+HRA;
        return pay;
    }
    public override string ToString()
    {
        string str=string.Format("{0},{1},{2},{3},{4}",id,firstName,lastName,location,birthDate);
        return str;
        //return base.ToString();
    }
}