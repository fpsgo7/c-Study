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

	int a = 50;
	int b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	swap(a, b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");
	// �����Ϳ� �ּ� ���� ������� 
	a = 50;
	b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	swap(&a, &b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");
	// ���۷��� ���
	a = 50;
	b = -50;
	printf("In main , a= %d, b = %d\n", a, b);
	refSwap(a, b);// �ּҷ� �Űº��� �Ѱ��ֱ�
	printf("In main , a= %d , b= %d \n", a, b);
	printf("\n\n");

	int* pa = &a;// pa ���� a�� �ּҰ� ����
	*pa = 100;// *pa�� a�� ����Ű�⿡ a = 100�̵ȴ�.
	printf("a=%d  b=%d ", a, b);

	return 1;
}