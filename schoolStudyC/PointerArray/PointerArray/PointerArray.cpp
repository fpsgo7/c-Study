#include <stdio.h>
#include <malloc.h>
void multiply(int* parr) {
	parr[1] *= 2;
}
int main(int argc, char* argv) {
	int arr[100];// �迭�� �̸��� �ּҴ�.
	int* parr;

	parr = arr;// �迭�� �����ּҸ� ����
	parr[1] = 200;// arr[1] = 200;
	printf("arr[1]=  %d \n", parr[1]);
	*(parr + 1) = 300;// arr[1] == 300
	printf("arr[1]=  %d \n", parr[1]);
	printf("arr[1] = %p, *(parr + 1) = %d, parr[1] = %d \n ", arr[1], *(parr + 1), parr[1]);
	printf("&arr[1] = %p, *(parr + 1) = %d, parr[1] = %d \n ", &arr[1], (parr + 1), &parr[1]);

	multiply(arr);
	printf("arr[1] = %p, *(parr + 1) = %d, parr[1] = %d \n ", arr[1], *(parr + 1), parr[1]);

	int count = 100;
	printf("sizeof(int) = %d\n", sizeof(int));
	parr = (int *)malloc(sizeof(int)*count);// int parr [count]; �� ����.
	*(parr + 2) = -500;
	printf("parr[2] = %d, *(parr +2) = %d \n ", parr[2], *(parr + 2));
	printf("parr = %p, (parr +2) = %p, &parr[1] = %p \n ", parr, (parr +1), &parr[1] );

	printf("\n\n");
	double arrD[100];// �迭�� �̸��� �ּҴ�.
	double* parrD;
	int countD = 100;
	printf("sizeof(double) = %d\n", sizeof(double));
	parrD = (double*)malloc(sizeof(double) * count);// int parr [count]; �� ����.
	*(parrD + 2) = -500;
	printf("parrD[2] = %lf, *(parrD +2) = %lf \n ", parrD[2], *(parrD + 2));
	printf("parrD = %p, (parrD +2) = %p, &parrD[1] = %p \n ", parrD, (parrD + 1), &parrD[1]);

	//malloc�� ����� free�� ���ش�.
	free(parr);
	free(parrD);
	return 1;
}