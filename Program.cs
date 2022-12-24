Print print =new Print();

print.Charge();

interface IRobot
{   
    public string GetInfo(string info)
    {
        return info;
    }
    public  List<string>  GetComponents(List<string>  comp)
    {
        return comp;
    }
    public string GetRobotType(string Types)
    {
        Types ="I am a simple robot.";
        return Types;
    }
}

interface IChargeable
{
    public void Charge(){

    }
    public string GetInfo(string info){
        return info;
    }

}
interface IFlyingRobot :IRobot
{
    string IRobot.GetRobotType(string Types)
    {
        Types ="I am a flying robot.";
        return Types;
    }
}
class Quadcopter :IFlyingRobot,IChargeable
{
    public List<string> List_components=new List<string>{"rotor1","rotor2","rotor3","rotor4"};
    List<string> GetComponents(List<string> List_components){
        return List_components;
    }

}
class Print:IChargeable
{
    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged");
    }
}