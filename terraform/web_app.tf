resource "azurerm_service_plan" "pa_tsa_conference_app_api" {
  name                = "pa-tsa-conference-app-api-asp"
  location            = azurerm_resource_group.pa_tsa_conference_app_api_rg.location
  resource_group_name = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  os_type             = "Linux"
  sku_name            = "B1"
}

resource "azurerm_linux_web_app" "pa_tsa_conference_app_api" {
  name                = "pa-tsa-conference-app-api-app"
  location            = azurerm_resource_group.pa_tsa_conference_app_api_rg.location
  resource_group_name = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  service_plan_id     = azurerm_service_plan.pa_tsa_conference_app_api.id
  https_only          = true

  app_settings = {
    "ApiKey"                           = var.api_key
    "ConferenceDatabase__DatabaseName" = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.name
  }

  connection_string {
    name  = "MongoDb"
    type  = "Custom"
    value = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.connection_strings.0
  }

  site_config {
    app_command_line    = "dotnet PaTsa.Conference.App.Api.WebApi.dll"
    minimum_tls_version = "1.2"

    application_stack {
      dotnet_version = "7.0"
    }
  }
}
