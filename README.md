# NHN Authors Microservice

## Introduction
The NHN Authors Microservice is a component of the NHN project that exposes a group of endpoints to manage Authors. This microservice provides the ability to create, update, edit, and delete Authors within the NHN system.

## Features
- Create new Authors
- Update existing Authors
- Edit author details
- Delete Authors

## Endpoints
The following endpoints are available for managing Authors:
- POST / - create a new author
- PUT /{id} - update an existing author
- GET /{id} - retrieve details for a single author
- DELETE /{id} - delete a author
- GET / - retrieve a list of all Authors

## Requirements
- NHN project
- .NET 7 or later
- Docker
- Kubernetes

## Installation
To install and run the microservice, follow these steps:
1. Clone the repository:
    git clone https://github.com/nhn/Authors-microservice.git
2. Start the Docker container:
    docker run -p 5000:5000 -d nhn/Authors-microservice:latest

## Contributing
Contributions to the microservice are welcome. 💕

## License
This microservice is released under the MIT license.

## Troubleshooting
If you encounter any issues with the deployment or usage of the microservice, consult the troubleshooting guide for possible solutions.

## Credits
This microservice has been created by the NHN team as part of the NHN project.
