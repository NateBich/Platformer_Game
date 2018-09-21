using System;


namespace Platformer_Game
{
    class Gravity_Engine
    {
        private static int gravity = 10;
        private static int airSpeed;

        public static int xSpeed = 0;
        private static int momentum = 10;

        //////////>>    <<\\\\\\\\\\\
        public static int ExcellerateCalculater()
        {
            if (xSpeed <= momentum)
            {
                xSpeed += 3 / 2;
                return xSpeed;
            }
            else
                xSpeed = momentum;
            Console.WriteLine(xSpeed);
            return xSpeed;
        }
        //////////>>    <<\\\\\\\\\\\
        public static int DeExcellerateCalculater()
        {
            if (xSpeed > 0)
            {
                xSpeed -= 3 / 2;
            }
            else
                xSpeed = 0;
            Console.WriteLine(xSpeed);
            return xSpeed;
        }
        //////////>>    <<\\\\\\\\\\\
        public static int InAirMovement()
        {
            if (xSpeed >= 5)
                xSpeed -= 1 / 16;

            else
                xSpeed = 5;
            Console.WriteLine(xSpeed);
            return xSpeed;
        }
        //////////>>    <<\\\\\\\\\\\
        public static int FallingGravity()
        {
            if (airSpeed <= gravity)
            {
                airSpeed++;
                //return airSpeed;
            }
            //else
                return airSpeed;
        }
        //////////>>    <<\\\\\\\\\\\
        public static int JumpGravity()
        {
            if (airSpeed > 0)
                airSpeed--;

            else
                Player_Engine.canJump = false;                

            return airSpeed;
        }
        //////////>>    <<\\\\\\\\\\\
        public static void SetAirSpeed(string direction)
        {
            switch (direction)
            {
                case "Up":
                    airSpeed = gravity + 5;
                    break;
                case "Down":
                    airSpeed = 0;
                    break;
                case "Stop":
                    xSpeed = 0;
                    break;
            }
        }
    }
}
