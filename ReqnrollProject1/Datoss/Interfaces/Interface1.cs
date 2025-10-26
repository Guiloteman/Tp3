using ReqnrollProject1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Datoss.Interfaces
{
    public interface Interface1
    {
        bool RegistrarEnfermeros(Enfermero enfermero);

        List<Enfermero> ObtenerTodos();
        bool RegistrarPacientes(Paciente paciente);
        List<Paciente> ObtenerPacientes();
        void RegistrarHistorias(HistoriaPaciente historiaPaciente);
        List<HistoriaPaciente> ObtenerHistorias();
    }
}
