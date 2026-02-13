using System.Numerics;

namespace Add_Two_Numbers
{
    public class Add_Two_Numbers
    {
        private string l1String = "";
        private string l2String = "";

        private BigInteger resultInt = 0;
        private string resultString = "";

        private ListNode l1Temp = new();
        private ListNode l2Temp = new();

        private ListNode resultList;
        private ListNode tempResult;

        public Add_Two_Numbers(ListNode l1, ListNode l2)
        {
            InitialLTemp(l1, ref l1Temp);
            InitialLTemp(l2, ref l2Temp);

            FillLString(l1Temp, ref l1String);
            FillLString(l2Temp, ref l2String);

            ReverseLString(ref l1String);
            ReverseLString(ref l2String);

            GetIntResult();
            GetResultList();

            ResultToConsole();
        }

        private void InitialLTemp(ListNode l, ref ListNode lTemp) => lTemp = l;

        private void FillLString(ListNode lTemp, ref string lString)
        {
            while (lTemp != null)
            {
                lString += lTemp.val.ToString();
                lTemp = lTemp.next;
            }
        }

        private void ReverseLString(ref string lString)
        {
            char[] lCharArray = lString.ToCharArray();
            Array.Reverse(lCharArray);
            lString = new string(lCharArray);
        }

        private void GetIntResult()
        {
            resultInt = BigInteger.Parse(l1String) + BigInteger.Parse(l2String);
            resultString = resultInt.ToString();

            char[] resultCharArray = resultString.ToCharArray();
            Array.Reverse(resultCharArray);

            resultString = new string(resultCharArray);
        }

        private void GetResultList()
        {
            resultList = new ListNode((int)char.GetNumericValue(resultString[0]));
            tempResult = resultList;

            for (int index = 1; index < resultString.Length; index++)
            {
                tempResult.next = new ListNode((int)char.GetNumericValue(resultString[index]));
                tempResult = tempResult.next;
            }
        }

        private void ResultToConsole()
        {
            string resultString = "";
            ListNode resultStringTemp = resultList;

            while (resultStringTemp != null)
            {
                resultString += resultStringTemp.val.ToString();
                resultStringTemp = resultStringTemp.next;
            }

            Console.Write(resultString);
        }
    }
}