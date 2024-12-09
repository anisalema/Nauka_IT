variable "filename" {
    default = "~/pets.txt"
    type = string
    description = "the path to local file"
}
variable "prefix" {
    default = "Mrs"
}
variable "separator" {
    default = "."
}
variable "length" {
    default = "1"
}

# Keyword variable 
# Name can be anything
# default - describes default value for terraform
# type (optional) - for example: string, number, bool, any, list, map, object, tuple
# description

#Type List:
variable "prefix" {
    default = ["Mr", "Mrs", "Sir"]
    type = list
}
#each value in the list has index (starting with 0) [like in C#]
variable "prefix" {
    default = ["Mr", "Mrs", "Sir"]
    type = list(string)
}
variable "prefix" {
    default = [1, 2, 3]
    type = list(number)
}
#lists can have types


#Type Map:
variable file-content {
    type = map
    default = {
        "statement1" = "We love pets!"
        "statement2" = "We love animals"
    }
}
#statement1 is a key and "we love pets" is a value
variable "cats" {
    default = {
        "color" = "brown"
        "name" = "bella"
    }
    type = map(string)
}
variable "pet_count" {
    default = {
        "dogs" = 3
        "cats" = 1
        "doldfish" = 2
    }
    type = map(number)
}
#maps can have types

#Type Set (like lists but can't have duplicate elements)
#right:
variable "prefix" {
    default = ["Mr", "Mrs", "Sir"]
    type = set(string)
}
#wrong:
variable "prefix" {
    default = ["Mr", "Mrs", "Sir", "Sir"]
    type = set(string)
}

#Type Objects: (all at once)
variable "bella" {
    type = object({
        name = string
        color = string
        age = number
        food = list(string)
        favourite_pet = bool
    })
    default = {
        name = "bella"
        color = "brown"
        age = 7
        food = ["fish", "chicken", "turkey"]
        favourite_pet = true
    }
}

#Type Tuples:
variable kitty {
    type = tuple([string, number, bool])
    default = ["cat", 7, true]
}







