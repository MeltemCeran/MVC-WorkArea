using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.MyCustomTagHelper
{
    [HtmlTargetElement("login-form")]
    public class LoginTagHelper : TagHelper
    {
        public string KullaniciAdi { get; set; } = "admin";  // Doğru kullanıcı adı

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "form";  // Formu oluştur
            output.Attributes.SetAttribute("method", "post");
            output.Attributes.SetAttribute("action", "/MyCustomTagHelper/Giris");

            // Form içeriğini oluştur
            output.Content.SetHtmlContent($@"
                <label for='kullanici'>Kullanıcı Adı:</label>
                <input type='text' id='kullanici' name='kullaniciAdi' />
                <button type='submit'>Giriş Yap</button>
            ");
        }
    }
}
