using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_Game
{
    public partial class PlatformerGame_InGame_Form : Form
    {
        public static PictureBox player;
        public static PictureBox ground;

        public PlatformerGame_InGame_Form()
        {            
            InitializeComponent();
            player = Player_PictureBox;
            ground = Ground_PictureBox1;
            
            Game_Update_Timer.Start();
            
        }

        private void Game_Update_Timer_Tick(object sender, EventArgs e)
        {
            if (player.Location != Player_PictureBox.Location)
                player.Location = Player_PictureBox.Location;
            //ground = Ground_PictureBox1;

            Player_Engine.PlayerUpdate();

            Player_PictureBox.Location = new Point(player.Location.X, player.Location.Y);
        }

        private void PlayerMovement_KeysDown(object sender, KeyEventArgs e)
        {

            if (Player_Engine.IsGrounded())
            {
                if (e.KeyData == Keys.A)
                {
                    Player_Engine.moveLeft = true;                    
                }

                else if (e.KeyData == Keys.A && e.KeyData == Keys.Space)
                {
                    Player_Engine.moveLeft = true;
                    Player_Engine.canJump = true;                    
                }

                else if (e.KeyData == Keys.D)                
                    Player_Engine.moveRight = true;
                                   
                else if (e.KeyData == Keys.D && e.KeyData == Keys.Space)
                {
                    Player_Engine.moveRight = true;
                    Player_Engine.canJump = true;
                }

                else if (e.KeyData == Keys.Space)
                    Player_Engine.canJump = true;
                
            }
        }

        private void PlayerMovement_KeysUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    if (Player_Engine.IsGrounded())
                        Player_Engine.moveLeft = false;
                    else
                        Player_Engine.moveLeft = true;
                    break;

                case Keys.D:
                    if (Player_Engine.IsGrounded())
                        Player_Engine.moveRight = false;
                    else
                        Player_Engine.moveRight = true;
                    break;

                case Keys.Space:
                    //Player_Engine.canJump = false;
                    break;
            }
        }
    }
}
