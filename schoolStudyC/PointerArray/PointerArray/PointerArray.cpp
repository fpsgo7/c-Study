#include <stdio.h>
#include <malloc.h>
void multiply(int* parr) {
	parr[1] *= 2;
}
int main(int argc, char* argv) {
	int arr[100];
	int* parr;

	parr = arr;// 배열의 시작주소를 가짐 arr[0]을 가리킨다.
	parr[1] = 200;// arr[1] = 200;
	printf("arr[1]=  %d \n", parr[1]);
	*(parr + 1) = 300;// arr[1] == 300
	printf("arr[1]=  %d \n", parr[1]);
	// *(parr +1) 은 arr[1] 을 가리켜서 arr[1]의 값이 출력된다.
	printf("arr[1] = %p, *(parr + 1) = %d, parr[1] = %d \n ", arr[1], *(parr + 1), parr[1]);
	printf("&arr[1] = %p, (parr + 1) = %p, &parr[1] = %p \n ", &arr[1], (parr + 1), &parr[1]);

	multiply(arr); 
	printf("arr[1] = %d, *(parr + 1) = %d, parr[1] = %d \n ", arr[1], *(parr + 1), parr[1]);
	//int 사용
	printf("int 사용과 malloc \n");
	int count = 100;
	printf("sizeof(int) = %d\n", sizeof(int));// int 의 사이즈는 4이다.
	//malloc을 통하여 배열 을 만든것과 같다. 단 힙영역에 할당된다.
	parr = (int *)malloc(sizeof(int)*count);// int parr [count]; 과 같다.
	*(parr + 2) = -500;
	printf("parr[2] = %d, *(parr +2) = %d \n ", parr[2], *(parr + 2));
	printf("parr = %p, (parr +2) = %p, &parr[1] = %p \n ", parr, (parr +1), &parr[1] );

	printf("\n\n");
	//double 사용
	printf("double 사용과 malloc \n");
	double arrD[100];// 배열의 이름은 주소다.
	double* parrD;
	int countD = 100;
	printf("sizeof(double) = %d\n", sizeof(double));
	parrD = (double*)malloc(sizeof(double) * count);// double parrD [count]; 과 같다.
	*(parrD + 2) = -500;
	printf("parrD[2] = %lf, *(parrD +2) = %lf \n ", parrD[2], *(parrD + 2));
	printf("parrD = %p, (parrD +2) = %p, &parrD[1] = %p \n ", parrD, (parrD + 1), &parrD[1]);

	//malloc은 사용후 free를 해준다.
	free(parr);
	free(parrD);
	return 1;
}