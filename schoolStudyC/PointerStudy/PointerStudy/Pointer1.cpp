#include <stdio.h>
void swap(int a, int b) {// call by vallue ���
	printf("In swap, a=%d, b=%d\n", a, b);
	int temp = a;
	a = b;
	b = temp;
	printf("In swap, a=%d, b=%d\n", a, b);
}
void swap(int* a, int* b) {// Call by Point ���
	printf("In swap, a=%d, b=%d\n", *a, *b);
	int temp = *a;
	*a = *b;
	*b = temp;
	printf("In swap, a=%d, b=%d\n", *a, *b);
}
void refSwap(int& a, int& b) {// Call by reference ���
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
	int& ra = a; // ra�� a �� ���� �ּҴ�.
	
	pa = &a;
	*pa = 100;
	// a== ? 100
	ra = 200;
	// a== ? 200
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);
	ra = b; // ra�� b�� ġȯ�϶� �� ra�� b�� �ּҸ� ������ ���� �ƴ� ra �� b�� ���� �޴´�. a = 100�̵ȴ�.
	b = 200;
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);

	//scanf_s("%d%x",&a,&b);//%d �� 10���� �Է¹��� %x�� 16������ �Է¹޴´�.
	//printf("a=%d  b=%d,   %d", a, b, 100);
	//printf("&a = %p, &b = %p, pa = %p, &pa = %p", &a, &b, pa, &pa);

	scanf_s("%d%x", pa, &b);
	// �� ���� ������� swap
	
	printf("In main , a= %d, b = %d\n", a, b);
	swap(a, b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);
	// �ּ� ���� ������� 
	printf("In main , a= %d, b = %d\n", a, b);
	swap(&a, &b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);
	// ���۷��� ���
	printf("In main , a= %d, b = %d\n", a, b);
	refSwap(a, b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);


	*pa *= -2;
	printf("a=%d  b=%d,   %d", a, b, 100);


	return 1;
}