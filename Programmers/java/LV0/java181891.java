package Programmers.java.LV0;

import java.util.*;

public class java181891
{

    public static void main( String[] args )
    {
        Solution solution = new Solution();
        int[] num_list = {5,2,1,7,5};
        int n = 3;
        // int[] num_list = {2,1,6};
        // int n = 1;
        //System.out.println(solution.solution(num_list));
        // 배열출력일떄 사용
        System.out.println(Arrays.toString(solution.solution(num_list,n)));
        //solution.solutionActive();
    }
}

class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] arr = new int[num_list.length];
        int count = num_list.length - n;

        for(int i : num_list){ // 5 2 1 7 5
            arr[count] = i;
            System.out.println(count + " " + i);
            count++;
            if(count >= num_list.length){
                count = 0;
            }
        }

        return arr;
        
    }
    public void solutionActive(){
 
    }
}