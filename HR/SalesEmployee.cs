namespace HR;
public class SalesEmployee:Employee
{
public float target{get;set;}
public float salesDone{get;set;}
public float incentive{get;set;}

public SalesEmployee():base()
{
    this.target=0;
    this.salesDone=0;
    this.incentive=0;
}

public SalesEmployee(int id,string fname,string lname,string contact,string location,DateTime dob,float da,float hra,float basicsal,
float target,float salesDone):base(id,fname,lname,contact,location,dob,da,hra,basicsal)
{
    this.target=target;
    this.salesDone=salesDone;
    this.incentive=0;
}

public override void DoWork()
{
 if(salesDone>=target)
 {
    this.incentive=8000;
 }
 else{
    this.incentive=0;
 }
}

public override float ComputePay()
{
    float salary=base.ComputePay()+incentive;
    return salary;

}

public override string ToString()
{
    return base.ToString()+"\n Incentives earned= "+incentive +"For completing target of Rs."+target;
}
}


