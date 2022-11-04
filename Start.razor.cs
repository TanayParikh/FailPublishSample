using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Routing;

namespace FailPublishSample
{
    public partial class Start
    {
        protected override void OnInitialized()
        {
            MessageBox.Show($"Initialized.");
        }
    }
}