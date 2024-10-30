using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.MyCustomTagHelper
{
    [HtmlTargetElement("stok-durumu")]
    public class StokTagHelper : TagHelper
    {
        public int Stok { get; set; }  // Kullanıcı stok değerini girecek

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";  // h2 etiketi ile mesaj gösteriyoruz

            // Renk ve içerik belirleme
            string renk;
            string mesaj;

            if (Stok > 20)
            {
                renk = "green";
                mesaj = $"Stok Durumu: {Stok} adet - Yeterli stok var.";
            }
            else if (Stok > 10)
            {
                renk = "orange";
                mesaj = $"Stok Durumu: {Stok} adet - Kritik stok seviyesi!";
            }
            else
            {
                renk = "red";
                mesaj = $"Stok Durumu: {Stok} adet - Stok yetersiz!";
            }

            output.Attributes.SetAttribute("style", $"color:{renk};");
            output.Content.SetContent(mesaj);
        }
    }
}