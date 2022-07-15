/* Program Kalkulator
 * (beta)
 */
    
using System;
using System.IO;

public class Kalkulator
{
    public static void Main(string[] args)
    {
        
        float hasil = 0;
        char op;
        int a, b;
        
        Console.WriteLine("Kalkulator");
        Console.WriteLine("==========\n");
        
        Console.Write("> Angka Pertama \t: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("> Operator \t\t\t: ");
        op = Convert.ToChar(Console.ReadLine());
        
        Console.Write("> Angka Kedua \t\t: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        switch (op) {
			
            case '+' :
            hasil = a + b;
            break;
            
            case '-' :
            hasil = a - b;
            break;
            
            case 'x' :
            hasil = a * b;
            break;
            
            case '/' :
            if (b == 0) {
                Console.WriteLine("Error : Pembagian oleh nol.");
            } else {
                hasil = (float) a / b;
            }
            break;
            
            default :
                Console.WriteLine("Error : Operator tidak dikenali.");
                break;
				
        }
        
        Console.WriteLine("\n\n\n> Hasil \t\t\t: {0}", hasil);
        
        Console.ReadLine();
        
    }
}