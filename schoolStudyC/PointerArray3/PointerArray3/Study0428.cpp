#include <stdio.h>
#include <malloc.h>
void debug(int arr[3][6]) {//�Ű躯������ 3���� ���� �� 6�� ���� �Ұ��� //
	arr[1][2] *= 2;
}
//void debug(int (*arr)[6]) {// �� �Լ��� �ߺ��ȴ�.
//	arr[1][2] *= 2;
//}
void doubleValue(int* arr[4]) {//int** arr // ����� �������� ������ ���ϰ� ���� �ִ�.
	arr[1][3] *= 2;
}
//�߿� Tip f10������ ���پ� ������ �� �ִ�.
//�߿� tip 
typedef int* pint; // int* ��� pint�� ����� ���̴�.
int main(int argc, char* argv) {
	int a;
	int* pa;
	pa = &a;
	*pa = 27;

	printf("a = %d, *pa = %d, pa= %p\n", a, *pa, pa);
	printf("&a = %p, pa = %p, &pa= %p\n", &a, pa, &pa);

	//  �迭
	printf("\n1���� �迭\n");
	int arr[6] = { 0,1,2,3,4,5 };
	int* pArr = arr; 
	pArr = &arr[0];// �� ����� ���� �ּҰ� ����. �� �迭�� �̸��� �ּҴ�.

	*pArr = 0;
	printf("arr[0] = %d, *pArr = %d\n", arr[0], *pArr);
	printf("arr = %p, &arr[0] = %p, &arr[1]=%p, pArr = %p, arr+1 = %p, (&arr[0]+1) = %p", arr, &arr[0], &arr[1], pArr
	, arr+1,(&arr[0]+1));

	// malloc ����ϱ�
	printf("\nmalloc ����ϱ�\n");
	int b;
	int* pb;
	int count = 12;
	pb = (int*)malloc(sizeof(int) * count);
	pb[0] = 23;
	
	pb[2] = 223;
	pb[count] = 343;

	//2���� �迭
	printf("\n 2���� �迭\n");
	int arr2[3][6] = { {0,1,2},{3,4,5},{6,7,8} };
	
	int(* pArr2)[6];// *(a+n) = a[n]
	//pint pArr2[6];
	//pArr2 = (int (*)[6])malloc(sizeof(int[6]) * 3);// 6��¥���� 3�����̴�.
	pArr2 = arr2;
	printf("arr2[1][2] = %d pArr2[1][2] = %d\n", arr2[1][2], pArr2[1][2]);
	debug(arr2);//f11�������� �ش� �Լ��� ����.
	printf("*(arr2[1]+2) = %d ((pArr2+1)+2) = %d\n", *(arr2[1]+2), *(*(pArr2+1)+2));//pArr2+1 �迭�� ��ȣ�� ���� ���̵�, +2�� ȣ�̵�

	pArr2[1][2] = 37;
	debug(pArr2);
	printf("pArr2[1][2] = %d, *(pArr2[1]+2), *(*(pArr2+1)+2) = %d\n",
		pArr2[1][2], *(pArr2[1] + 2), *(*(pArr2 + 1) + 2));


	//���� �迭 �����
	printf("\n ���� �迭\n");
	int* p[4];// 4��¥�� �迭�� ���������.  == int* (p[4]);
	
	int* pd;
	pd = (int*)malloc(sizeof(int) * 6);
	int* arrD[4];// ����
	// ���� 4�� ���� 6,3,5,2 ���� �Ǵ� �迭�� ź���ȴ�.
	// arrD[0] �� arrD[1]�� �������ִٰ� ���� ������
	//arrD[0]�� malloc���� ������ ����� �پ��ִ�.
	arrD[0] = (int*)malloc(sizeof(int) * 6);// ������
	arrD[1] = (int*)malloc(sizeof(int) * 3);
	arrD[2] = (int*)malloc(sizeof(int) * 5);
	arrD[3] = (int*)malloc(sizeof(int) * 2);
	arrD[1][3] = 78;
	printf("arrD[1][3] = %d\n", arrD[1][3]);
	doubleValue(arrD);
	printf("arrD[1][3] = %d\n", arrD[1][3]);

	int* pointer;
	pointer = (int*)malloc(sizeof(int) * 6);
	int** pp;
	int row = 4;
	pp = (int **)malloc(sizeof(int*) * row);
	pp[0] = (int*)malloc(sizeof(int) * 6); 
	pp[1] = (int*)malloc(sizeof(int) * 3);
	pp[2] = (int*)malloc(sizeof(int) * 5);
	pp[3] = (int*)malloc(sizeof(int) * 2);
 
	return 1;
}