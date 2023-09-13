FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/OnlineExamSystem.Web.Host/OnlineExamSystem.Web.Host.csproj", "src/OnlineExamSystem.Web.Host/"]
COPY ["src/OnlineExamSystem.Web.Core/OnlineExamSystem.Web.Core.csproj", "src/OnlineExamSystem.Web.Core/"]
COPY ["src/OnlineExamSystem.Application/OnlineExamSystem.Application.csproj", "src/OnlineExamSystem.Application/"]
COPY ["src/OnlineExamSystem.Core/OnlineExamSystem.Core.csproj", "src/OnlineExamSystem.Core/"]
COPY ["src/OnlineExamSystem.EntityFrameworkCore/OnlineExamSystem.EntityFrameworkCore.csproj", "src/OnlineExamSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/OnlineExamSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/OnlineExamSystem.Web.Host", "src/OnlineExamSystem.Web.Host"]
COPY ["src/OnlineExamSystem.Web.Core", "src/OnlineExamSystem.Web.Core"]
COPY ["src/OnlineExamSystem.Application", "src/OnlineExamSystem.Application"]
COPY ["src/OnlineExamSystem.Core", "src/OnlineExamSystem.Core"]
COPY ["src/OnlineExamSystem.EntityFrameworkCore", "src/OnlineExamSystem.EntityFrameworkCore"]
WORKDIR "/src/src/OnlineExamSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "OnlineExamSystem.Web.Host.dll"]
