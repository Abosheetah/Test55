#pragma checksum "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\Pages\FetchData3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2888afcbd6e611b1b8e3ca44b4a553a08b4cca1c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MamSH.AlArishUniversityTest.Clint.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using MamSH.AlArishUniversityTest.Clint.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\_Imports.razor"
using MamSH.AlArishUniversityTest.Clint.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\Pages\FetchData3.razor"
using MamSH.AlArishUniversityTest.Clint.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata3")]
    public partial class FetchData3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Muhammad\source\repos\MamSH.AlArishUniversityTest\MamSH.AlArishUniversityTest.Clint\Client\Pages\FetchData3.razor"
       
    private Student student;

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        student = await Http.GetFromJsonAsync<Student>("api/Students/1");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
