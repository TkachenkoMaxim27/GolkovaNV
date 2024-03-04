using Robot;
namespace ConsoleRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot.RobotMove robot = new Robot.RobotMove("Робот 1", 2, 0);
            Robot.RobotMove robot2 = new Robot.RobotMove("Робот 2", 0, 1);
            Robot.RobotMove robot3 = new Robot.RobotMove("Робот 3", 1, 3);



            for (int i = 0; i <= 5; i++)
            {
                robot.Move();
                robot2.Move();
                robot3.Move();
                Console.WriteLine(robot.GetInfo());
                Console.WriteLine(robot2.GetInfo());
                Console.WriteLine(robot3.GetInfo());
                Console.WriteLine("ПОТОК ЗАВЕРШЕН");
                Thread.Sleep(2000);
            }


        }
    }
}