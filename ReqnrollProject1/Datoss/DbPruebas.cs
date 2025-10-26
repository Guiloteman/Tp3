using ReqnrollProject1.Datoss.Interfaces;
using ReqnrollProject1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReqnrollProject1.Datoss
{
    public class DbPruebas: Interface1
    {
        List<Enfermero> enfermeros;
        Enfermero e;
        List<Paciente> pacientes;
        Paciente p;
        List<HistoriaPaciente> historiaPacientes;
        HistoriaPaciente hp;
        public DbPruebas()
        {
            enfermeros = new List<Enfermero>();
            e = new Enfermero { nombre = "Ana", apellido = "Andinok", cuil = "27-20345678-8" };
            pacientes = new List<Paciente>();
            p = new Paciente { nombre = "Guido", apellido = "Kaczka", cuil = "20-25123456-3" };
            historiaPacientes = new List<HistoriaPaciente>();
            hp = new HistoriaPaciente { paciente=p, consulta= "Dolor en la zona pélvica", fecha= "12-10-2025" };
        }
        public void RegistrarEnfermeros(Enfermero enfermero)
        {
            enfermeros.Add(e);
        }

        public List<Enfermero> ObtenerTodos()
        {
            return enfermeros;
        }
        public void RegistrarPacientes(Paciente paciente)
        {
            enfermeros.Add(e);
        }

        public List<Paciente> ObtenerPacientes() { return pacientes; }

        public void RegistrarHistorias(HistoriaPaciente historiaPaciente) 
        {
            historiaPacientes.Add(historiaPaciente);
        }

        public List<HistoriaPaciente> ObtenerHistorias() { return historiaPacientes; }
    }
}
