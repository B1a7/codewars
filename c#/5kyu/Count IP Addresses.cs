// Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).

// All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.

// Examples
// * With input "10.0.0.0", "10.0.0.50"  => return   50 
// * With input "10.0.0.0", "10.0.1.0"   => return  256 
// * With input "20.0.0.10", "20.0.1.0"  => return  246
// using System.Net;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

             static long IpsBetween(string start, string end)
            {
                long ip1 = (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);
                long ip2 = (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address);
                long result = ip2- ip1;
                return result;
            }
        }
    }
}