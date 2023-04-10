using System;
using System.Collections;
using System.Collections.Generic;

namespace MakeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            ArrayList b = new ArrayList();

            //UseMyArrayList();
           UseMyLinkedList();
            
        }

        static void UseMyArrayList()
        {
            MyArrayList<int> myArrayList = new MyArrayList<int>();// 리스트 생성
            myArrayList.Add(3);// 리스트에 내용 추가
            myArrayList.Add(2);
            myArrayList.Add(1);
            myArrayList.SortList();// 리스트 정렬
            //Console.WriteLine(myArrayList.SearchByNum(0));//번째 단어 찾기
            myArrayList.Insert(5, 2);// 특정 위치에 삽입
            //Console.WriteLine(myArrayList.SearchByNum(2));
            //myArrayList.RemoveAt(2);//위치를 이용한 삭제
            //Console.WriteLine(myArrayList.SearchByNum(2));
            //myArrayList.Remove(1);// 1을 가진 대상을 찾아 삭제
            //Console.WriteLine(myArrayList.SearchByNum(0));
            //Console.WriteLine(myArrayList.IndexOf(3));//3을 가진 대상의 인덱스 검색
            myArrayList.PrintAll();
            myArrayList.Reverse();
            myArrayList.PrintAll();
        }
        static void UseMyLinkedList()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.InsertFront(1);
            myLinkedList.InsertLast(2);
            myLinkedList.InsertLast(3);
            //myLinkedList.DeleteFirstNode();
            //myLinkedList.DeleteLastNode();
            //myLinkedList.DeleteFindNode(4);
            //Console.WriteLine(myLinkedList.GetFindNode(2));
            myLinkedList.PrintAllNode();
            //Console.WriteLine(myLinkedList.GetCount());
            myLinkedList.Reverse();
            myLinkedList.PrintAllNode();
        }
    }
}
