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
        private bool valor = false;
        public ServiciosRegistros(Interface1 dbPruebas)
        {
            db = dbPruebas;
        }

        public bool AñadirEnfermeros(Enfermero enfermero)
        {
            return db.RegistrarEnfermeros(enfermero);
        }

        public List<Enfermero> MostrarRegistro(string cuil)
        {
            var lista = db.ObtenerTodos();
            var resulatados = lista.Where(e => e.cuil == cuil).ToList();
            return resulatados;
        }
        public bool AñadirPacientes(Paciente paciente) 
        {
            return db.RegistrarPacientes(paciente);
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
