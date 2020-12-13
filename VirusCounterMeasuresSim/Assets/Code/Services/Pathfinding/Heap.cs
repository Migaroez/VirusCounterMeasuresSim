using System;

public class Heap<T> where T : IHeapItem<T>
{
    private T[] _items;
    public int ItemCount { get; private set; }

    public Heap(int maxSize)
    {
        _items = new T[maxSize];
    }

    public void Add(T item)
    {
        item.HeapIndex = ItemCount;
        _items[ItemCount] = item;
        SortUp(item);
        ItemCount++;
    }

    public T RemoveFirst()
    {
        T firstItem = _items[0];
        ItemCount--;
        _items[0] = _items[ItemCount];
        _items[0].HeapIndex = 0;
        SortDown(_items[0]);
        return firstItem;
    }

    public void UpdateItem(T item)
    {
        SortUp(item);
    }

    public bool Contains(T item)
    {
        return Equals(_items[item.HeapIndex], item);
    }

    void SortDown(T item)
    {
        while (true)
        {
            int childIndexLeft = item.HeapIndex * 2 + 1;
            int childIndexRight = item.HeapIndex * 2 + 2;
            int swapIndex = 0;

            if (childIndexLeft < ItemCount)
            {
                swapIndex = childIndexLeft;

                if (childIndexRight < ItemCount)
                {
                    if (_items[childIndexLeft].CompareTo(_items[childIndexRight]) < 0)
                    {
                        swapIndex = childIndexRight;
                    }
                }

                if (item.CompareTo(_items[swapIndex]) < 0)
                {
                    Swap(item, _items[swapIndex]);
                }
                else return;
            }
            else return;
        }
    }

    void SortUp(T item)
    {
        int parentIndex = (item.HeapIndex - 1) / 2;

        while (true)
        {
            T parent = _items[parentIndex];
            if (item.CompareTo(parent) > 0)
            {
                Swap(item, parent);
            }
            else break;

            parentIndex = (item.HeapIndex - 1) / 2;
        }
    }

    void Swap(T itemA, T itemB)
    {
        _items[itemA.HeapIndex] = itemB;
        _items[itemB.HeapIndex] = itemA;
        int temp = itemA.HeapIndex;
        itemA.HeapIndex = itemB.HeapIndex;
        itemB.HeapIndex = temp;
    }
}

public interface IHeapItem<T> : IComparable<T>
{
    int HeapIndex { get; set; }
}