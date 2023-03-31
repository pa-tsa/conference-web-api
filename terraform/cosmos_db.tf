resource "azurerm_cosmosdb_account" "pa_tsa_conference_cosmosdb" {
  name                      = "pa-tsa-conference-cosmos"
  location                  = local.location
  resource_group_name       = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  offer_type                = "Standard"
  kind                      = "MongoDB"
  enable_automatic_failover = false

  capabilities {
    name = "EnableMongo"
  }

  capacity {
    total_throughput_limit = local.max_throughput
  }

  consistency_policy {
    consistency_level       = "BoundedStaleness"
    max_interval_in_seconds = 400
    max_staleness_prefix    = 200000
  }

  geo_location {
    location          = local.location
    failover_priority = 0
  }
}

resource "azurerm_cosmosdb_mongo_collection" "conference_events_collection" {
  account_name        = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.name
  database_name       = azurerm_cosmosdb_mongo_database.conference_app_cosmosdb.name
  name                = "conference-events"
  resource_group_name = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
}

resource "azurerm_cosmosdb_mongo_database" "conference_app_cosmosdb" {
  name                = "conference-app-cosmosdb"
  resource_group_name = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  account_name        = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.name
}
