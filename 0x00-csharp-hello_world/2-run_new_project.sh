#!/usr/bin/env bash
# Initialize, build, and run
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project ./2-new_project