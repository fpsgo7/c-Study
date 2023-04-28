#include <stdio.h>
#include <malloc.h>

int main(int argc, char* argv) {
	int arr[5][6] = { {1,2},{3,4} };// 2차원 배열이지만 사실상 실제 저장은 1차원이다.

	printf("%d, %d, %d, %d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	int (*parr)[6];// 괄호를 안치면 6개짜리 배열이 되버린다.
	parr = arr;
	parr[0][1] *= -2;
	printf("배열의 값들 출력      %d, %d, %d, %d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	printf("배열의 주소 출력      %p %p ,%p ,%p\n\n", &arr[0][0], &arr[0][1], &arr[1][0], &arr[1][1]);
	printf("parr 배열의 주소 출력 %p %p ,%p ,%p\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	printf("parr +1 을 통한 출력  %p %p, %p, %p\n\n", parr, parr[0] + 1, parr + 1, parr + 2);// +1 로 arr[5][6]의 6만큼 증가한다.
	printf("%d %d ,%d ,%d\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	// parr[0] + 1 = arr[0][1]
	// parr +1 = arr[1][0]

	int count= 5;
	// parr = int (*parr)[6]; 과 같다.
	parr = (int (*)[6])malloc(sizeof(int[6]) * count);//malloc은 실패할 수 도 있다.
	parr[0][1] = 100;
	//arr[1] = *(arr +1) 위 2개는 같다.

	//*(parr + 0 )은 parr[0] 과 같으며 결국 *(*(parr +0) +1)) 은
	// *(parr[0] +1) 과 같아 parr[0][1] 과 같다.
	printf("%d ,%d ,%d \n\n", parr[0][1], *(parr[0]+1), *(*(parr +0) +1));
	return 1;
}