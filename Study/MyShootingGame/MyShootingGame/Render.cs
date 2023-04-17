using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public class Render
    {
        public int imageX;
        public int imageY;
        public Image image;
        public int layer;
        
        public virtual void MoveImage()
        {

        }
    }
    //  sortedSet에 넣기 위해 컴패어 사용
    // 중복값은 layer을 통해 구분한다.
    class RenderCompare : IComparer<Render>
    {
        public int Compare(Render x, Render y)
        {
            int result = x.layer.CompareTo(y.layer);
            return result;
        }
    }

}
