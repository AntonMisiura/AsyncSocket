namespace AsyncSocket
{
    class Program
    {
        public static int Main(string[] args)
        {
            AsynchronousSocketListener.StartListening();
            return 0;
        }
    }
}
