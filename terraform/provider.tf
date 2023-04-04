terraform {
  required_version = ">= 0.14.0"

  cloud {
    organization = "webstorm"

    workspaces {
      name = "pa-tsa-conference-app-api"
    }
  }

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~>3.0.0"
    }
  }
}

provider "azurerm" {
  features {}
}
