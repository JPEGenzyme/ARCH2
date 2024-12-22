pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build ./SOAPService/SOAPService.sln'
                bat 'dotnet build ./RESTApi/RESTApi.sln'
                bat 'dotnet build ./Grpc/Grpc.sln'
            }
        }
        stage('Docker Build') {
            steps {
                bat 'docker-compose build --no-cache'
            }
        }
        stage('Deploy') {
            steps {
                bat 'docker-compose up -d'
            }
        }
    }
}
