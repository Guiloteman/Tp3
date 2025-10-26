using ReqnrollProject1.Datoss;
using ReqnrollProject1.Datoss.Interfaces;
using ReqnrollProject1.Modelo;

namespace ReqnrollProject1;

[TestClass]
public class Test1
{
    Enfermero enfermero;
    Interface1 db;
    ServiciosRegistros servicios;
    Paciente paciente;
    public Test1() 
    {
        enfermero = new Enfermero();
        db = new DbPruebas();
        servicios = new ServiciosRegistros(db);
        paciente = new Paciente();
    }
    [TestMethod]
    public void TestMethod1()
    {
        enfermero.nombre = "carlos";
        enfermero.apellido = "bolaños";
        enfermero.cuil = "20-12345678-3";   
        Assert.IsTrue(servicios.AñadirEnfermeros(enfermero));
    }

    public void TestMethod2()
    {
        var cuil = servicios.MostrarRegistro(enfermero.cuil);
        Assert.AreEqual(enfermero.cuil, cuil.FirstOrDefault().cuil.ToString());
    }

    public void TesTMethod3() 
    {
        paciente.nombre = "Yesica";
        paciente.apellido = "Antollini";
        paciente.cuil = "23-35999999-8";
        Assert.IsTrue(servicios.AñadirPacientes(paciente));
    }
}
