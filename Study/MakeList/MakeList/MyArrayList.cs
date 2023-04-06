using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeList
{
    class MyArrayList<T>
    {
        int itemsCount = 0;
        T[] items = new T[0]; 

        //배열 길이 추가
        public void AddArrayLength()
        {
            T[] newitems = new T[++itemsCount];
            if (items.Length > 0)
            {
                Array.Copy(items, 0, newitems, 0, items.Length);
            }
            items = newitems;
        }
        //리스트 추가
        public void Add(T newitem)
        {
            AddArrayLength();
            items[itemsCount-1] = newitem;
        }
        //리스트 중간 삼입
        public void Insert(T newitem,int position)
        {
            AddArrayLength();
            
            for(int i=position;i<items.Length-1;i++)
            {
                items[i + 1] = items[i];
            }
            items[position] = newitem;
        }
        //리스트 검색 삭제
        public void Remove(T item)
        {
            int position=-1;
            for(int i=0; i<items.Length; i++)
            {
                if(items[i].Equals(item))
                {
                    position = i;
                }
            }
            for (int i = position; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            T[] newitems = new T[--itemsCount];
            if (items.Length > 0)
            {
                Array.Copy(items, 0, newitems, 0, items.Length - 1);
            }
            items = newitems;
        }
        //리스트 위치 검색 삭제
        public void RemoveAt(int position)
        {

            for (int i = position; i < items.Length - 1; i++)
            {
                items[i] = items[i+1];
            }
            T[] newitems = new T[--itemsCount];
            if (items.Length > 0)
            {
                Array.Copy(items, 0, newitems, 0, items.Length-1);
            }
            items = newitems;
        }
        //리스트 정렬
        public void SortList()
        {
            Array.Sort(items);
        }
        //리스트 보기
        public T SearchByNum(int num)
        {
            return items[num];
        }
    }
}
