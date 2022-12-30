namespace HR;

public class SalesManager:SalesEmployee{
public float bonus{get;set;}
public SalesManager():base()
{
    bonus=0;
}
public SalesManager(int id,string fname,string lname,string contact,string location,DateTime dob,float da,float hra,float basicsal,
float target,float salesDone,float bonus):base(id,fname,lname,contact,location,dob,da,hra,basicsal,target,salesDone)
{
    this.bonus=bonus;
}

public override void DoWork()
{
    base.DoWork();
}

public override float ComputePay()
{
    return base.ComputePay()+bonus;
}

public override string ToString()
{
    return base.ToString+"Bonus earned: "+bonus;
}

}
