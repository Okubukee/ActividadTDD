using TDDPractica;

namespace TDDPrueba
{
    [TestClass]
    public class CalcularFactorialTests
    {
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-100)]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno(int n)
        {
            long resultado = Funciones.CalcularFactorial(n);

            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            long resultado = Funciones.CalcularFactorial(0);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        [DataRow(1, 1L)]
        [DataRow(2, 2L)]
        [DataRow(5, 120L)]
        [DataRow(10, 3628800L)]
        [DataRow(20, 2432902008176640000L)]
        public void CalcularFactorial_NumeroPositivo_DevuelveFactorialCorrecto(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
