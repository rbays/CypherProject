using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KeyPair
/// </summary>
public class KeyPair
{
    private int p;
    private int q;
    private int n;
    private int m;
    private int r;
    private int s;


    public static int[] primes = genPrimes();

    

    public KeyPair(int p, int q)
    {
        this.p = p;
        this.q = q;


        //
        // TODO: Add constructor logic here
        //
    }
    
    public static int[] genPrimes()
    {
        int[] primes = new int[10000];
        int index = 0;
        int number = 2;

        while (index < primes.Length)
        {
            bool isPrime = true;
            for (int i = 0; i< index; i++)
            {
                if (number % primes[i] == 0)
                {
                    isPrime = false;
                    number++;
                    continue;
                }
            }
            if (isPrime)
            {
                primes[index] = number;
                index++;
            }
            number++;
        }
        
        return primes;
    }
    
}