class Program 
{
    static void Main(String[] args)
    {

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
}