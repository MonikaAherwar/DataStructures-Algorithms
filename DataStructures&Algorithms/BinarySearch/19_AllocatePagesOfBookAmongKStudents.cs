using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _19_AllocatePagesOfBookAmongKStudents
    {

        // Find Minimum Number of Pages to be allocated 
        // Among K students
        // books[] : Array of pages of books
        // k : number of students
        public int AllocatePagesOfBookAmongKStudents(int[] books, int k)
        {

            int n = books.Length;
            int totalPagesCount = 0;
            
            //Result attribute
            int minimumPagesCount = -1;
            
            foreach(int book in books)
            {
                totalPagesCount += book;
            }

            int start = 0;
            int end = totalPagesCount;

            while(start < end)
            {
                int mid = start + (end - start)/2;

                if(isValidBookDistribution(books, n, k, mid))
                {
                    minimumPagesCount = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return minimumPagesCount;
        }

        private bool isValidBookDistribution(int[] books, int n, int students, int pages)
        {
            int studentCounts = 1;
            int pagesSum = 0;
            foreach (int book in books)
            {
                pagesSum += book;

                if (pagesSum > pages)
                {
                    studentCounts++;
                    pagesSum = book;
                }
            }

            return studentCounts == students ? true : false;
        }
    }
}
