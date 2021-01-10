using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Services.Translations
{
   public interface ITranslator
    {
        string this[string name]
        {
            get;
            set;
        }
        string this[string name, params string[] arguments]
        {
            get;
            set;
        }
        string GetString(string name);
        string GetString(string name, params string[] arguments);
    }
}
