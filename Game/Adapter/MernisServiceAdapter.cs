using Game.Abstract;
using Game.Entity;
using MernisServiceReference;
namespace Game.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService //interface'den miras alır ve mernis ile doğrulama gerçeklenir.
        
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync
            (Convert.ToInt64(gamer.NationalityId), gamer.Name.ToUpper(), gamer.LastName.ToUpper(), Convert.ToInt32(gamer.DateOfBirth.Year)).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
