using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Services.Test
{
    [TestClass]
    public class UnitTestToken
    {
        [TestMethod]
        public void GerandoToken()
        {
            User user = new User("Filipe","asdf1234!","filipe@abax.com.br");
            string privateKey = "ASDFwqeFASDFasddfkj@#42@1";
            TokenService tokenService = new TokenService(user,privateKey);
            string token = tokenService.GenerateToken();
            Assert.AreNotEqual(token, string.Empty);
        }
    }
}
