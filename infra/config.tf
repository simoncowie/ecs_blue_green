##############################################################
provider "aws" {
  version = "~> 1.9"
  region  = "${var.region}"
  profile = "ecs_deploy_user"
}

provider "external" {
  version = "~> 1.0"
}

provider "null" {
  version = "~> 1.0"
}

provider "template" {
  version = "~> 1.0"
}

terraform {
  backend "local" {
    path = "state/terraform.tfstate"
  }
}

##############################################################

variable "region" {
    default = "ap-southeast-2"
}

variable "app_name" {
  default = "ecs_deploy"
}
