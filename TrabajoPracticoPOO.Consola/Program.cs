﻿using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Ioc;
using TrabajoPracticoPOO.Servicios;
using TrabajoPracticoPOO.Utilidades;

namespace TrabajoPracticoPOO.Consola
{
    internal class Program
    {

        //static List<Cliente> clientes = new List<Cliente>();
        private static IServiceProvider? serviceProvider;
        private static IServiceCliente? servicioCliente;

        static void Main()
            {
            serviceProvider = DI.Configurar();
            servicioCliente = serviceProvider.GetRequiredService<IServiceCliente>();
            //clientes.Add(new SocioPremium { nombre = "Eustaquio", DNI = "20181209", fechaAlta = new DateTime(2023, 3, 10), localidad = Localidad.Lobos });

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("menú gimnasio");
                Console.WriteLine("1. Alta de cliente");
                Console.WriteLine("2. Baja de cliente");
                Console.WriteLine("3. Modificación de cliente");
                Console.WriteLine("4. Buscar cliente por DNI");
                Console.WriteLine("5. Listar todos los clientes");
                Console.WriteLine("6. Mostrar por tipo de cliente");
                Console.WriteLine("0. Salir");
                opcion = ExtensionesConsola.PedirEntero("Seleccione una opción: ", 0, 6);

                switch (opcion)
                {
                    case 1:
                        AltaCliente();
                        break;
                    case 2:
                        BajaCliente();
                        break;
                    case 3:
                        ModificarCliente();
                        break;
                    case 4:
                        BuscarCliente();
                        break;
                    case 5:
                        ListarClientes();
                        break;
                    case 6:
                        FiltrarPorTipo();
                        break;
                    case 0:
                        Console.WriteLine("Finalizanddo");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar!!!");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static void AltaCliente()
        {
            Console.WriteLine("Alta Cliente");
            string dni = ExtensionesConsola.PedirDni("Ingrese DNI: ").ToString();

             var existe = servicioCliente!.BuscarPorNombre(dni).EsValido == false;
            if (!existe)
            {
                Console.WriteLine("Ya existe un cliente con ese DNI.");
                return;
            }

            string nombre = ExtensionesConsola.PedirString("Nombre: ");
            DateTime fechaAlta;
            while (!DateTime.TryParse(ExtensionesConsola.PedirString("Fecha de alta (yyyy-mm-dd): "), out fechaAlta))
            {
                Console.WriteLine("Fecha inválida, nula o mayor a la actual!!!");
            }

            int tipo = ExtensionesConsola.PedirEntero("Tipo de cliente: 1-Común, 2-Premium, 3-Corporativo\n", 1, 3);

            Cliente nuevoCliente = tipo switch
            {
                1 => new SocioComun(),
                2 => new SocioPremium(),
                3 => new SocioCorporativo(),
                _ => null
            };

            if (nuevoCliente == null)
            {
                Console.WriteLine("El tipo de cliente ingresado es inválido.");
                return;
            }

            nuevoCliente.DNI = dni;
            nuevoCliente.nombre = nombre;
            nuevoCliente.fechaAlta = fechaAlta;
            nuevoCliente.localidad = ExtensionesConsola.SeleccionarEnum<Localidad>(
                "Localidades disponibles: ", "Seleccione la localidad: ");

            var resultado = servicioCliente.Agregar(nuevoCliente);
            if (!resultado.EsValido)
            {
                foreach (var error in resultado.Errores)
                    Console.WriteLine("Error: " + error);
                return;
            }

            Console.WriteLine("Cliente agregado!!!");
        }

        static void BajaCliente()
        {
            string dni = ExtensionesConsola.PedirDni("Ingrese el DNI del cliente a eliminar: ").ToString();
            var resultado = servicioCliente!.EliminarCliente(dni);
            if (resultado.EsValido)
                Console.WriteLine("Cliente eliminado!!!");
            else
                Console.WriteLine(string.Join(", ", resultado.Errores));
        }

        static void ModificarCliente()
        {
             string dni = ExtensionesConsola.PedirDni("Ingrese el DNI del cliente a modificar: ").ToString();
            var cliente = servicioCliente!.ListarTodos().FirstOrDefault(c => c.DNI == dni);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return;
            }

            string nuevoNombre = ExtensionesConsola.PedirString("Nuevo nombre (dejar en blanco para no modificar): ", false);
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
                cliente.nombre = nuevoNombre;

            string nuevaFechaStr = ExtensionesConsola.PedirString("Nueva fecha de alta (yyyy-mm-dd, dejar en blanco para no modificar): ", false);
            if (!string.IsNullOrWhiteSpace(nuevaFechaStr))
            {
                if (DateTime.TryParse(nuevaFechaStr, out DateTime nuevaFecha))
                    cliente.fechaAlta = nuevaFecha;
                else
                    Console.WriteLine("Fecha inválida. No se modificó la fecha.");
            }

            cliente.localidad = ExtensionesConsola.SeleccionarEnum<Localidad>(
                "Localidades disponibles:", "Seleccione la localidad: ");

              servicioCliente.EliminarCliente(dni);
            var resultado = servicioCliente.Agregar(cliente);
            if (!resultado.EsValido)
            {
                foreach (var error in resultado.Errores)
                    Console.WriteLine("Error: " + error);
                return;
            }

            Console.WriteLine("Cliente modificado correctamente!!!");
        }

        static void BuscarCliente()
        {
            string dni = ExtensionesConsola.PedirDni("Ingrese el DNI del cliente: ").ToString();
            var cliente = servicioCliente!.ListarTodos().FirstOrDefault(c => c.DNI == dni);
            if (cliente != null)
                MostrarCliente(cliente);
            else
                Console.WriteLine("Cliente no encontrado.");
        }

        static void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("Lista de clientes");
            foreach (var item in servicioCliente!.ListarTodos())
                Console.WriteLine(item.MostrarDatos());
        }

        static void FiltrarPorTipo()
        {
            int tipo = ExtensionesConsola.PedirEntero("Seleccione tipo: 1-Común, 2-Premium, 3-Corporativo\n", 1, 3);

            Type tipoSeleccionado = tipo switch
            {
                1 => typeof(SocioComun),
                2 => typeof(SocioPremium),
                3 => typeof(SocioCorporativo),
                _ => null
            };

            if (tipoSeleccionado == null)
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            var filtrados = servicioCliente!.BuscarPorTipo(tipoSeleccionado);
            foreach (var c in filtrados)
                MostrarCliente(c);
        }

        static void MostrarCliente(Cliente c)
        {
            Console.WriteLine($"Nombre: {c.nombre}, DNI: {c.DNI}, Tipo: {c.GetType().Name}, Servicio: {c.servicio}, Pago Mensual: ${c.CalcularGastoMensual()}");
        }
    }

}

