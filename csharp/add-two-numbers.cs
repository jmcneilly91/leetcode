public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string s1 = string.Empty;
        string s2 = string.Empty;
        decimal i1;
        decimal i2;
        LinkedList result = new LinkedList();

        while (l1 != null) {
            s1 = s1.Insert(0, l1.val.ToString());
            l1 = l1.next;
        }

        while (l2 != null) {
            s2 = s2.Insert(0, l2.val.ToString());
            l2 = l2.next;
        }

        decimal.TryParse(s1, out i1);
        decimal.TryParse(s2, out i2);

        decimal sum = i1 + i2;
        string sSum = sum.ToString();

        int[] intArray = sSum.Select(i => Convert.ToInt32(i.ToString())).ToArray();

        for (int i = intArray.Length - 1; i >= 0; i--) {
            result.AddNode(intArray[i]);
        }

        return result.head;
    }