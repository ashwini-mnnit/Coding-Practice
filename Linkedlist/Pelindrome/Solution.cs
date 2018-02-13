using System;
using System.Collections.Generic;

public class Solution {
    public bool IsPelindromeIterative (ListNode head) {
        if (head.next == null) {
            return true;
        }

        Stack<ListNode> st = new Stack<ListNode> ();

        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.next != null) {
            st.Push (slow);
            slow = slow.next;

            fast = fast.next.next;
        }

        //odd
        if (fast != null) {
            slow = slow.next;
        }

        // Keep checking the stack

        while (slow != null) {
            if (st.Count == 0 || slow.val != st.Peek ().val) {
                return false;
            }

            st.Pop ();
            slow = slow.next;
        }

        if (st.Count != 0) {
            return false;
        }
        return true;
    }

    public bool IsPelindromeRecurssive (ListNode head) {
        if (head.next == null) {
            return true;
        }

        ListNode cur= head;
        return IsPelindromeRecurssiveUtil(head,ref cur);
    }

    private bool IsPelindromeRecurssiveUtil(ListNode head, ref ListNode cur)
    {
        if(head== null)
        {
            return true;
        }

        bool ret = IsPelindromeRecurssiveUtil(head.next, ref cur);
        
        if(ret==true)
        {
            if(cur.val != head.val)
        {
            ret = false;
        }
        }
        
        

        cur=cur.next;
    }
}