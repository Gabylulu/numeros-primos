namespace numerosPrimosTest{

    [TestClass]

    public class numerosPrimosTest
    {

        [TestMethod]
        public void NumeroPrimo()
        {
            //Arrange
            var resultado = 0;
            var Verificacion = new VerificarPrimos();
            //Act
            var retorna = Verificacion.EsPrimo(resultado);
            //Assert
            Assert.isFalse(retorna);
        }
    }
}