# 1. Baixa a imagem oficial do SDK do .NET 10. 
# Ela contém todas as ferramentas para compilar o código. O "AS Build" dá o nome de "Build" para esta etapa.
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS Build

# 2. Cria e define a pasta "/app_build" dentro do container como o diretório de trabalho atual.
WORKDIR /app_build  

# 3. Copia apenas o arquivo de projeto (.csproj) do seu computador para dentro da pasta atual do container.
COPY BancoAPI.csproj ./

# 4. Restaura todas as dependências e pacotes NuGet necessários para o projeto (faz isso antes para aproveitar o cache do Docker).
RUN dotnet restore

# 5. Copia o restante de todos os arquivos do seu código-fonte do computador para dentro do container.
COPY . ./

# 6. Compila a API em modo Release (otimizado) e joga os arquivos finais prontos na pasta "/app_publish".
RUN dotnet publish -c Release -o /app_publish

# 7. Inicia a segunda etapa. Baixa a imagem do ASP.NET Runtime 10. 
# Ela é bem leve porque só sabe EXECUTAR a API, não sabe compilar. O container final usará esta base.
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS RUNTIME

# 8. Define a pasta "/app_build" dentro deste novo container leve como o diretório de trabalho.
WORKDIR /app_build

# 9. O "pulo do gato": Copia os arquivos compilados lá da pasta "/app_publish" da primeira etapa ("Build") para a pasta atual deste novo container.
COPY --from=build /app_publish .

# 10. Avisa ao Docker (e a quem for rodar o container) que a API escuta conexões na porta interna 8080.
EXPOSE 8080

# 11. Define o comando principal que será executado assim que o container ligar, iniciando a sua API.
ENTRYPOINT [ "dotnet", "BancoAPI.dll" ]
