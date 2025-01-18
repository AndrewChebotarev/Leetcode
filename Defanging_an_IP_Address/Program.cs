/*
    1108. Defanging an IP Address

    Given a valid (IPv4) IP address, return a defanged version of that IP address.

    A defanged IP address replaces every period "." with "[.]".

    Example 1:

    Input: address = "1.1.1.1"
    Output: "1[.]1[.]1[.]1"
    Example 2:

    Input: address = "255.100.50.0"
    Output: "255[.]100[.]50[.]0"
 

    Constraints:

    The given address is a valid IPv4 address.
*/

namespace Defanging_an_IP_Address
{
    public class Program
    {
        private static string address1 = "1.1.1.1";
        private static string address2 = "255.100.50.0";

        static void Main(string[] args)
        {
            Defanging_an_IP_Address defanging_An_IP_Address1 = new(address1);
            Defanging_an_IP_Address defanging_An_IP_Address2 = new(address2);
        }
    }
}
