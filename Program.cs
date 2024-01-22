using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        string msgFinal;
        int dia, mes, any;
        const string MsgCorrecte = "La data és correcta";
        const string MsgIncorrecte = "El format no és correcte";
        const string MsgInputDay = "Introdueix el dia: ";
        const string MsgInputMonth = "Introdueix el mes: ";
        const string MsgInputYear = "Introdueix el any: ";

        Console.Write(MsgInputDay);
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write(MsgInputMonth);
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write(MsgInputYear);
        any = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        msgFinal = valida(dia, mes, any) ? MsgCorrecte : MsgIncorrecte;
        Console.WriteLine(msgFinal);
    }

    public static bool valida(int day, int month, int year)
    {
        int totalDaysMonth = 0;
        switch (month)
        {
            case 1:
                totalDaysMonth = 31;
                break;

            case 3:
                totalDaysMonth = 31;
                break;

            case 5:
                totalDaysMonth = 31;
                break;

            case 7:
                totalDaysMonth = 31;
                break;

            case 8:
                totalDaysMonth = 31;
                break;

            case 10:
                totalDaysMonth = 31;
                break;

            case 12:
                totalDaysMonth = 31;
                break;

            case 4:
                totalDaysMonth = 30;
                break;

            case 6:
                totalDaysMonth = 30;
                break;

            case 9:
                totalDaysMonth = 30;
                break;

            case 11:
                totalDaysMonth = 30;
                break;

            case 2:
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    totalDaysMonth = 29;
                }
                else
                {
                    totalDaysMonth = 28;
                }
                break;
        }
        if ((month < 1 || month > 12) || (day < 1) || (day > totalDaysMonth))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}