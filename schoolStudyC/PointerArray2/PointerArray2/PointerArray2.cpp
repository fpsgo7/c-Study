#include <stdio.h>
#include <malloc.h>

int main(int argc, char* argv) {
	int arr[5][6] = { {1,2},{3,4} };// 2���� �迭������ ��ǻ� ���� ������ 1�����̴�.

	printf("%d, %d, %d, %d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	int (*parr)[6];// ��ȣ�� ��ġ�� 6��¥�� �迭�� �ǹ�����.
	parr = arr;
	parr[0][1] *= -2;
	printf("�迭�� ���� ���      %d, %d, %d, %d\n\n", arr[0][0], arr[0][1], arr[1][0], arr[1][1]);
	printf("�迭�� �ּ� ���      %p %p ,%p ,%p\n\n", &arr[0][0], &arr[0][1], &arr[1][0], &arr[1][1]);
	printf("parr �迭�� �ּ� ��� %p %p ,%p ,%p\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	printf("parr +1 �� ���� ���  %p %p, %p, %p\n\n", parr, parr[0] + 1, parr + 1, parr + 2);// +1 �� arr[5][6]�� 6��ŭ �����Ѵ�.
	printf("%d %d ,%d ,%d\n\n", &parr[0][0], &parr[0][1], &parr[1][0], &parr[1][1]);
	// parr[0] + 1 = arr[0][1]
	// parr +1 = arr[1][0]

	int count= 5;
	// parr = int (*parr)[6]; �� ����.
	parr = (int (*)[6])malloc(sizeof(int[6]) * count);//malloc�� ������ �� �� �ִ�.
	parr[0][1] = 100;
	//arr[1] = *(arr +1) �� 2���� ����.

	//*(parr + 0 )�� parr[0] �� ������ �ᱹ *(*(parr +0) +1)) ��
	// *(parr[0] +1) �� ���� parr[0][1] �� ����.
	printf("%d ,%d ,%d \n\n", parr[0][1], *(parr[0]+1), *(*(parr +0) +1));
	return 1;
}