using System.Drawing;
using System.Windows.Forms;

namespace Platformer_Game
{
    class Collision_Engine
    {
        //////////>>    <<\\\\\\\\\\\
        public static bool CollisionCheck(PictureBox obj1, PictureBox obj2)
        {
            Rectangle object1 = obj1.ClientRectangle;
            object1.Offset(obj1.Location);

            Rectangle object2 = obj2.ClientRectangle;
            object2.Offset(obj2.Location);

            if (obj1.Bounds.IntersectsWith(obj2.Bounds))
                return true;
            else
                return false;
        }
    }
}
