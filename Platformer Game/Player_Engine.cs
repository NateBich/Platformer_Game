using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_Game
{
    class Player_Engine
    {     
        private static bool isGrounded = false;             
       
        //<>
        public static PictureBox player;
        public static bool moveLeft = false, moveRight = false, canJump = false;

        public static int playerX, playerY;

        //////////>>    <<\\\\\\\\\\\
        public Player_Engine()
        {
            Console.WriteLine("Player Engine has Started!");
        }
        //////////>>    <<\\\\\\\\\\\
        public static void PlayerUpdate()
        {
            player = PlatformerGame_InGame_Form.player;
            playerX = PlatformerGame_InGame_Form.player.Location.X;
            playerY = PlatformerGame_InGame_Form.player.Location.Y;

            PlayerCollisionCheck();
            PlatformerGame_InGame_Form.player.Location = new Point(MovePlayer(Convert.ToInt32(playerX)), JumpPlayer(playerY));
        }
        //////////>>    <<\\\\\\\\\\\
        private static int JumpPlayer(int y)
        {
            if (isGrounded && canJump)
            {
                Gravity_Engine.SetAirSpeed("Up");
                y -= Gravity_Engine.JumpGravity();
                isGrounded = false;
            }
            //////////>>    <<\\\\\\\\\\\
            else if (!isGrounded && canJump)
                y -= Gravity_Engine.JumpGravity();
            //////////>>    <<\\\\\\\\\\\
            else if (!isGrounded && !canJump)
            {
                y += Gravity_Engine.FallingGravity();
            }
            return y;
        }
        //////////>>    <<\\\\\\\\\\\
        private static int MovePlayer(int x)
        {
            float noChangeX = x;
            //////////>>    <<\\\\\\\\\\\
            if (isGrounded)
            {
                if (moveLeft)
                    x -= Gravity_Engine.ExcellerateCalculater();

                else if (moveRight)
                    x += Gravity_Engine.ExcellerateCalculater();                    
                //////////>>    <<\\\\\\\\\\\
                else
                {
                    if (Gravity_Engine.xSpeed >= 0)
                    {
                        if (x < noChangeX)
                            x += Gravity_Engine.DeExcellerateCalculater();
                        else if (x > noChangeX)
                            x -= Gravity_Engine.DeExcellerateCalculater();
                    }

                    else
                    {
                        x = 0;
                        Gravity_Engine.SetAirSpeed("Stop");
                    }
                }
            }
            //////////>>    <<\\\\\\\\\\\
            else
            {
                if (moveLeft)
                    x -= Gravity_Engine.InAirMovement();

                else if (moveRight)
                    x += Gravity_Engine.InAirMovement();

                else
                {
                    if (x < noChangeX)
                        x += Gravity_Engine.InAirMovement();
                    else if (x > noChangeX)
                        x -= Gravity_Engine.InAirMovement();
                }                   
            }
            //////////>>    <<\\\\\\\\\\\
            return x;
        }
        //////////>>    <<\\\\\\\\\\\
        public static bool IsGrounded()
        {
            return isGrounded;
        }
        //////////>>    <<\\\\\\\\\\\
        public static bool CanJump()
        {
            return canJump;
        }
        //////////>>    <<\\\\\\\\\\\
        private static void PlayerCollisionCheck()
        {
            if (Collision_Engine.CollisionCheck(PlatformerGame_InGame_Form.player, PlatformerGame_InGame_Form.ground))
            {
                if (!isGrounded)
                {
                    isGrounded = true;
                    canJump = false;
                    moveLeft = false;
                    moveRight = false;
                }
                else
                    return;
            }
            //////////>>    <<\\\\\\\\\\\
            else
                return;
        }
    }
}
