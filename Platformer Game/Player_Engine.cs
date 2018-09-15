using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_Game
{
    class Player_Engine
    {     
        private static bool isGrounded = false;
       // private static int playerSpeed = 10, playerMomentum = 0;        
       
        //<>
        public static PictureBox player;
        public static bool moveLeft = false, moveRight = false, canJump = false;

        public static int playerX, playerY;
        

        public Player_Engine()
        {
            Console.WriteLine("Player Engine has Started!");
        }

        public static void PlayerUpdate()
        {
            player = PlatformerGame_InGame_Form.player;
            playerX = PlatformerGame_InGame_Form.player.Location.X;
            playerY = PlatformerGame_InGame_Form.player.Location.Y;

            PlayerCollisionCheck();
            PlatformerGame_InGame_Form.player.Location = new Point(MovePlayer(playerX), JumpPlayer(playerY));
        }

        private static int JumpPlayer(int y)
        {
            if (isGrounded && canJump)
            {
                Gravity_Engine.SetAirSpeed("Up");
                y -= Gravity_Engine.JumpGravity();
                isGrounded = false;
            }

            else if (!isGrounded && canJump)
                y -= Gravity_Engine.JumpGravity();

            else if (!isGrounded && !canJump)
            {
                y += Gravity_Engine.FallingGravity();
            }
            return y;
        }

        private static int MovePlayer(int x)
        {
            int noChangeX = x;

            if (isGrounded)
            {
                if (moveLeft)
                {
                    x -= Gravity_Engine.MomentumCalculater();                    
                }
                else if (moveRight)
                {
                    x += Gravity_Engine.MomentumCalculater();                    
                }
                else
                {
                    if (Gravity_Engine.MomentumCalculater() > 0)
                    {
                        if (x < noChangeX)
                            x += Gravity_Engine.MomentumCalculater();
                        else if (x > noChangeX)
                            x -= Gravity_Engine.MomentumCalculater();                      
                    }
                    else
                    {
                        Gravity_Engine.SetAirSpeed("Stop");
                    }
                    Console.WriteLine(Gravity_Engine.MomentumCalculater());
                }
            }
            else
            {
                if (moveLeft)
                {
                    x -= Gravity_Engine.MomentumCalculater();
                }
                else if (moveRight)
                {
                    x += Gravity_Engine.MomentumCalculater();
                }
            }
            return x;
        }

        public static bool IsGrounded()
        {
            return isGrounded;
        }

        private static void PlayerCollisionCheck()
        {
            if (!isGrounded)
            {
                if (Collision_Engine.CollisionCheck(PlatformerGame_InGame_Form.player, PlatformerGame_InGame_Form.ground))
                {
                    isGrounded = true;

                    moveLeft = false;

                    moveRight = false;

                }
            }
            else if (!Collision_Engine.CollisionCheck(PlatformerGame_InGame_Form.player, PlatformerGame_InGame_Form.ground))
                isGrounded = false;
            else
                return;
        }
    }
}
