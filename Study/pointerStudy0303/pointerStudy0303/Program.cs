using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointerStudy0303
{
    class Test
    {
       public int b =10;// 전역 변수로 힙 영역에 저장된다.
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int a = 10;// 지역변수로 스텍에 들어간다.
            Test test = new Test();// test 객체는 힙영역으로 들어간다.
            Console.WriteLine(a + " " +test.b.ToString()); // 10 과 10
            // Ref 사용하는 경우
            ChangeRef(ref a,ref test);
            Console.WriteLine(a + " " + test.b.ToString());//11 과 11
            // 위결과 값 초기화
            a = 10;
            test.b = 10;
            // Ref 사용안하는 경우
            Change(a, test);
            Console.WriteLine(a + " " + test.b.ToString());// 10  과 11
        }
        /// <summary>
        /// Change의 스택에는
        /// a2 와 test2가 저장된다.
        /// a2는 Change 스택에서 자신의 주소를 가지지만
        /// test2 는 값이아닌 힙영역에 있는 test 클래스의 주소를 가져
        /// a2를 더하고 빼도 Main의 스택에있는 a 변수에 영향을
        /// 주지는 않지만 test2 의 b값변화는 힙영역의 test 클래스의 b변수에 
        /// 값변화를 줘 Main 스택또한 test의 주소로 힙영역의 test의 값을 가져오는 
        /// 형식이기때문에 test2로 변환된 값이 적용된다.
        /// </summary>

        static void Change(int a2, Test test2)
        {
            
            a2 += 1;
            test2.b += 1;
            
        }
        /// <summary>
        /// ref 레퍼런스 형식으로 했을영우에는
        /// a2 같은 경우 ChangeRef 함수의 스텍에서 
        /// 저장되지만 값이 아닌 Main 함수의 스텍의 a 의 주소가 
        /// 저장된다. 그래서 a2는 Main 함수의 a를 가리키게되어
        /// a2 값이 변하면 a의 값도 같이 변하게된다.
        /// 그리고 test2는 Main의 test를 참조하지만 
        /// Main 또한 힙영역의 test를 참조 하기 때문에 
        /// 결국 test2 는 힙영역의 test를 참조하게 되어
        /// 결과적으로 ChangeRef의 함수 실행으로 
        /// Main의 a 와 
        /// 힙의 test 의 b 의 값은 변하게된다.
        /// </summary>

        static void ChangeRef(ref int a2,ref Test test2)
        {

            a2 += 1;
            test2.b += 1;

        }
    }
    
}
