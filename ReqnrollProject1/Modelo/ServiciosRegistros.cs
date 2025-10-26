using ReqnrollProject1.Datoss;
using ReqnrollProject1.Datoss.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Modelo
{
    public class ServiciosRegistros
    {
        private Interface1 db;
        public ServiciosRegistros(Interface1 dbPruebas)
        {
            db = dbPruebas;
        }

        public void AñadirEnfermeros(Enfermero enfermero)
        {
            db.RegistrarEnfermeros(enfermero);
            Console.WriteLine($"[SERVICIO] Operación de registro completada para {enfermero.nombre}.");
        }

        public void MostrarRegistro(string cuil)
        {
            var lista = db.ObtenerTodos();
            foreach (var item in lista) 
            {
                if (item.cuil == cuil)
                {
                    Console.WriteLine(item);
                }
                else 
                {
                    throw new Exception("No se encuentra registrado");
                }
            }
        }
        public void AñadirPacientes(Paciente paciente) 
        {
            db.RegistrarPacientes(paciente);
        }

        public void MostrarRegistroPacientes(string cuil)
        {
            var lista = db.ObtenerPacientes();
            foreach (var item in lista)
            {
                if (item.cuil == cuil)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    throw new Exception("No se encuentra registrado");
                }
            }
        }

        public void AñadirHistorias(HistoriaPaciente historiaPaciente)
        {
            db.RegistrarHistorias(historiaPaciente);
        }

        public void MostrarRegistroHistorias(string cuil)
        {
            var lista = db.ObtenerHistorias();
            foreach (var item in lista)
            {
                Assert.AreEqual(cuil, item.paciente.cuil);       
            }
        }
    }
}
