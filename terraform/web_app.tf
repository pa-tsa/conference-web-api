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
  site_config {
    minimum_tls_version = "1.2"
  }
}
