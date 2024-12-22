pipeline {
    agent any
    stages {
        stage('Build') {
            // steps {
            //     bat 'dotnet build ./SOAPServices/SOAPServices.sln'
            //     bat 'dotnet build ./RESTApi/RESTApi.sln'
                bat 'dotnet build ./Grpc/Grpc.sln'
            }
        }
        stage('Docker Build') {
            steps {
                bat 'docker-compose build'
            }
        }
        stage('Deploy') {
            steps {
                bat 'docker-compose up -d'
            }
        }
    }
}
