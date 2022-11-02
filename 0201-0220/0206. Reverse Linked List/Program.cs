// https://leetcode.com/problems/reverse-linked-list/
// Difficulty - #Easy
// Topics - #Linked_List, #Recursion

var root = ReverseList(new(1, new(2, new(3, new(4, new(5, null))))));
while (root != null)
{
    Console.Write(root.val + " "); // 5,4,3,2,1
    root = root.next;
}

// Time complexity  : O(n)
// Space complexity : O(1)
ListNode ReverseList(ListNode head)
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