using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeList
{
    public class Node
    {
        public int data;
        public Node next;// 자신의 다음 클래스 주소값
        public Node(int data)
        {
            this.data = data;// 데이터
            next = null;// 리스트에서 다음에 연겨로디는 노드
        }
    }
    class MyLinkedList
    {

        Node head;// 첫번쨰 노드
        public int count = 0; // 전ㅊ
        // 리스트 맨앞에 삽입하다.
        public void InsertFront(int data)
        {
            Node node = new Node(data);//노드 객체 생성
            node.next = head;// 리스트의 첫번쨰 노드로 지정
            head = node;

            count++;// 노드 길이값 추가
        }
        //노드 추가
        public void InsertLast(int data)
        {
            Node node = new Node(data);
            // 만약 생서되는 노드가 첫 노드일경우
            if(head == null)
            {
                head = node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = node;

            count++;
        }
        public Node GetLastNode()
        {
            Node lastNode = head;// 해드에서 시작한다.
            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            return lastNode;
        }
        //인덱스로 노드 찾기
        public int GetFindNode(int index)
        {
            Node currentNode = head;// 해드에서 시작한다.
            // 첫번째 노드 검사
            if (index == 0)
            {
                return currentNode.data;
            }
            for(int i=1; i<index; i++)
            {
                currentNode = currentNode.next;
            }
            return currentNode.data;
        }
        public void DeleteFirstNode()
        {
            //head가 비어있지 않을 경우
            if (head != null)
            {
                // head 에 다음 노드를 넣는다.
                head = head.next;
                count--;
            }
        }
        public void DeleteLastNode()
        {
            if (head != null)
            {
                if(head.next == null)// 노드가 1개뿐일경우
                {
                    DeleteFirstNode();
                }
                else
                {
                    // 현제 노드와 이전노드는 head로 초기화
                    Node currentNode = head;
                    Node previousNode = head;
                    while (currentNode.next != null)
                    {
                        previousNode = currentNode;// 이전 노드에는 현제노드
                        currentNode = currentNode.next;// 현제 노드에는 다음 노드
                    }
                    // 현제 노드에 마지막 노드가 들어가게 된다면
                    previousNode.next = null;// 이전 노드의 넥스트값을 null 로 하여 마지막 노드와의 연결을 끊는다.
                    count--;
                }

            }
        }
        public void DeleteFindNode(int data)
        {
            Node currentNode = head;// 해드에서 시작한다.
            Node previousNode = null;// 이전 노드
            // 첫번째 노드 검사
            if (currentNode.data == data)
            {
                //head 에 자신의 다음 노드와 연결하여 
                //head와 자신과의 연결을 끊고 다음 노드와 연결시킴
                head = currentNode.next;
                count--;
                return;
            } 
            //이후 노드들 검사
            while (currentNode.next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
                if (currentNode.data == data)
                {
                    previousNode.next = currentNode.next;
                    count--;
                    return;
                }
                    
            }
        }
        public void PrintAllNode()
        {
            Node currentNode = head;// 해드에서 시작한다.
            // 첫번째 노드 출력
            Console.Write(currentNode.data+" ");

            //이후 노드들 검사
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                Console.Write(currentNode.data + " ");
            }
            Console.WriteLine();
        }
        public int GetCount()
        {
            return count;
        }
        public void Reverse()
        {
            
            Node previousNode = null;
            Node currentNode = head;
            Node nextNode = null;
          

            while (currentNode != null)
            {
                nextNode = currentNode.next;// 다음 노드를 가리킬 값에 현제 노드의 다음값을 넣음
                currentNode.next = previousNode;// 현제 노드의 다음 값을 이전노드로 가리킴
                previousNode = currentNode;// 이전 노드는 현제 노드가 되고
                currentNode = nextNode;//현제노든는 다음노드가 됨
            }
           
            head = previousNode;
        }
    }
}
