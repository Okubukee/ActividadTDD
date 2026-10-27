using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPractica;

namespace TDDPrueba;

[TestClass]
public class EsContrasenyaValidaTests
{
    [TestMethod]
    public void EsContrasenyaValida_Null_DevuelveFalse()
    {
        Assert.IsFalse(Funciones.EsContrasenyaValida(null));
    }

    [TestMethod]
    public void EsContrasenyaValida_Vacia_DevuelveFalse()
    {
        Assert.IsFalse(Funciones.EsContrasenyaValida(""));
    }

    [TestMethod]
    [DataRow("abc#")]
    [DataRow("abc#123")]      
    public void EsContrasenyaValida_MenosDe8Caracteres_DevuelveFalse(string contrasenya)
    {
        Assert.IsFalse(Funciones.EsContrasenyaValida(contrasenya));
    }

    [TestMethod]
    [DataRow("abcdefgh")]
    [DataRow("contrasenya123")]
    public void EsContrasenyaValida_SinAlmohadilla_DevuelveFalse(string contrasenya)
    {
        Assert.IsFalse(Funciones.EsContrasenyaValida(contrasenya));
    }

    [TestMethod]
    [DataRow("abcdefg#")]    
    [DataRow("MiClave#2026")]
    [DataRow("#empiezaconalmohadilla")]
    public void EsContrasenyaValida_CumpleTodasLasReglas_DevuelveTrue(string contrasenya)
    {
        Assert.IsTrue(Funciones.EsContrasenyaValida(contrasenya));
    }
}