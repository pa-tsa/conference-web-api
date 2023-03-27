resource "azurerm_cosmosdb_account" "pa_tsa_conference_cosmosdb" {
  name                      = "pa-tsa-conference-cosmos"
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
    total_throughput_limit = local.max_throughput
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

resource "azurerm_cosmosdb_sql_container" "schedule_container" {
  name                  = "schedule-container"
  resource_group_name   = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  account_name          = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.name
  database_name         = azurerm_cosmosdb_sql_database.conference_app_cosmosdb.account_name
  partition_key_path    = "/definition/id"
  partition_key_version = 1
}

resource "azurerm_cosmosdb_sql_database" "conference_app_cosmosdb" {
  name                = "conference-app-cosmosdb"
  resource_group_name = azurerm_resource_group.pa_tsa_conference_app_api_rg.name
  account_name        = azurerm_cosmosdb_account.pa_tsa_conference_cosmosdb.name
}
