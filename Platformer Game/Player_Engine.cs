using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_Game
{
    class Player_Engine
    {     
        private static bool isGrounded = false;
        private static int playerSpeed = 10, playerMomentum = 0;        
       
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

            MovePlayer(playerX);

            if (isGrounded && canJump)
            {
                Gravity_Engine.SetAirSpeed("Up");
                playerY -= Gravity_Engine.JumpGravity(player);
                isGrounded = false;
            }

            if (!isGrounded && canJump)
                playerY -= Gravity_Engine.JumpGravity(player);

            if (!isGrounded && !canJump)
            {                
                playerY += Gravity_Engine.FallingGravity(player);                
            }

            PlayerCollisionCheck();

            PlatformerGame_InGame_Form.player.Location = new Point(playerX, playerY);
        }

        //private static void 
        private static void PlayerCollisionCheck()
        {
            if (!isGrounded)
            {
                if (Collision_Engine.CollisionCheck(PlatformerGame_InGame_Form.player, PlatformerGame_InGame_Form.ground))
                {
                    isGrounded = true;
                }
            }
            else
                return;            
        }

        private static void MovePlayer(int x)
        {
            int noChangeX = x;
            if (moveLeft)
            {                
                if (playerMomentum <= playerSpeed)
                {
                    playerMomentum++;
                }

                x -= playerMomentum;                
            }
            else if (moveRight)
            {
                if (playerMomentum <= playerSpeed)
                {
                    playerMomentum++;
                }
                x += playerMomentum;
            }
            else
            {
                if (playerMomentum > 0)
                {
                    playerMomentum--;

                    if (noChangeX > x)
                        x -= playerMomentum;
                    else //if (noChangeX < x)
                        x += -playerMomentum;
                }
               
            }

            playerX = x;

            }

        public static bool IsGrounded()
        {
            return isGrounded;
        }


    }
}
