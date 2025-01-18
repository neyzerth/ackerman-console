using System;
class Program 
{
    static void Main(String[] args)
    {
        MainMenu();
    }

    // ulong es un int de 64 bits (System.Int64)
    // pero solo toma los valores positivos
    // valor max aprox 1.8x10^20
    static ulong Ackerman(int m, int n)
    {
        //si m = 0         : n +1
        //si m > 0 y n = 0 : acker([m-1], 1)
        //si m > 0 y n > 0 : acker([m-1], acker(m,[m-1]))
        
        return 0; //temporal
    }

    public static void MainMenu(){
        bool validacion;

        do
        {
            Console.Clear();
            PrintXY(10,1,"Ackermann");
            try
            {
                validacion = Solicitar();
            }
            catch (System.Exception)
            {
                validacion = false;
            }
        } while (!validacion);
    }
    public static bool Solicitar(){
        int m = 0, n = 0;
            bool validacion;

            for (int i = 0; i < 2; i++)
            {
                do
                {
                    PrintXY(10, i+3,"                                                                 ");
                    PrintXY(10, i+3,"Ingrese un número del 0 al 3 para " + Convert.ToChar(109 + i) + ": ");
                    try
                    {
                        if (i == 0){
                            m = Int32.Parse(Console.ReadLine());
                            validacion = ValidarNumero(m);
                        }
                        else{
                            n = Int32.Parse(Console.ReadLine());
                            validacion = ValidarNumero(n);
                        }
                    }
                    catch (System.Exception)
                    {
                        validacion = false;
                    }
                } while (!validacion);
            }
        CalcularAckermann(m,n);
        validacion = Continuar();
        
        return validacion;
    }
    public static bool ValidarNumero(int numero){
        return numero >= 0 && numero <= 3;
    }
    public static void CalcularAckermann(int m, int n){
        PrintXY(10,6,"Ackermann(" + m + "," + n + ") = resultado");
    }
    public static void PrintXY(int x, int y, string text){
        Console.SetCursorPosition(x,y);
        Console.Write(text);
    }
    public static bool Continuar(){
        bool validacion = true;
        string respuesta;

        do{
            PrintXY(10, 8,"                                                                 ");
            PrintXY(10, 8, "¿Desea realizar otro cálculo? (s/n): ");
            respuesta = Console.ReadLine().ToLower();
        }while (!(respuesta == "s" || respuesta == "n"));

        if (respuesta == "s")
            validacion = false;

        return validacion;
    }
}