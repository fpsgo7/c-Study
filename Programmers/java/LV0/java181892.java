package Programmers.java.LV0;

import java.util.*;

public class java181892 
{

    public static void main( String[] args )
    {
        Solution solution = new Solution();
        int[] num_list = {2,1,6};
        int n = 3;
        //System.out.println(solution.solution(num_list));
        // 배열출력일떄 사용
        System.out.println(Arrays.toString(solution.solution(num_list,n)));
        //solution.solutionActive();
    }
}

class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] list = null;
        int listLength = num_list.length - n;
        list = new int[listLength];

        list = Arrays.copyOfRange(num_list, n-1 , num_list.length);

        return list;
        
    }
    public void solutionActive(){
 
    }
}