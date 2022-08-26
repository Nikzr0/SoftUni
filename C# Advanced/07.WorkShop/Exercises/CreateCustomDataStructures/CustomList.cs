namespace CreateCustomDataStructures
{
    public class CustomList<T>
    {
        private int InitialCapacity = 2;
        private T[] items;

        public int Count { get; private set; }
        public CustomList()
        {
            items = new T[InitialCapacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        private void Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        public void Add(T item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        private void Shrink()
        {
            T[] copy = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            var item = items[index];
            items[index] = default(T); // 0
            Shift(index);

            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return item;
        }

        public void Insert(int index, T element)
        {
            if (index > Count)
            {
                throw new System.IndexOutOfRangeException();
            }

            if (Count == index)
            {
                Add(element);
            }
            ShiftToRight(index);

            items[index] = element;
            Count++;
        }

        public bool Contains(T element)
        {
            bool found = false;

            foreach (var item in items)
            {
                if (item.Equals(element))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (Count < secondIndex)
            {
                var temp = items[firstIndex];

                items[firstIndex] = items[secondIndex];
                items[secondIndex] = temp;
            }
            else
            {
                throw new System.Exception("Incorect Datа");
            }
        }
    }
}