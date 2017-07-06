using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar1;
namespace UnitTestProject1
{
    [TestClass]
    public class ClassMetodosTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassDatos objeto_datos = new ClassDatos();
            objeto_datos.texto = "Los numeros son: ";
            objeto_datos.entero1 = 7;
            objeto_datos.entero2 = 16;

            ClassMetodos sut = new ClassMetodos();

            String resultado = sut.MetodoConcatenar(objeto_datos);
            Assert.AreEqual(resultado, "Los numeros son: 7 y 16");
        }
    }
}
