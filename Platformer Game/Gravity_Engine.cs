using System.Windows.Forms;

namespace Platformer_Game
{
    class Gravity_Engine
    {
        private static int gravity = 10;
        private static int airSpeed;

        private static int xSpeed = 0;
        private static int momentum = 10;


        public static int MomentumCalculater()
        {
            if (xSpeed <= momentum)
            {
                xSpeed++;
                return xSpeed;
            }
            else
                return xSpeed;
        }
        public static int FallingGravity()
        {
            if (airSpeed <= gravity)
            {
                airSpeed++;
                return airSpeed;
            }
            else
                return airSpeed;
        }

        public static int JumpGravity()
        {

            if (airSpeed > 0)
            {
                airSpeed -= 1;
                return airSpeed;
            }
            else
            {
                Player_Engine.canJump = false;                
                return airSpeed;
            }
        }

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
