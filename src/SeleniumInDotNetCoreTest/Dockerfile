FROM microsoft/dotnet:1.1.0-sdk-projectjson
WORKDIR /dotnetapp

# copy and build everything else
COPY . .

RUN dotnet restore
ENTRYPOINT ["dotnet", "test"]