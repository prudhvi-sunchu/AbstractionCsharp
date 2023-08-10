namespace AbstractionDemoinCsharp
{
    class Enduser
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.TurnOffCar();
            obj.TurnOnCar();
        }
    }

    public class Car
    {
        public void TurnOnCar()
        {
            Console.WriteLine("turn on the manual car");
        }
        public void TurnOffCar()
        {
            Console.WriteLine("turn off the manual car");
        }
        private void Change_Pistion_Speed()  //not required we are making it as private,so this is called as abstraction
        {
            Console.WriteLine("Change_piston_Speed Implementation");
        }
        private void Move_Break_Pads()   //not required we are making it as private, so this is called as abstraction
        {
            Console.WriteLine("Move_Break_Pads Implementation");
        }
    }
}

/*
 
What is Abstraction?
Abstraction is the concept of object-oriented
programming that "shows" only essential attributes
and "hides" unnecessary information.

 * Abstraction in OOPS
 
Objects are the building blocks of Object-Oriented Progaramming.An Object
contains some properties and methods. we can hide them from the outer
world through access modifiers. We can provide access only for required
functions and properties to the other programs. This is the general
procedure to implement abstraction in OOPS.

*/