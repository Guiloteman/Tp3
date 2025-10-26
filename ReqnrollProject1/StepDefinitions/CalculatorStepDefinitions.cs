using Reqnroll;
using ReqnrollProject1.Datoss;
using ReqnrollProject1.Datoss.Interfaces;
using ReqnrollProject1.Modelo;
using System;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly Interface1 baseDeDatosReal;
        private readonly ServiciosRegistros servicios;
        
        public CalculatorStepDefinitions() 
        {
            baseDeDatosReal = new DbPruebas();
            servicios = new ServiciosRegistros(baseDeDatosReal);
        }

        [Given("que estan cargados al sistema los siguientes enfermeros:")]
        public void GivenQueEstanCargadosAlSistemaLosSiguientesEnfermeros(DataTable dataTable)
        {
            foreach (var item in dataTable.Rows)
            {
                var cuil = item["Cuil"];
                servicios.MostrarRegistro(cuil);
            }
        }

        [Given("que estan registrado al sistema los siguientes pacientes:")]
        public void GivenQueEstanRegistradoAlSistemaLosSiguientesPacientes(DataTable dataTable)
        {
            foreach (var item in dataTable.Rows)
            {
                var cuil = item["Cuil"];
                servicios.MostrarRegistroPacientes(cuil);
            }
        }


        [When("se ingresa el siguiente cuil:")]
        public void WhenSeIngresaElSiguienteCuil(DataTable dataTable)
        {
            foreach (var item in dataTable.Rows)
            {
                var cuil = item["Cuil"];
                servicios.MostrarRegistroHistorias(cuil);
            }
        }

        [Then("se muestra por los datos del paciente:")]
        public void ThenSeMuestraPorLosDatosDelPaciente(DataTable dataTable)
        {
            foreach (var item in dataTable.Rows)
            {
                var cuil = item["Cuil"];
                servicios.MostrarRegistroHistorias(cuil);
            }
        }
    }
}
