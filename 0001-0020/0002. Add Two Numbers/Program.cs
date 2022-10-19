// https://leetcode.com/problems/two-sum/
// Difficulty - #Medium
// Topics - #Linked_List, #Math, #Recursion

ListNode l1 = new(2, new(4, new(3)));
ListNode l2 = new(5, new(6, new(4)));
ListNode sums = AddTwoNumbers(l1, l2);
while (sums != null)
{
    Console.WriteLine(sums.val); // 7,0,8
    sums = sums.next;
}

// Time complexity  : O(n)
// Space complexity : O(1)
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummy = new();
    ListNode curr = dummy;
    int carry = 0;

    while (l1 != null || l2 != null || carry > 0)
    {
        if (l1 != null)
        {
            carry += l1.val;
            l1 = l1.next;
        }

        if (l2 != null)
        {
            carry += l2.val;
            l2 = l2.next;
        }

        curr.next = new ListNode(carry % 10);
        curr = curr.next;
        carry /= 10;
    }

    return dummy.next;
}

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