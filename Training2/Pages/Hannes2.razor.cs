using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training2.Pages
{
    public partial class Hannes2
    {
        public int MyProperty { get; set; } = 12;
      
        public Hannes2()
        {
        
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
         
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
    }
}
