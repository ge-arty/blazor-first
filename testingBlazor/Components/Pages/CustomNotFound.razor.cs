﻿using Microsoft.AspNetCore.Components;
namespace testingBlazor.Components.Pages { 

  public partial class CustomNotFound{
      [Inject]
     public NavigationManager NavigationManager { get; set; }
     public void NavigateToHome()
     {
        NavigationManager.NavigateTo("/");
     }
   }
}