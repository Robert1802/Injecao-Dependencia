
namespace Sem_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            string resultado = controller.Ola("Roberto");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}