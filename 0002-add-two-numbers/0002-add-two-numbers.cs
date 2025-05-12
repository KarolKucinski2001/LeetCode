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
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var result = new ListNode();
        var tmp = result;
        var c = 0;
        while (l1 != null || l2 != null || c != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + c;
            c = sum / 10;
            
            if (sum > 9)
                sum %= 10;

            tmp.next = new ListNode(sum);
            tmp = tmp.next;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return result.next;
    }
}