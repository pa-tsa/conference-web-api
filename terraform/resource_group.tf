resource "azurerm_resource_group" "pa_tsa_conference_app_api_rg" {
  name     = "pa-tsa-conference-app-api"
  location = local.location
}
