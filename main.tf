terraform {
  required_version = ">= 0.12"
}

# all providers: 
# https://registry.terraform.io/providers/hashicorp/local/latest/docs


resource "local_file" "pet" {
    filename = "/root/pets.txt"
    content = "We love pets!"
}
# resource - Block Name
# "local_file" - Resource Type
#   - provides information:
#       - local=provider
#       - file = resource
# "pet" - Resource Name
# Arguments:
# filename = "/root/pets.txt"
# content = "We love pets!"

# Other examples:

#1 - setting up instance in AWS
resource "aws_instance" "webserver" {
    ami = "ami-0279e67fd707sd07890"
    instance_type = "t2.micro"
}

#2 - creating aws-s3 bucket
resource "aws_s3_bucket" "data" {
    bucket = "webserver-bucket-org-2207"
    acl = "private"
}

#3 - multiple providers
resource "local_file" "pet" {
    filename = "~/pets.txt"
    content = "We love pets!"
}
resource "random_pet" "my-pet" {
    prefix = "Mrs"
    separator = "."
    length = "1"
}

#WHAT IS ABOVE + VARIABLES.TF 
resource "local_file" "pet" {
    filename = var.filename
    content = var.content["statement2"]
}
resource "random_pet" "my-pet" {
    prefix = var.prefix[0]
    separator = var.separator
    length = var.length
}
#var.name używa variables
#how to use index shown in prefix above
#how to use map type shown above






