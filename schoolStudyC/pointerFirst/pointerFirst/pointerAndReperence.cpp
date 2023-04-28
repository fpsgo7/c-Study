#include <stdio.h>
int main(int argc, char* argv) {
	int a;
	int b = -100;
	int* pa;// 포인터 변수
	pa = &a; // pa 에는 a의 주소가 들어간다.
	int& ra = a; // ra는 a 와 같은주소를 가진다.

	
	*pa = 100;// pa 포인터 변수가 가리키는 a에 100이란 값이 들어간다.
	printf("%d %d\n\n",a,*pa);
	// a== ? 100
	ra = 200;
	printf("%d %d\n\n", a, ra);
	// a== ? 200
	//래퍼런스 변수 ra 에 b 를 할당할경우
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);
	ra = b; // ra에 b를 치환하라 즉 ra가 b의 주소를 가지는 것이 아닌 ra 에 b의 값을 받아.ra 와 주소가 같은  a가  100이된다.
	b = 200;// ra는 b의 주소를 받은 것이 아니기에 ra는 여전히 a의 주소를 가진다.
	printf("In main , a = %d,  *pa = %d, ra = %d\n", a, *pa, ra);

	// 값을 입력 받아 출력하기
	// 주소를 통해 입력하기
	// &a는 a의 주소이다.
	scanf_s("%d%d",&a,&b);
	printf("a= %d  ,b= %d \n\n", a, b);// 결과적으로 &a 에 입력하면 해당 주소를 가지고있는 a에 입력된다.
	//%p 로 포인터 형식으로 출력하기
	// a의 주소 &a 와  a의 주소를 가진 포인터 변수 pa는 서로 같은 값을 가진다.
	// 
	printf("&a = %p, pa = %p, &pa = %p", &a, pa, &pa);

	return 1;
}