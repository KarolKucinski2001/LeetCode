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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head==null)
        {
            return head;
        }
        var pointer1=head;

        while(pointer1.next!=null)
        {
            if(pointer1.val==pointer1.next.val)
            {
                pointer1.next=pointer1.next.next;
            }
            else{
                pointer1=pointer1.next;
            }
        }
        return head;
    }
}