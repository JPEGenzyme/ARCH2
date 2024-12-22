pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'dotnet build ./SOAPServices/SOAPServices.sln'
                sh 'dotnet build ./RESTApi/RESTApi.sln'
                sh 'dotnet build ./Grpc/Grpc.sln'
            }
        }
        stage('Docker Build') {
            steps {
                sh 'docker-compose build'
            }
        }
        stage('Deploy') {
            steps {
                sh 'docker-compose up -d'
            }
        }
    }
}
