#include <stdio.h>
#include <malloc.h>
void debug(int arr[3][6]) {//매계변수에서 3생략 가능 단 6은 생략 불가능 //
	arr[1][2] *= 2;
}
//void debug(int (*arr)[6]) {// 위 함수와 중복된다.
//	arr[1][2] *= 2;
//}
void doubleValue(int* arr[4]) {//int** arr // 사이즈를 지정하지 않으면 편하게 쓸수 있다.
	arr[1][3] *= 2;
}
//중요 Tip f10번으로 한줄씩 진행할 수 있다.
//중요 tip 
typedef int* pint; // int* 대신 pint를 사용할 것이다.
int main(int argc, char* argv) {
	int a;
	int* pa;
	pa = &a;
	*pa = 27;

	printf("a = %d, *pa = %d, pa= %p\n", a, *pa, pa);
	printf("&a = %p, pa = %p, &pa= %p\n", &a, pa, &pa);

	//  배열
	printf("\n1차원 배열\n");
	int arr[6] = { 0,1,2,3,4,5 };
	int* pArr = arr; 
	pArr = &arr[0];// 윗 문장과 같은 주소가 들어간다. 즉 배열의 이름은 주소다.

	*pArr = 0;
	printf("arr[0] = %d, *pArr = %d\n", arr[0], *pArr);
	printf("arr = %p, &arr[0] = %p, &arr[1]=%p, pArr = %p, arr+1 = %p, (&arr[0]+1) = %p", arr, &arr[0], &arr[1], pArr
	, arr+1,(&arr[0]+1));

	// malloc 사용하기
	printf("\nmalloc 사용하기\n");
	int b;
	int* pb;
	int count = 12;
	pb = (int*)malloc(sizeof(int) * count);
	pb[0] = 23;
	
	pb[2] = 223;
	pb[count] = 343;

	//2차원 배열
	printf("\n 2차원 배열\n");
	int arr2[3][6] = { {0,1,2},{3,4,5},{6,7,8} };
	
	int(* pArr2)[6];// *(a+n) = a[n]
	//pint pArr2[6];
	//pArr2 = (int (*)[6])malloc(sizeof(int[6]) * 3);// 6개짜리가 3묶음이다.
	pArr2 = arr2;
	printf("arr2[1][2] = %d pArr2[1][2] = %d\n", arr2[1][2], pArr2[1][2]);
	debug(arr2);//f11번누르면 해당 함수로 들어간다.
	printf("*(arr2[1]+2) = %d ((pArr2+1)+2) = %d\n", *(arr2[1]+2), *(*(pArr2+1)+2));//pArr2+1 배열을 동호로 보면 동이동, +2는 호이동

	pArr2[1][2] = 37;
	debug(pArr2);
	printf("pArr2[1][2] = %d, *(pArr2[1]+2), *(*(pArr2+1)+2) = %d\n",
		pArr2[1][2], *(pArr2[1] + 2), *(*(pArr2 + 1) + 2));


	//가변 배열 만들기
	printf("\n 가변 배열\n");
	int* p[4];// 4개짜리 배열이 만들어진다.  == int* (p[4]);
	
	int* pd;
	pd = (int*)malloc(sizeof(int) * 6);
	int* arrD[4];// 스택
	// 세로 4개 가로 6,3,5,2 개가 되는 배열이 탄생된다.
	// arrD[0] 과 arrD[1]은 떨어져있다고 볼수 있으나
	//arrD[0]의 malloc으로 생성된 대상은 붙어있다.
	arrD[0] = (int*)malloc(sizeof(int) * 6);// 힙영역
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