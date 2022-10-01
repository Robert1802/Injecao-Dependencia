namespace Com_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(new RecepcaoService());
            string resultado = controller.Ola("Roberto");
            Console.WriteLine(resultado);
        }
    }
}
