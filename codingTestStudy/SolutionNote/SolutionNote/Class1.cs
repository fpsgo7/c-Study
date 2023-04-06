using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionNote
{
    //출력 참고용
    class Class1
    {
        //읽어 오기
        StreamReader reader = 
            new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        //쓰기
        StreamWriter writer = 
            new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    }
}
