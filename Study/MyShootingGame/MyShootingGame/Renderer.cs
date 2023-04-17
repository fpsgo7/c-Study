using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    /// <summary>
    /// 이미지 대상의 정보를 받아 레이어를 씌워준다.
    /// </summary>
    public static class Renderer 
    {
        public static SortedSet<Render> renders = new SortedSet<Render>(new RenderCompare());
        private static int layer =0;
        public static void AddRenders(Render render)
        {
            render.layer = layer;
            layer++;
            renders.Add(render);
        }
    }
   
}
