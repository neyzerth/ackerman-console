class Program 
{
    static void Main(String[] args)
    {   
        bool bandera;
        do
        {
            Console.Clear();
            ImprimirAckerman();
            bandera = validarContinuacion();
        } while (bandera);

        Console.WriteLine("\nAdios UwU ");
    }
    static void ImprimirAckerman(){
        int m = ValidarNumero("\tIngrese un numero del 0 al 3 para m: ");
        int n = ValidarNumero("\tIngrese un numero del 0 al 3 para n: ");

        Console.WriteLine($"\n\tAckerman({m},{n}) = " + Ackerman(m, n));
    }
    static int Ackerman(int m, int n)
    {
        //si m = 0 : n +1
        if (m == 0 ) return n + 1;
        //si m > 0 y n = 0 : acker([m-1], 1)
        if(m > 0 && n == 0) return Ackerman((m - 1),1);
        //si m > 0 y n > 0 : acker( [m-1], acker(m,[n-1]) )
        return Ackerman((m - 1), Ackerman(m ,(n - 1)));
    }

    static int ValidarNumero(String texto){
        int num = 0;

        Console.Write(texto); 

        int posx = Console.CursorLeft;
        int posy = Console.CursorTop;

        do{
            PrintXY(posx, posy, "                ");
            PrintXY(posx, posy, "");
            
            try {
                num = Int32.Parse(Console.ReadLine());
                
                //si se ingresa un numero valido, se rompe el ciclo
                if(num >= 0 && num  <= 3)
                    break; 

            } catch(Exception){
                Console.WriteLine("\tFavor de Ingresar Un Numero Valido");
                continue; //Continua el ciclo
            }
            Console.WriteLine("\tFavor de Ingresar Un Numero entre 0 y 3");

        } while (true);
        
        PrintXY(0, posy+1, "\t                                              ");
        PrintXY(0, posy+1, "");

        return num;
    }
    static void PrintXY(int x, int y, string text){
        Console.SetCursorPosition(x,y);
        Console.Write(text);
    }

    static bool validarContinuacion(){
        String respuesta;
        bool validacion;

        int posx = Console.CursorLeft;
        int posy = Console.CursorTop;

        do{
            PrintXY(posx, posy, "                ");
            PrintXY(posx, posy, "");
            Console.Write("\n\tDesea continuar? (S/n): ");
            respuesta = Console.ReadLine().ToLower();

            validacion = respuesta.Equals("s") || respuesta.Equals("n");
        } while (!validacion);

        return respuesta.Equals("s");
    }

}