using System.Windows.Forms;

namespace Platformer_Game
{
    class Gravity_Engine
    {
        private static int gravity = 10;
        private static int airSpeed;

        public static int FallingGravity(PictureBox obj)
        {
            if (airSpeed <= gravity)
            {
                airSpeed++;
                return airSpeed;
            }
            else
                return airSpeed;
        }

        public static int JumpGravity(PictureBox obj)
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

        }
        }
    }
}
