resource "aws_ecr_repository" "ecs_deploy" {
  name = "${var.app_name}"
}
