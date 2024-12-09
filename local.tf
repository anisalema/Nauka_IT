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








