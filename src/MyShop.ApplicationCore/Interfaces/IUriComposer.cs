using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApplicationCore.Interfaces
{
    public interface IUriComposer
    {
        string ComposeImageUri(string uriTemplate);
    }
}
