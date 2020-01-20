# QueueListener.Demo
Demo listener running Azure functions in a container

To run this demo, build the docker container

```
docker build -t aqueuelistener .
```

Then run the container locally

```
docker run -e AzureWebJobsStorage=$CONN_STR -e ConnString=$SB_CONN_STR aqueuelistener:latest
```

where CONN_STR is a connection string for an Azure Storage Account and SB_CONN_STRING is the connection string for the service bus Namespace that the demo is listening to
