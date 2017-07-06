using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassDatos sut = new ClassDatos();
            sut.texto = "Los numeros son: ";
            sut.entero1 = 7;
            sut.entero2 = 16;

            ClassMetodos sut2 = new ClassMetodos();

            String resultado = sut2.MetodoConcatenar(sut);
            Assert.AreEqual(resultado, "Los numeros son: 7 y 16");
        }
    }
}
