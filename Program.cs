using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        string[] options = { "A", "B", "C", "D" };
        string msgFinal, option;
        int dia, mes, any;
        const string MsgCorrecte = "La data és correcta";
        const string MsgIncorrecte = "El format no és correcte";
        const string MsgInputDay = "Introdueix el dia: ";
        const string MsgInputMonth = "Introdueix el mes: ";
        const string MsgInputYear = "Introdueix el any: ";
        const string MsgInputOption = "Introdueix una opció: \nA. Saltar \nB. Córrer \nC. Ajupir-se \nD. Amagar-se";
        const string MsgJump = "Has saltat";
        const string MsgRun = "Has corregut";
        const string MsgDuck = "T'has ajupit";
        const string MsgHide = "T'has amagat";

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
        Console.WriteLine();
        do
        {
            Console.WriteLine(MsgInputOption);
            option = Console.ReadLine().ToUpper();
        } while (!ValidateMenuOption(option, options));
        switch (option)
        {
            case "A":
                Console.WriteLine(MsgJump);
                break;
            case "B":
                Console.WriteLine(MsgRun);
                break;
            case "C":
                Console.WriteLine(MsgDuck);
                break;
            case "D":
                Console.WriteLine(MsgHide);
                break;
        }
    }
    public static bool ValidateMenuOption(string option, string[] options)
    {
        return options.Contains(option);
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