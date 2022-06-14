using System;

public class challenge1
{
    public static int[] buble(int[] A)
    {
        for(int i=0;i<A.Length;i++)
        {
            int j=1;
            bool change = false;
            while (j < A.Length)
            {
                if (A[j] < A[j-1])
                {
                    int temp = A[j - 1];
                    A[j-1] = A[j];
                    A[j] = temp;
                    change = true;
                }
                j++;
            }
            if (change== false)
                break;
            
        }
        return A;
    }
    public static int[] sorted(List<int[]> A)
    {
        int elems = A.Count;
        int len = 0;
        int[] res;

        for (int i = 0; i < elems; i++)
        {
            len=len + A[i].Length;
        }
        res = new int[len];
        int k = 0;
        for (int i = 0; i < elems; i++)
        {
            int arrlen = A[i].Length;
            for(int j = 0; j < arrlen;j++)
            {
                res[k] = A[i][j];
                k++;
            }
        }
        res=buble(res);
        return res;
    }

    public static double median(int M,int N,int[] A, int[] B)
    {
        //this is default OUTPUT. You can change it.
        double media = 0;
        int[] res=new int[N+M];
        int n = 0,m=0;
        for(int i=0;i<N+M;i++)
        {
            if (n < N && m < M)
            {
                if (A[m] <= B[n])
                {
                    res[i] = A[m];
                    m++;
                }
                else
                {
                    res[i] = B[n];
                    n++;
                }
            }
            else if (n >= N || m >= M)
            {
                if (n >= N)
                {
                    res[i] = A[m];
                    m++;
                }
                else if (m >= M)
                {
                    res[i] = B[n];
                    n++;
                }
            }

        }
        if ((N + M) % 2 == 0)
            media = (double)(res[(N + M) / 2-1] + res[(N+M)/2]) / 2.0;
        else
            media = (double)res[((N + M) - 1) / 2];
        return media;
    }
 
    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        int m=2,n=1;

       // int[] nums1 = { 1, 2 };
       // int[] nums2 = { 3, 4 };
       // int m = 2, n = 2;
        Console.Write("Media : "+ median(m, n, nums1, nums2));

        List<int[]> A = new List<int[]> { new int[] { 1, 4,5}, new int[] { 1, 3, 4 },new int[] { 2, 6 } };
        int[] sortArray;
        sortArray=sorted(A);
        Console.WriteLine();
        for(int i=0;i<sortArray.Length;i++)
        {
            Console.Write(sortArray[i]+" ");
        }
    }
}