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
	int a;
	int b=100;
	int* pa;
	int& ra = a; // ra는 a 와 같은 주소다.
	
	pa = &a;
	*pa = 100;
	// a== ? 100
	ra = 200;
	// a== ? 200
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);
	ra = b; // ra에 b를 치환하라 즉 ra가 b의 주소를 가지는 것이 아닌 ra 에 b의 값을 받는다. a = 100이된다.
	b = 200;
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);

	//scanf_s("%d%x",&a,&b);//%d 는 10진수 입력받음 %x는 16진수로 입력받는다.
	//printf("a=%d  b=%d,   %d", a, b, 100);
	//printf("&a = %p, &b = %p, pa = %p, &pa = %p", &a, &b, pa, &pa);

	scanf_s("%d%x", pa, &b);
	// 값 전달 방식으로 swap
	
	printf("In main , a= %d, b = %d\n", a, b);
	swap(a, b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);
	// 주소 전달 방식으로 
	printf("In main , a= %d, b = %d\n", a, b);
	swap(&a, &b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);
	// 레퍼런스 방식
	printf("In main , a= %d, b = %d\n", a, b);
	refSwap(a, b);// 주소로 매걔변수 넘겨주기
	printf("In main , a= %d , b= %d \n", a, b);


	*pa *= -2;
	printf("a=%d  b=%d,   %d", a, b, 100);


	return 1;
}