using Cajero_Automático;
using System.Net.NetworkInformation;

CuentaBancaria cuentaBancaria = new CuentaBancaria();
cuentaBancaria.Numero = 1;
cuentaBancaria.Titular = "Danny";
cuentaBancaria.Saldo = 5000;
cuentaBancaria.Pin = "1234";

CajeroAutomatico cajeroAutomatico = new CajeroAutomatico
{
    Numero = 2,
    Titular = "Adrian",
    Saldo = 6000,
    Pin = "7890"
};

do
{
    Console.WriteLine("CAJERO AUTOMÁTICO");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Depositar fondos");
    Console.WriteLine("3. Retirar efectivo");
    Console.WriteLine("4. Cambiar PIN");
    Console.WriteLine("");
    Console.WriteLine("Escoge la operación:");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("");
            Console.WriteLine("Tu saldo es: " + cajeroAutomatico.ConsultarSaldo());
            break;

        case "2":
            Console.WriteLine("");
            Console.WriteLine("Tu saldo actual " + cajeroAutomatico.Saldo);
            Console.WriteLine("Ingrese cuánto quiere depositar:");
            string Adicional = Console.ReadLine();
            double SaldoFinal = double.Parse(Adicional);

            
            cajeroAutomatico.Saldo += SaldoFinal;
            Console.WriteLine("Tu saldo modificado: " + cajeroAutomatico.Saldo);
            break;

        case "3":
            Console.WriteLine("");
            Console.WriteLine("Tu saldo actual " + cajeroAutomatico.Saldo);
            Console.WriteLine("Ingrese cuánto quiere retirar:");

            string Entrada = Console.ReadLine();
            double Retiro = double.Parse(Entrada);

            if (cajeroAutomatico.Saldo > Retiro)
            {
                cajeroAutomatico.Saldo -= Retiro;
                Console.WriteLine("Tu saldo modificado: " + cajeroAutomatico.Saldo);
            }
            else
            {
                Console.WriteLine("No puedes retirar más dinero del que tienes.");
            }
            break;

        case "4":
            // TODO: Si se equivoca 3 veces, se debe bloquear y mandar a inicio
            Console.WriteLine("");
            Console.WriteLine("Pin actual " + cajeroAutomatico.Pin);
            Console.WriteLine("Ingrese su nuevo PIN:");
            string NewPin = cajeroAutomatico.CambiarPin(Console.ReadLine());

            if (cajeroAutomatico.Pin != NewPin)
            {
                cajeroAutomatico.Pin = NewPin;
                Console.WriteLine("Nuevo Pin: " + cajeroAutomatico.Pin);
            }
            else
            {
                Console.WriteLine("No puedes insertar el PIN actual.");
            }
            break;

        default:
            Console.WriteLine("");
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            break;
    }
} while (true);