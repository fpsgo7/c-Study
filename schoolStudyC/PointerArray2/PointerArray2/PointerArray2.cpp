#include <stdio.h>
#include <malloc.h>

int main(int argc, char* argv) {
	int arr[5][6] = { {1,2},{3,4} };
	printf("%d%d,%d,%d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	int (*parr)[6];// 괄호를 안치면 6개짜리 배열이 되버린다.
	parr = arr;
	parr[0][1] *= -2;
	printf("%d%d,%d,%d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	printf("%p %p ,%p ,%p\n\n", &arr[0][0], &arr[0][1], &arr[1][0], &arr[1][1]);
	printf("%p %p ,%p ,%p\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	printf("%d %d ,%d ,%d\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	printf("%p %p, %p, %p\n\n", parr, parr+1, parr[0]+1, parr+2);// +1 로 arr[5][6]의 6만큼 증가한다.

	int count= 5;
	parr = (int (*)[6])malloc(sizeof(int[6]) * count);//malloc은 실패할 수 도 있다.
	parr[0][1] = 100;
	//arr[1] = *(arr +1) 위 2개는 같다.
	printf("%d ,%d ,%d \n\n", parr[0][1], *(parr[0]+1), *(*(parr +0) +1));
	return 1;
}