# Init Project

<img
 align="center"
 src="./.github/assets/picture.png"
 alt="Page Preview"
/>

## Specification

In Powersheel execute the command:

```sh
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser ​
```

please execute next commands in powersheel

## Install Dependencies

- [Download Visual Studio 2022](https://visualstudio.microsoft.com/es/downloads/)
- [Download Sql Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [Download Git](https://git-scm.com/download/win)
- [Download .Net 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## Developer Folder

```sh
cd C:\Users\nameUser\Documents\
mkdir Developer
cd Developer
```

## clone repository

```sh
git clone https://github.com/Savecoders/UgVoteQueen.git
cd UgVoteQueen
```

## Config git user

```sh
git config --global user.name "username"
git config --global user.email "email@gmail.com"
```

please using your username and email from github

> [!NOTE]
> It's the most important step from execute this project


## Run Project in normal mode

```sh
dotnet run
```

## Push and pull changes

```sh
git pull --set-upstream origin main
git push --set-upstream origin main
```
