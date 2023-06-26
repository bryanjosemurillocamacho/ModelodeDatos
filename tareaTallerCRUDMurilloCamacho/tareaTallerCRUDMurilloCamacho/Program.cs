using tareaTallerCRUDMurilloCamacho.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new ApplicationDbContext())
        {
            // Crear un nuevo cliente
            Cliente nuevoCliente = new Cliente
            {
                Nombre = "Bryan",
                Apellido = "Murillo",
                Direccion = "alborada",
                Telefono = "0999172645",
                FechaNacimiento = new DateTime(2001, 2, 14),
                Estado = "Activo"
            };
            context.Clientes.Add(nuevoCliente);
            context.SaveChanges();

            // Consultar un cliente por su ID
            int clienteId = nuevoCliente.Id;
            Cliente clienteConsultado = context.Clientes.Find(clienteId);
            if (clienteConsultado != null)
            {
                Console.WriteLine($"Cliente consultado: {clienteConsultado.Nombre} {clienteConsultado.Apellido}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
            }

            // Modificar un cliente existente
            Cliente clienteModificado = context.Clientes.Find(clienteId);
            if (clienteModificado != null)
            {
                clienteModificado.Nombre = "Juan";
                clienteModificado.Apellido = "Alvarado";
                context.SaveChanges();
                Console.WriteLine("Cliente modificado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
            }

            // Eliminar un cliente
            Cliente clienteEliminado = context.Clientes.Find(clienteId);
            if (clienteEliminado != null)
            {
                context.Clientes.Remove(clienteEliminado);
                context.SaveChanges();
                Console.WriteLine("Cliente eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
            }
        }

        Console.ReadLine();
    }
}
