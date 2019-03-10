using System;

namespace Abbriviation
{
    class Program
    {
        static bool isUpcase(char c)
        {
            return (c >= 'A') && (c <= 'Z');
        }

        static char upcase(char c)
        {
            if (isUpcase(c)) return c;
            return (char)(c - 32);
        }
        static string abbreviation(string s1, string s2)
        {
            bool[][] dp = new bool[1011][];
            for (int i = 0; i <= s1.Length; i++)
            {
                dp[i] = new bool[1011];
                for (int j = 0; j <= s2.Length; j++)
                {
                    dp[i][j] = false;
                }
            }
            dp[0][0] = true;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                    if (dp[i][j])
                    {
                        if (j < s2.Length && (upcase(s1[i]) == s2[j]))
                            dp[i + 1][j + 1] = true;
                        if (!isUpcase(s1[i]))
                            dp[i + 1][j] = true;
                    }
            }

            if (dp[s1.Length][s2.Length])
                    return "YES" ;
               else return "NO" ;
        }

        //static string abbreviation(string a, string b)
        //{            
        //    if (b.Length > a.Length)
        //        return "NO";
        //    if (a.Length == b.Length && a.ToUpper() != b)
        //        return "NO";
        //    int i = 0;
        //    int k = 0;
        //    string result = string.Empty;

        //    while (i < a.Length)
        //    {
        //        char c = ' ';

        //        if (k < b.Length)
        //        {
        //            if (a[i] == b[k])
        //            {
        //                c = a[i];
        //            }
        //            else if (Char.ToUpper(a[i]) == b[k])
        //            {
        //                c = Char.ToUpper(a[i]);
        //            }
        //            else if (i > 0 && a[i] == Char.ToUpper(a[i]) &&  Char.ToLower(a[i]) != a[ i -1])
        //            {
        //                return "NO";
        //            }
        //        }
        //        else if (a[i] == Char.ToUpper(a[i]) && result[result.Length -1] != a[i])
        //        {
        //            return "NO";
        //        }
        //        if (c != ' ')
        //        {
        //            result = result + c;
        //            k++;
        //        }                

        //        i++;            
        //    }
        //    if (result == b)
        //        return "YES";

        //    return "NO";


        //}
        static void Main(string[] args)
        {
            /*NO
NO
YES
NO
YES
NO
YES
YES
YES
YES*/

            // string a = "LLZOSYAMQRMBTZXTQMQcKGLR";
            //string b = "LLZOSYAMBTZXMQKLR";
            // string a = "MGYXKOVSMAHKOLAZZKWXKS";
            //string b = "MGXKOVSAHKOLZKKDP";
            //string a = "VLKHNlpsrlrvfxftslslrrh";
            // string b = "VLKHN";
            //string a = "OQSVONTNZMDJAVRZAZCVPKh";
            // string b = "OSVONTNZMDJAVRZAZCVPK";
            // string a = "AXbosoh";
            // string b =  "AX";
            // string a = "EYONDOCHNZYYlBZXPGzX";
            // string b = "EYONDOCHNZYYBZXPGXOG";
            // string a = "BJAFXKGENMFUvdsvcptrp";
            // string b = "BJAFXKGENMFU";
            // string a = "UBUFOOSIXXsdtfmeyongkhehq";
            // string b = "UBUFOOSIXX";
            //string a = "PWBIJLCOIAXGJGUXUZOutgic";
            // string b = "PWBIJLCOIAXGJGUXUZO";
            //string a = "EOWZEOHWYOJTBNMcefdsp";
            // string b = "EOWZEOHWYOJTBNM";


            //string a = "BFZZVHdQYHQEMNEFFRFJTQmNWHFVXRXlGTFNBqWQmyOWYWSTDSTMJRYHjBNTEWADLgHVgGIRGKFQSeCXNFNaIFAXOiQORUDROaNoJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMvSTGEQCYAJSFvbqivjuqvuzafvwwifnrlcxgbjmigkms";
            //string b = "BFZZVHQYHQEMNEFFRFJTQNWHFVXRXGTFNBWQOWYWSTDSTMJRYHBNTEWADLHVGIRGKFQSCXNFNIFAXOQORUDRONJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMSTGEQCYAJSF";

            string a = "bBccC";
            string b = "BBC";
            string result = abbreviation(a, b);

            Console.WriteLine(result.ToUpper());
            Console.ReadLine();
        }
    }
}
