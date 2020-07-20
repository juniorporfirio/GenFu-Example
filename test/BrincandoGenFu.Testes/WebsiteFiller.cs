using GenFu;
using GenFu.ValueGenerators.Internet;

namespace BrincandoGenFu.Testes
{
    public class WebsiteFiller : PropertyFiller<string>
    {
        public WebsiteFiller()
        : base(
            new[] { "object" },
            new[] { "website", "site", "web", "webaddress", "url" }
            )
        {

        }
        public override object GetValue(object instance)
        {
            var dominio = Domains.DomainName();
            return $"https://www.{dominio}";
        }
    }
}