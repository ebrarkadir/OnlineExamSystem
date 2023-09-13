FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/OnlineExamSystem.Web.Mvc/OnlineExamSystem.Web.Mvc.csproj", "src/OnlineExamSystem.Web.Mvc/"]
COPY ["src/OnlineExamSystem.Web.Core/OnlineExamSystem.Web.Core.csproj", "src/OnlineExamSystem.Web.Core/"]
COPY ["src/OnlineExamSystem.Application/OnlineExamSystem.Application.csproj", "src/OnlineExamSystem.Application/"]
COPY ["src/OnlineExamSystem.Core/OnlineExamSystem.Core.csproj", "src/OnlineExamSystem.Core/"]
COPY ["src/OnlineExamSystem.EntityFrameworkCore/OnlineExamSystem.EntityFrameworkCore.csproj", "src/OnlineExamSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/OnlineExamSystem.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/OnlineExamSystem.Web.Mvc", "src/OnlineExamSystem.Web.Mvc"]
COPY ["src/OnlineExamSystem.Web.Core", "src/OnlineExamSystem.Web.Core"]
COPY ["src/OnlineExamSystem.Application", "src/OnlineExamSystem.Application"]
COPY ["src/OnlineExamSystem.Core", "src/OnlineExamSystem.Core"]
COPY ["src/OnlineExamSystem.EntityFrameworkCore", "src/OnlineExamSystem.EntityFrameworkCore"]
WORKDIR "/src/src/OnlineExamSystem.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "OnlineExamSystem.Web.Mvc.dll"]
