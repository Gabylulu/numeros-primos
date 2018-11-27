namespace numerosPrimosTest{

    [TestClass]

    public class numerosPrimosTest
    {

        [TestMethod]
        public void NumeroPrimo()
        {
            //Arrange
            var resultado = 1;
            var Verificacion = new VerificarPrimos();
            //Act
            var retorna = Verificacion.EsPrimo(resultado);
            //Assert
            Assert.isFalse(retorna);
        }
    }
}