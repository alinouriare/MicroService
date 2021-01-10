using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Configurations
{
    public class Translator
    {
        public string CultureInfo { get; set; } = "en-Us";
        public string TranslatorTypeName { get; set; }
        public Parrottranslator Parrottranslator { get; set; }
    }


    public class Parrottranslator
    {
        public string ConnectionString { get; set; }
        public string SelectCommand { get; set; } = "Select * from ParrotTranslations";
        public string InsertCommand { get; set; } = "INSERT INTO [dbo].[ParrotTranslations]([Key],[Value],[Culture]) VALUES (@Key,@Value,@Culture) select SCOPE_IDENTITY()";
    }
}
