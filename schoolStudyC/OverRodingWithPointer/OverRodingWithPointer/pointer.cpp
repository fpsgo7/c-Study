#include <stdio.h>
void swap(int a, int b) {// call by vallue 방식
	printf("In swap, a=%d, b=%d\n", a, b);
	int temp = a;
	a = b;
	b = temp;
	printf("In swap, a=%d, b=%d\n", a, b);
}
void swap(int* a, int* b) {// Call by Point 방식
	printf("In swap, a=%d, b=%d\n", *a, *b);
	int temp = *a;
	*a = *b;
	*b = temp;
	printf("In swap, a=%d, b=%d\n", *a, *b);
}
void refSwap(int& a, int& b) {// Call by reference 방식
	printf("In swap, a=%d, b=%d\n", a, b);
	int temp = a;
	a = b;
	b = temp;
	printf("In swap, a=%d, b=%d\n", a, b);
}
int main(int argc, char* argv) {

	int a = 50;
	int b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	swap(a, b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");
	// 포인터에 주소 전달 방식으로 
	a = 50;
	b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	swap(&a, &b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");
	// 레퍼런스 방식
	a = 50;
	b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	refSwap(a, b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");

	int* pa = &a;// pa 에는 a의 주소가 들어가며
	*pa = 100;// *pa는 a를 가리키기에 a = 100이된다.
	printf("a=%d  b=%d ", a, b);

	return 1;
}