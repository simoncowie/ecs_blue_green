FROM microsoft/dotnet:2.2-sdk AS builder

WORKDIR /code

# Compile
COPY ./EcsDeploys ./EcsDeploys/
RUN dotnet publish ./EcsDeploys --configuration Release --output /app

#copy the run script
COPY ./run.sh /app/

FROM microsoft/dotnet:2.2-aspnetcore-runtime

# copy the app
WORKDIR /app
COPY --from=builder /app .

#expose port for webserver
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

# metadata
LABEL app="EcsDeploys"

ENTRYPOINT ["/bin/bash", "-c", "./run.sh"]