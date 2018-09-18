using System.Windows.Forms;

namespace Platformer_Game
{
    class Collision_Engine
    {

        public static bool CollisionCheck(PictureBox obj1, PictureBox obj2)
        {
            if (obj1.Bounds.IntersectsWith(obj2.Bounds))
                return true;
            else
                return false;
        }
    }
}
