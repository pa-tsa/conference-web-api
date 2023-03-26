resource "azurerm_cosmosdb_account" "pa_tsa_conference_cosmosdb" {
  name                      = "pa-tsa-conference-cosmosdb"
  location                  = local.location
  resource_group_name       = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  offer_type                = "Standard"
  kind                      = "GlobalDocumentDB"
  enable_automatic_failover = false

  backup {
    interval_in_minutes = 240
    retention_in_hours  = 8
    storage_redundancy  = "Geo"
    type                = "Periodic"
  }

  capacity {
    total_throughput_limit = 1000
  }

  consistency_policy {
    consistency_level       = "BoundedStaleness"
    max_interval_in_seconds = 300
    max_staleness_prefix    = 100000
  }

  geo_location {
    location          = local.location
    failover_priority = 0
  }
}
