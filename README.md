# Introduction

This project demonstrates my understanding of the CLEAN architecture, and it uses XUnit to unit test different components of the application, ensuring error handling.

## Table of Content

- [Technologies](#technologies)
- [Project Structure](#project-strucutre)
- [Getting Started](#getting-started)

## Technologies

- C#

## Project Structure

```.gitignore
│   MediaPlayerWithTest.sln
│   README.md
├───MediaPlayerWithTest.Application
│   │   MediaPlayerWithTest.Application.csproj
│   └───src
│           MediaController.cs
│           PlayListController.cs
│           UserController.cs
│
├───MediaPlayerWithTest.Business
│   │   MediaPlayerWithTest.Business.csproj
│   │
│   └───src
│       ├───Service
│       │       MediaService.cs
│       │       PlayListService.cs
│       │       UserService.cs
│       │
│       └───ServiceInterface
│               IMediaService.cs
│               IPlayListService.cs
│               IUserService.cs
│
├───MediaPlayerWithTest.Domain
│   │   MediaPlayerWithTest.Domain.csproj
│   │
│   └───src
│       ├───Core
│       │       Audio.cs
│       │       BaseEntity.cs
│       │       MediaFile.cs
│       │       PlayList.cs
│       │       User.cs
│       │       Video.cs
│       │
│       └───RepositoryInterface
│               IMediaRepository.cs
│               IPlayListRepository.cs
│               IUserRepository.cs
│
├───MediaPlayerWithTest.Infrastructure
│   │   MediaPlayerWithTest.Infrastructure.csproj
    └───src
        ├───Core.Tests
        │       MediaFileTest.cs
        │       PlayListTest.cs
        │       UserTest.cs
        │
        └───Service.Tests
                MediaServiceTest.cs
```

## Getting Started

Clone the repository from github with `git clone`  
Run the code with `dotnet run`
