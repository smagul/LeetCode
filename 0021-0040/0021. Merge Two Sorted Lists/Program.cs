// https://leetcode.com/problems/merge-two-sorted-lists/
// Difficulty - #Easy
// Topics - #Linked_List, #Recursion

ListNode list1 = new(1, new(2, new(4, null)));
ListNode list2 = new(1, new(3, new(4, null)));
var root = MergeTwoLists(list1, list2);

while (root != null)
{
    Console.Write(root.val + " "); // 1,1,2,3,4,4
    root = root.next;
}

// Time complexity  : O(∣list1∣+∣list2∣))
// Space complexity : O(∣list1∣+∣list2∣))
ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null || list2 == null)
    {
        return list1 ?? list2;
    }

    if (list1.val > list2.val)
    {
        ListNode temp = list1;
        list1 = list2;
        list2 = temp;
    }

    list1.next = MergeTwoLists(list1.next, list2);

    return list1;
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