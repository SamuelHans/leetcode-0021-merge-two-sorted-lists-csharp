using static LeetCode___0021___Merge_Two_Sorted_Lists.Program;

namespace LeetCode___0021___Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            You are given the heads of two sorted linked lists 'list1' and 'list2'.
            Merge the two lists into one sorted 'list'. The list should be made by splicing together the nodes of the first two lists.
            Return the head of the merged linked list.

            Example 1:
            (image)

            Input: list1 = [1,2,4], list2 = [1,3,4]
            Output: [1,1,2,3,4,4]
            
            Example 2:
            Input: list1 = [], list2 = []
            Output: []

            Example 3:
            Input: list1 = [], list2 = [0]
            Output: [0]
             
            Constraints:
            The number of nodes in both lists is in the range [0, 50].
            -100 <= Node.val <= 100
            Both list1 and list2 are sorted in non-decreasing order.

            */
            ListNode list1c = new ListNode()
            {
                val = 4,
                next = null
            };

            ListNode list1b = new ListNode()
            {
                val = 2,
                next = list1c
            };

            ListNode list1a = new ListNode()
            {
                val = 1,
                next = list1b
            };

            ListNode list2c = new ListNode()
            {
                val = 4,
                next = null
            };

            ListNode list2b = new ListNode()
            {
                val = 3,
                next = list2c
            };

            ListNode list2a = new ListNode()
            {
                val = 1,
                next = list2b
            };

            //list2 = [1, 3, 4]

            var solution = Solution.MergeTwoLists(list1a, list2a);

            Console.WriteLine("The merged linked list is: {0}", solution); 
        }

        ///<summary>Definition for singly-linked list.</summary>
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
             }
        }

        public static class Solution
        {
            public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                if (list1 == null) return list2;
                if (list2 == null) return list1;

                if (list1.val < list2.val)
                {
                    list1.next = MergeTwoLists(list1.next, list2);
                    return list1;
                }

                list2.next = MergeTwoLists(list1, list2.next);
                return list2;

            }
        }

        //public static class MergeTwoSortedLists0021
        //{
        //    private static List<List<int>> List1 = new List<List<int>>()
        //    {
        //        new List<int> { 1,2,4 },
        //        new List<int> {  },
        //        new List<int> {  },
        //    };
        
        //            private static List<List<int>> List2 = new List<List<int>>()
        //    {
        //        new List<int> { 1,3,4 },
        //        new List<int> {  },
        //        new List<int> { 0 },
        //    };
        //            private static List<List<int>> ExpectedOutputs = new List<List<int>>
        //    {
        //        new List<int> { 1,1,2,3,4,4 },
        //        new List<int> {  },
        //        new List<int> { 0 },
        //    };
        //}
    }
}

/*
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 *
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }

        list2.next = MergeTwoLists(list1, list2.next);
        return list2;

    }
}

// Time Complexity: O(n + m)
// Space Complexity: O(n + m)

*/