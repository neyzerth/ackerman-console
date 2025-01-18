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

        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
    }
    static void ImprimirAckerman()
    {
        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
        Console.WriteLine("\nAdios aaaaaaaaaaaaaaaaaaaaaaa");
        int m = ValidarNumero("\tIngrese un numero del 0 al 3 para m: ");
        int n = ValidarNumero("\tIngrese un numero del 0 al 3 para n: ");

        //$"" permite interpolacion, es decir,
        //permite concatenar variables dentro del texto
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

    //El parametro texto es el mensaje que se mostrara 
    //al usuario antes de leer el numero
    static int ValidarNumero(String texto)
    {
        int num = 0;

        Console.Write(texto); 

        // guardar posicion del cursor antes de leer el numero
        int posx = Console.CursorLeft;
        int posy = Console.CursorTop;

        do
        {
            // borrar lo que se haya escrito por teclado
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
        
        //Borra la linea de abajo (donde se imprimen los errores)
        PrintXY(0, posy+1, "\t                                              ");
        PrintXY(0, posy+1, "");

        return num;
    }
    static bool validarContinuacion()
    {
        String respuesta;
        bool validacion;

        // guardar posicion del cursor antes de leer el numero
        int posx = Console.CursorLeft;
        int posy = Console.CursorTop;

        do{
            // borrar lo que se haya escrito por teclado
            PrintXY(posx, posy, "                ");
            PrintXY(posx, posy, "");
            Console.Write("\n\tDesea continuar? (S/n): ");
            respuesta = Console.ReadLine().ToLower();

            //validar que escribio S o N
            validacion = respuesta.Equals("s") || respuesta.Equals("n");
        } while (!validacion);

        return respuesta.Equals("s");
    }
    static void PrintXY(int x, int y, string text)
    {
        Console.SetCursorPosition(x,y);
        Console.Write(text);
    }  

}