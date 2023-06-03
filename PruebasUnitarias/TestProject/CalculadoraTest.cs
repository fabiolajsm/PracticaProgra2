using FuncionesPrueba;

namespace TestProject
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange: Organizar (inicializar variables)
            int numA = 2;
            int numB = 3;
            // Act: actuar, ejecutamos la función.
            int resultado = Calculadora.Sumar(numA, numB);

            // Assert: comprobar el valor esperado
            Assert.Equals(5, resultado);
        }
    }
}