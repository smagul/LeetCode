// https://leetcode.com/problems/reverse-linked-list/
// Difficulty - #Easy
// Topics - #Linked_List, #Recursion

var root = ReverseListRecursive(new(1, new(2, new(3, new(4, new(5, null))))));
while (root != null)
{
    Console.Write(root.val + " "); // 5,4,3,2,1
    root = root.next;
}

// Time complexity  : O(n)
// Space complexity : O(n)
// Approach 1: Recursive
ListNode ReverseListRecursive(ListNode head)
{
    if (head == null || head.next == null)
    {
        return head;
    }

    ListNode newHead = ReverseListRecursive(head.next);
    head.next.next = head;
    head.next = null;

    return newHead;
}

// Time complexity  : O(n)
// Space complexity : O(1)
// Approach 2: Iterative
ListNode ReverseListIterative(ListNode head)
{
    ListNode prev = null;

    while (head != null)
    {
        ListNode next = head.next;
        head.next = prev;
        prev = head;
        head = next;
    }

    return prev;
}

/**
 * Definition for singly-linked list.
 **/
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