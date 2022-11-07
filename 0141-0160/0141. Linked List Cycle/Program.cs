// https://leetcode.com/problems/linked-list-cycle/
// Difficulty - #Easy
// Topics - #Hash_Table, #Linked_List, #Two_Pointers

bool IsHasCycle = HasCycle(new(3, new(2, new(0, new(-4, null)))));
Console.WriteLine(IsHasCycle); // true

// Time complexity  : O(n)
// Space complexity : O(1)
bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast?.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
        {
            return true;
        }
    }

    return false;
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