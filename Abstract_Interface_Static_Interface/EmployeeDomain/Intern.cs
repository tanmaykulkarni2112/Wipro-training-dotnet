namespace EmployeeDomain;



public class Intern:Employee{

    #region Properties

    private int age;

    public int Age{
        get{return age;}
        set{age = value;}
    } 

    #endregion

    #region constructor

    public Intern(int age, string Name, double Salary ):base(Name,Salary){
        this.Age = age;
    }
    #endregion

    #region Method

    public override bool IsIntern() {
        if (age > 22) {
            return false;
        }
        return true;
    }

    #endregion
}