namespace jira_testing
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }


            static void Main(string[] args)
            {
                int[] array = { 64, 34, 25, 12, 22, 11, 90 };
                int[] array2 = { 64, 34, 25, 12, 22, 11, 90 };

                BubbleSort(array);
                SelectionSort(array2);

                Console.WriteLine(string.Join(" ", array));
                Console.WriteLine(string.Join(" ", array2));
            }
        }
    }
