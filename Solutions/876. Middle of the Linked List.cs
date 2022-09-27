/**
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:

Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.

Example 2:

Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
**/

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
    public ListNode MiddleNode(ListNode head) {  //First Approach
        
     
            ListNode current = head;
            int nodelength =0;
            int middleofthenode = 0;

            while(current!=null)
            {
                nodelength++;
                current = current.next;
            }

            current = head;
            middleofthenode = ReturnMiddleOfNode(nodelength);

            for (int i = 0; i < middleofthenode; i++)
                current = current.next;
            

            return current;
  }
     public int ReturnMiddleOfNode(int length){
            return length / 2;
        }


public ListNode MiddleNode(ListNode head) { //Second Approach
    ListNode current = head;
    ListNode middle = head;
    while (current != null && current.next != null) {
        current = current.next.next;
        middle = middle.next;
    }
    return middle;
  }

}